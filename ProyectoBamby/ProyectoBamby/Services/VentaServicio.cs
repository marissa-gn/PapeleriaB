using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class VentaServicio : IVentaSevicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public VentaServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Ventas>> GetVentas()
        {
            return await this._papeBambyContext.Ventas.ToListAsync();
        }

        public async Task<Ventas> GetVentasById(int id)
        {
            return await this._papeBambyContext.Ventas.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}