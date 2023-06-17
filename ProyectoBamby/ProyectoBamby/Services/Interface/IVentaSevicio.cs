using ProyectoBamby.Models;
namespace ProyectoBamby.Services.Interface
{
    public interface IVentaSevicio
    {
        Task<Ventas> GetVentasById(int id);
        Task<IEnumerable<Ventas>> GetVentas();
    }
}
