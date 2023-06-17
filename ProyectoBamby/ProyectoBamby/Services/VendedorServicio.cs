using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class VendedorServicio : IVendedorServicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public VendedorServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Vendedor>> GetVendedores()
        {
            return await this._papeBambyContext.Vendedores.ToListAsync();
        }

        public async Task<Vendedor> GetVendedoresById(int id)
        {
            return await this._papeBambyContext.Vendedores.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}