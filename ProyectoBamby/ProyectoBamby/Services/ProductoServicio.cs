using ProyectoBamby.Data;
using ProyectoBamby.Models;
using ProyectoBamby.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Services
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly PapeBambyContext _papeBambyContext;
        public ProductoServicio(PapeBambyContext papeBambyContext)
        {
            this._papeBambyContext = papeBambyContext;
        }
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await this._papeBambyContext.Productos.ToListAsync();
        }

        public async Task<Producto> GetProductosById(int id)
        {
            return await this._papeBambyContext.Productos.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}