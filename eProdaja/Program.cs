using API.Middleware;
using eProdaja.Services;
using eProdaja.Services.Database;
using eProdaja.Services.Helpers;
using eProdaja.Services.Interfaces;
using eProdaja.Services.StateMachine;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IProizvodiService, ProizvodiService>();
builder.Services.AddScoped<IKorisniciService, KorisniciService>();
builder.Services.AddScoped<IJediniceMjereService, JediniceMjereService>();
builder.Services.AddScoped<IUlogeService, UlogeService>();

builder.Services.AddTransient<ProductBaseState>();
builder.Services.AddTransient<ProductInitialState>();
builder.Services.AddTransient<ProductDraftState>();
builder.Services.AddTransient<ProductActiveState>();
builder.Services.AddTransient<ProductHiddenState>();

builder.Services.AddDbContext<EProdajaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
