namespace ProyectoBamby.Models
{
public class Ventas
{
    [key]    
    public int Id { get; set; }

        public int ProductoId{ get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int VendedorId { get; set; } 

        public virtual Producto Producto { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}

