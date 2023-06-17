using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class TipoServicio : ITipoServicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public TipoServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Tipo>> GetTipos()
        {
            return await this._papeBambyContext.Tipos.ToListAsync();
        }

        public async Task<Tipo> GetTiposById(int id)
        {
            return await this._papeBambyContext.Tipos.FirstOrDefaultAsync(x => x.TipoId.Equals(id));
        }
    }
}