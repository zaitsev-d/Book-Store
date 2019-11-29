using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class BookStoreItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookStoreItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookItemID = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    BookStoreID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStoreItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookStoreItems_Book_BookItemID",
                        column: x => x.BookItemID,
                        principalTable: "Book",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookStoreItems_BookItemID",
                table: "BookStoreItems",
                column: "BookItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStoreItems");
        }
    }
}
