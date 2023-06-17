using ProyectoBamby.Models;

namespace ProyectoBamby.Services.Interface
{
    public interface IProveedorServicio
    {
        Task<Proveedor> GetProveedoresById(int id);
        Task<IEnumerable<Proveedor>> GetProveedores();
    }
}
