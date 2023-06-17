using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoBamby.Migrations
{
    /// <inheritdoc />
    public partial class Bamby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                    table.ForeignKey(
                        name: "FK_Marcas_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "MarcaId", "Nombre", "ProveedorId" },
                values: new object[,]
                {
                    { 1, "Crayola", null },
                    { 2, "Paper Mate", null },
                    { 3, "Dixon", null },
                    { 4, "Maped", null },
                    { 5, "Bic", null },
                    { 6, "Pelikan", null },
                    { 7, "Azor", null },
                    { 8, "Scribe", null },
                    { 9, "Indra", null }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Apellido", "MarcaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Altamirano Socorro", 1, "Rodolfo" },
                    { 2, "Estrada Jimenez", 7, "Juan Carlos" },
                    { 3, "Morales Rodriguez", 8, "Hilario" },
                    { 4, "Ortega Navarrete", 2, "Laura" },
                    { 5, "Perez Narvaez", 5, "Rodrigo" },
                    { 6, "Gonzalez Solis", 3, "Sandra" },
                    { 7, "Alcantara Dominguez", 4, "Julio Cesar" },
                    { 8, "Ramirez Campos", 6, "Alvaro" },
                    { 9, "Sanchez Ross", 9, "Karina" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Escritura" },
                    { 2, "Organizacion" },
                    { 3, "Embalaje" },
                    { 4, "Tecnologia" },
                    { 5, "Arte" }
                });

            migrationBuilder.InsertData(
                table: "Vendedores",
                columns: new[] { "Id", "Apellido", "Nombre", "Turno" },
                values: new object[,]
                {
                    { 1, "Cruz Mateo", "Jose Eduardo", "Matutino" },
                    { 2, "Guzman Perez", "Josefina", "Matutino" },
                    { 3, "Gonzalez Palomares", "Ana Maria", "Matutino" },
                    { 4, "Solis Correa", "Antonio", "Vespertino" },
                    { 5, "Linares Cruz", "Alejandra", "Vespertino" },
                    { 6, "Flores Ortega", "Evelyn", "Matutino" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Cantidad", "Descripcion", "Imagen", "MarcaId", "Nombre", "Precio", "TipoId" },
                values: new object[,]
                {
                    { 1, 89, "Herramienta de corte utilizada para recortar papel, cartulina u otros materiales.", "Tijeras.jpg", 9, "Tijeras", 15m, 5 },
                    { 2, 20, "Herramienta de corte utilizada para recortar papel, cartulina u otros materiales.", "Tijeras.jpg", 1, "Tijeras Piñatera", 35m, 5 },
                    { 3, 510, "Herramientas utilizados para tomar notas, realizar ejercicios, hacer dibujos o llevar un registro de las tareas y asignaturas. ", "Cuadernos.jpg", 8, "Cuadernos", 150m, 1 },
                    { 4, 160, "Tipo de pluma conica con raquis muy corto, o ausente, cuyas barbas están sueltas y no se entrelazan", "pluminesCrayola.jpg", 1, "Plumines 100 piezas", 550m, 5 },
                    { 5, 56, "Herramienta que se utiliza para unir varias hojas de papel juntas mediante grapas.", "Engrapadora.jpg", 6, "Engrapadoras", 40m, 2 },
                    { 6, 260, "Una herramienta de medición utilizada para trazar líneas rectas o tomar medidas precisas.", "Reglas.jpg", 2, "Regla", 10m, 5 },
                    { 7, 50, "Adhesivo utilizado para unir diferentes elementos, como papel, cartón o tela.", "Prit.jpg", 4, "Pegamento Grande", 20m, 5 },
                    { 8, 92, " Instrumento utilizado para afilar los lápices y mantener su punta en buen estado.", "Sacapuntas.jpg", 9, "Sacapuntas", 5m, 5 },
                    { 9, 73, "Utilizados para organizar y almacenar los documentos, hojas sueltas y trabajos realizados por los estudiantes..", "Carpetas.jpg", 2, "Carpetas y archivadores", 90m, 2 },
                    { 10, 28, "Un dispositivo electrónico que se utiliza para realizar cálculos matemáticos.", "Calculadora.jpg", 9, "Calculadora", 350m, 4 },
                    { 11, 46, "Una bolsa o morral donde se guardan todos los útiles escolares para transportarlos cómodamente.", "Mochila.jpg", 4, "Mochila", 550m, 3 },
                    { 12, 25, "Pequeñas herramientas utilizadas para eliminar los errores y borrar marcas de lápiz. ", ".jpg", 6, "Goma de borrar", 7m, 5 },
                    { 13, 82, "Herramientas básicas de escritura que se utilizan para tomar apuntes y completar tareas.", "Lapices.jpg", 2, "Lápices y bolígrafos", 5m, 1 },
                    { 14, 92, " Un instrumento utilizado para trazar círculos y arcos.", "Compas.jpg", 5, "Compas", 60m, 5 },
                    { 15, 83, "Los marcadores son instrumentos de escritura con tinta líquida o de gel que se utilizan para resaltar o subrayar texto.", "Marcador.jpg", 3, "Marcadores", 15m, 5 },
                    { 16, 76, "Pequeñas notas adhesivas que se utilizan para escribir mensajes o recordatorios breves.", "Post-it.jpg", 4, "Post-it", 12m, 5 },
                    { 17, 46, "Mouse para computadora, con clabe USB.", "Mouse.jpg", 8, "Mouse", 150m, 4 },
                    { 18, 10, "Audifonos inhalambricos de larga duracion.", "Audifonos.jpg", 2, "Audifonos", 560m, 4 },
                    { 19, 17, "Unidad de almacenamiento, USB", "USB.jpg", 7, "USB 16GB", 350m, 4 },
                    { 20, 900, "Hojas de tamaño carta, doble carta de color y blancas. 1 peso por 5 hojas", "Hojas.jpg", 1, "Hojas blancas y de color", 1m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "Cantidad", "ProductoId", "Total", "VendedorId" },
                values: new object[,]
                {
                    { 1, 6, 12, 678m, 1 },
                    { 2, 14, 11, 256m, 1 },
                    { 3, 65, 2, 752m, 2 },
                    { 4, 78, 4, 441m, 4 },
                    { 5, 3, 6, 4731m, 5 },
                    { 6, 9, 8, 426m, 6 },
                    { 7, 18, 13, 751m, 3 },
                    { 8, 231, 1, 424m, 1 },
                    { 9, 67, 4, 785m, 2 },
                    { 10, 89, 9, 242m, 3 },
                    { 11, 9, 10, 862m, 6 },
                    { 12, 34, 5, 853m, 4 },
                    { 13, 74, 7, 326m, 5 },
                    { 14, 29, 20, 947m, 3 },
                    { 15, 78, 17, 632m, 2 },
                    { 16, 45, 18, 9635m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_ProveedorId",
                table: "Marcas",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoId",
                table: "Productos",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_VendedorId",
                table: "Ventas",
                column: "VendedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
