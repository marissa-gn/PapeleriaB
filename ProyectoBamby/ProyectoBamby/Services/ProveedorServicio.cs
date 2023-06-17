using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class ProveedorServicio : IProveedorServicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public ProveedorServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await this._papeBambyContext.Proveedores.ToListAsync();
        }

        public async Task<Proveedor> GetProveedoresById(int id)
        {
            return await this._papeBambyContext.Proveedores.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}