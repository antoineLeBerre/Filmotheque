using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Filmotheque.Migrations
{
    public partial class init_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "f_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Prenom = table.Column<string>(maxLength: 25, nullable: false),
                    Nom = table.Column<string>(maxLength: 75, nullable: false),
                    Age = table.Column<int>(maxLength: 110, nullable: false),
                    Ville = table.Column<string>(maxLength: 75, nullable: false),
                    Pays = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_f_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_f_User_Email",
                table: "f_User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "f_User");
        }
    }
}
