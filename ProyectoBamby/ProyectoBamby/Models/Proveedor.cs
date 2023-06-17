namespace ProyectoBamby.Models
{
    public class Proveedor
    {
            public Proveedor()
            {
                Marcas = new HashSet<Marca>();
            }
            public int Id { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public int MarcaId { get; set; }
        public ICollection<Marca> Marcas { get; set; }


        }
    }

