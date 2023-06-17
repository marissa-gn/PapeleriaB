using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class MarcaServicio : IMarcaServicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public MarcaServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Marca>> GetMarcas()
        {
            return await this._papeBambyContext.Marcas.ToListAsync();
        }

        public async Task<Marca> GetMarcasById(int id)
        {
            return await this._papeBambyContext.Marcas.FirstOrDefaultAsync(x => x.MarcaId.Equals(id));
        }
    }
}