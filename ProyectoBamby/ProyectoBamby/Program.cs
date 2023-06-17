using ProyectoBamby.Data;
using ProyectoBamby.Services;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
builder.Services.AddTransient<IMarcaServicio, MarcaServicio>();
builder.Services.AddTransient<IVentaSevicio, VentaServicio>();
builder.Services.AddTransient<IVendedorServicio, VendedorServicio>();
builder.Services.AddTransient<ITipoServicio, TipoServicio>();
builder.Services.AddTransient<IProductoServicio, ProductoServicio>();
builder.Services.AddTransient<IProveedorServicio, ProveedorServicio>();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PapeBambyContext>(x => x.UseSqlServer(@"Server=DESKTOP-3SC43RA;Database=ProyectoBamby;user=marissa;pwd=3312marissa;Encrypt=False;Trusted_Connection=True;"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();