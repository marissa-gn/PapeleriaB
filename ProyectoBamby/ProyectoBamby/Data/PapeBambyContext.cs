using ProyectoBamby.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBamby.Data
{
    public class PapeBambyContext : DbContext
    {

        public PapeBambyContext(DbContextOptions<PapeBambyContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.Entity<Marca>().HasData(
                new Marca { MarcaId = 1, Nombre = "Crayola" },
                new Marca { MarcaId = 2, Nombre = "Paper Mate" },
                new Marca { MarcaId = 3, Nombre = "Dixon" },
                new Marca { MarcaId = 4, Nombre = "Maped" },
                new Marca { MarcaId = 5, Nombre = "Bic" },
                new Marca { MarcaId = 6, Nombre = "Pelikan" },
                new Marca { MarcaId = 7, Nombre = "Azor" },
                new Marca { MarcaId = 8, Nombre = "Scribe" },
                new Marca { MarcaId = 9, Nombre = "Indra" }
                );
            modelBuilder.Entity<Tipo>().HasData(
                new Tipo { TipoId = 1, Nombre = "Escritura" },
                new Tipo { TipoId = 2, Nombre = "Organizacion" },
                new Tipo { TipoId = 3, Nombre = "Embalaje" },
                new Tipo { TipoId = 4, Nombre = "Tecnologia" },
                new Tipo { TipoId = 5, Nombre = "Arte" }
                );
            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor { Id = 1, Apellido = "Cruz Mateo", Nombre = "Jose Eduardo", Turno = "Matutino" },
                new Vendedor { Id = 2, Apellido = "Guzman Perez", Nombre = "Josefina", Turno = "Matutino" },
                new Vendedor { Id = 3, Apellido = "Gonzalez Palomares", Nombre = "Ana Maria", Turno = "Matutino" },
                new Vendedor { Id = 4, Apellido = "Solis Correa", Nombre = "Antonio", Turno = "Vespertino" },
                new Vendedor { Id = 5, Apellido = "Linares Cruz", Nombre = "Alejandra", Turno = "Vespertino" },
                new Vendedor { Id = 6, Apellido = "Flores Ortega", Nombre = "Evelyn", Turno = "Matutino" }
            );
          
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor { Id = 1, Nombre = "Rodolfo", Apellido = "Altamirano Socorro", MarcaId=1 },
                new Proveedor { Id = 2, Nombre = "Juan Carlos", Apellido = "Estrada Jimenez", MarcaId = 7 },
                new Proveedor { Id = 3, Nombre = "Hilario", Apellido = "Morales Rodriguez", MarcaId = 8 },
                new Proveedor { Id = 4, Nombre = "Laura", Apellido = "Ortega Navarrete", MarcaId = 2 },
                new Proveedor { Id = 5, Nombre = "Rodrigo", Apellido = "Perez Narvaez", MarcaId = 5 },
                new Proveedor { Id = 6, Nombre = "Sandra", Apellido = "Gonzalez Solis", MarcaId = 3 },
                new Proveedor { Id = 7, Nombre = "Julio Cesar", Apellido = "Alcantara Dominguez", MarcaId = 4 },
                new Proveedor { Id = 8, Nombre = "Alvaro", Apellido = "Ramirez Campos", MarcaId = 6 },
                new Proveedor { Id = 9, Nombre = "Karina", Apellido = "Sanchez Ross", MarcaId = 9 }
                );
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Cantidad = 89, Nombre = "Tijeras", Imagen = "Tijeras.jpg", MarcaId = 9, TipoId = 5, Precio = 15, Descripcion = "Herramienta de corte utilizada para recortar papel, cartulina u otros materiales." },
                new Producto { Id = 2, Cantidad = 20, Nombre = "Tijeras Piñatera", Imagen = "Tijeras.jpg", MarcaId = 1, TipoId = 5, Precio = 35, Descripcion = "Herramienta de corte utilizada para recortar papel, cartulina u otros materiales." },
                new Producto { Id = 3, Cantidad = 510,Nombre = "Cuadernos", Imagen = "Cuadernos.jpg", MarcaId = 8, TipoId = 1, Precio = 150, Descripcion = "Herramientas utilizados para tomar notas, realizar ejercicios, hacer dibujos o llevar un registro de las tareas y asignaturas. " },
                new Producto { Id = 4, Cantidad = 160, Nombre = "Plumines 100 piezas", Imagen = "pluminesCrayola.jpg", MarcaId = 1, TipoId = 5, Precio = 550, Descripcion = "Tipo de pluma conica con raquis muy corto, o ausente, cuyas barbas están sueltas y no se entrelazan" },
                new Producto { Id = 5, Cantidad = 56, Nombre = "Engrapadoras", Imagen = "Engrapadora.jpg", MarcaId = 6, TipoId = 2, Precio = 40, Descripcion = "Herramienta que se utiliza para unir varias hojas de papel juntas mediante grapas." },
                new Producto { Id = 6, Cantidad = 260, Nombre = "Regla", Imagen = "Reglas.jpg", MarcaId = 2, TipoId = 5, Precio = 10, Descripcion = "Una herramienta de medición utilizada para trazar líneas rectas o tomar medidas precisas." },
                new Producto { Id = 7, Cantidad = 50, Nombre = "Pegamento Grande", Imagen = "Prit.jpg", MarcaId = 4, TipoId = 5, Precio = 20, Descripcion = "Adhesivo utilizado para unir diferentes elementos, como papel, cartón o tela." },
                new Producto { Id = 8, Cantidad = 92, Nombre = "Sacapuntas", Imagen = "Sacapuntas.jpg", MarcaId = 9, TipoId = 5, Precio = 5, Descripcion = " Instrumento utilizado para afilar los lápices y mantener su punta en buen estado." },
                new Producto { Id = 9, Cantidad = 73, Nombre = "Carpetas y archivadores", Imagen = "Carpetas.jpg", MarcaId = 2, TipoId = 2, Precio = 90, Descripcion = "Utilizados para organizar y almacenar los documentos, hojas sueltas y trabajos realizados por los estudiantes.." },
                new Producto { Id = 10, Cantidad = 28, Nombre = "Calculadora", Imagen = "Calculadora.jpg", MarcaId = 9, TipoId = 4, Precio = 350, Descripcion= "Un dispositivo electrónico que se utiliza para realizar cálculos matemáticos." },
                new Producto { Id = 11, Cantidad = 46, Nombre = "Mochila", Imagen = "Mochila.jpg", MarcaId = 4, TipoId = 3, Precio = 550, Descripcion = "Una bolsa o morral donde se guardan todos los útiles escolares para transportarlos cómodamente." },
                new Producto { Id = 12, Cantidad = 25, Nombre = "Goma de borrar", Imagen = ".jpg", MarcaId = 6, TipoId = 5, Precio = 7, Descripcion = "Pequeñas herramientas utilizadas para eliminar los errores y borrar marcas de lápiz. " },
                new Producto { Id = 13, Cantidad = 82, Nombre = "Lápices y bolígrafos", Imagen = "Lapices.jpg", MarcaId = 2, TipoId = 1, Precio = 5, Descripcion = "Herramientas básicas de escritura que se utilizan para tomar apuntes y completar tareas." },
                new Producto { Id = 14, Cantidad = 92, Nombre = "Compas", Imagen = "Compas.jpg", MarcaId = 5, TipoId = 5, Precio = 60, Descripcion = " Un instrumento utilizado para trazar círculos y arcos." },
                new Producto { Id = 15, Cantidad = 83, Nombre = "Marcadores", Imagen = "Marcador.jpg", MarcaId = 3, TipoId = 5, Precio = 15, Descripcion = "Los marcadores son instrumentos de escritura con tinta líquida o de gel que se utilizan para resaltar o subrayar texto." },
                new Producto { Id = 16, Cantidad = 76, Nombre = "Post-it", Imagen = "Post-it.jpg", MarcaId = 4, TipoId = 5, Precio = 12, Descripcion = "Pequeñas notas adhesivas que se utilizan para escribir mensajes o recordatorios breves." },
                new Producto { Id = 17, Cantidad = 46, Nombre = "Mouse", Imagen = "Mouse.jpg", MarcaId = 8, TipoId = 4, Precio = 150, Descripcion = "Mouse para computadora, con clabe USB." },
                new Producto { Id = 18, Cantidad = 10, Nombre = "Audifonos", Imagen = "Audifonos.jpg", MarcaId = 2, TipoId = 4, Precio = 560, Descripcion = "Audifonos inhalambricos de larga duracion." },
                new Producto { Id = 19, Cantidad = 17, Nombre = "USB 16GB", Imagen = "USB.jpg", MarcaId = 7, TipoId = 4, Precio = 350, Descripcion = "Unidad de almacenamiento, USB" },
                new Producto { Id = 20, Cantidad = 900, Nombre = "Hojas blancas y de color", Imagen = "Hojas.jpg", MarcaId = 1, TipoId = 5, Precio = 1, Descripcion = "Hojas de tamaño carta, doble carta de color y blancas. 1 peso por 5 hojas" }
                );
             modelBuilder.Entity<Ventas>().HasData(
              new Ventas { Id = 1, ProductoId = 12, Cantidad = 6, VendedorId = 1, Total = 678 },
              new Ventas { Id = 2, ProductoId = 11, Cantidad = 14, VendedorId = 1, Total = 256 },
              new Ventas { Id = 3, ProductoId = 2, Cantidad = 65, VendedorId = 2, Total = 752 },
              new Ventas { Id = 4, ProductoId = 4, Cantidad = 78, VendedorId = 4, Total = 441 },
              new Ventas { Id = 5, ProductoId = 6, Cantidad = 3, VendedorId = 5, Total = 4731 },
              new Ventas { Id = 6, ProductoId = 8, Cantidad = 9, VendedorId = 6, Total = 426 },
              new Ventas { Id = 7, ProductoId = 13, Cantidad = 18, VendedorId = 3, Total = 751 },
              new Ventas { Id = 8, ProductoId = 1, Cantidad = 231, VendedorId = 1, Total = 424 },
              new Ventas { Id = 9, ProductoId = 4, Cantidad = 67, VendedorId = 2, Total = 785 },
              new Ventas { Id = 10, ProductoId = 9, Cantidad = 89, VendedorId = 3, Total = 242 },
              new Ventas { Id = 11, ProductoId = 10, Cantidad = 9, VendedorId = 6, Total = 862 },
              new Ventas { Id = 12, ProductoId = 5, Cantidad = 34, VendedorId = 4, Total = 853 },
              new Ventas { Id = 13, ProductoId = 7, Cantidad = 74, VendedorId = 5, Total = 326 },
              new Ventas { Id = 14, ProductoId = 20, Cantidad = 29, VendedorId = 3, Total = 947 },
              new Ventas { Id = 15, ProductoId = 17, Cantidad = 78, VendedorId = 2, Total = 632 },
              new Ventas { Id = 16, ProductoId = 18, Cantidad = 45, VendedorId = 1, Total = 9635 }
              );

            modelBuilder.Entity<Marca>()
                .HasMany<Producto>(x => x.Productos)
                .WithOne(s => s.Marca)
                .HasForeignKey(s => s.MarcaId);
            modelBuilder.Entity<Tipo>()
                .HasMany<Producto>(x => x.Productos)
                .WithOne(s => s.Tipo)
                .HasForeignKey(s => s.TipoId);
            //modelBuilder.Entity<Vendedor>()
            //    .HasMany<Ventas>(x=>x.Ventas)
            //    .WithOne(s => s.Vendedor)
            //    .HasForeignKey(s => s.VendedorId);
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3SC43RA;Database=Cerveceria;user=marissa;pwd=3312marissa;Encrypt=False;Trusted_Connection=True;");
        }*/
    }
}