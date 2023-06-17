using ProyectoBamby.Models;

namespace ProyectoBamby.Services.Interface
{
    public interface ITipoServicio
    {
        Task<Tipo> GetTiposById(int id);
        Task<IEnumerable<Tipo>> GetTipos();
    }
}