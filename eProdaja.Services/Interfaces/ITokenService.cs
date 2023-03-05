using eProdaja.Services.Database;

namespace eProdaja.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(Korisnici user);
    }
}
