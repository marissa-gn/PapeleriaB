using ProyectoBamby.Models;

namespace ProyectoBamby.Services.Interface
{
    public interface IProductoServicio
    {
        Task<Producto> GetProductosById(int id);
        Task<IEnumerable<Producto>> GetProductos();
    }
}