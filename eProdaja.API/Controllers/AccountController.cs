using AutoMapper;
using eProdaja.Models;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace eProdaja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly EProdajaContext _context;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public AccountController(EProdajaContext context, IMapper mapper, ITokenService tokenService)
        {
            _context = context;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<KorisniciDto>> LoginAsync(LoginDto login)
        {
            var user = await _context.Korisnici
                .Include(k => k.KorisniciUloges)
                .ThenInclude(ku => ku.Uloga)
                .SingleOrDefaultAsync(k => k.KorisnickoIme == login.Username);

            if (user == null) return Unauthorized("Pogresno korisnicko ime ili password");

            using var hmac = new HMACSHA512(Convert.FromBase64String(user.LozinkaSalt));

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(login.Password));

            if (user.LozinkaHash != Convert.ToBase64String(computedHash))
                return Unauthorized("Pogresno korisnicko ime ili password");

            var korisnik = _mapper.Map<KorisniciDto>(user);

            korisnik.Token = _tokenService.CreateToken(user);

            return korisnik;
        }
    }

}
