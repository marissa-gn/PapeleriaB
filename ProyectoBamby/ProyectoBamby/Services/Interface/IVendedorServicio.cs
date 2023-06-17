using ProyectoBamby.Models;
namespace ProyectoBamby.Services.Interface
{
    public interface IVendedorServicio
    {
        Task<Vendedor> GetVendedoresById(int id);
        Task<IEnumerable<Vendedor>> GetVendedores();
    }
}
