using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppPokemon.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpAtk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpDef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    legendary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
