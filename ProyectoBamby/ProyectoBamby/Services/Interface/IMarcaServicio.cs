using ProyectoBamby.Models;

namespace ProyectoBamby.Services.Interface
{
    public interface IMarcaServicio
    {
        Task<Marca> GetMarcasById(int id);
        Task<IEnumerable<Marca>> GetMarcas();
    }

}