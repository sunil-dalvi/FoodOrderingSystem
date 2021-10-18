using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrderingSystem.Migrations
{
    public partial class AddedDBSetForMenusAndReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurants_RestaurantID",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Restaurants_RestaurantID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Users_UserID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Restaurants_RestaurantID1",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menues");

            migrationBuilder.RenameIndex(
                name: "IX_Table_RestaurantID1",
                table: "Tables",
                newName: "IX_Tables_RestaurantID1");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_RestaurantID",
                table: "Reviews",
                newName: "IX_Reviews_RestaurantID");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_RestaurantID",
                table: "Menues",
                newName: "IX_Menues_RestaurantID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                columns: new[] { "TableNumber", "RestaurantID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menues",
                table: "Menues",
                columns: new[] { "MenuName", "RestaurantID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Menues_Restaurants_RestaurantID",
                table: "Menues",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantID",
                table: "Reviews",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID1",
                table: "Tables",
                column: "RestaurantID1",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menues_Restaurants_RestaurantID",
                table: "Menues");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID1",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menues",
                table: "Menues");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Menues",
                newName: "Menu");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_RestaurantID1",
                table: "Table",
                newName: "IX_Table_RestaurantID1");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "Review",
                newName: "IX_Review_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_RestaurantID",
                table: "Review",
                newName: "IX_Review_RestaurantID");

            migrationBuilder.RenameIndex(
                name: "IX_Menues_RestaurantID",
                table: "Menu",
                newName: "IX_Menu_RestaurantID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                columns: new[] { "TableNumber", "RestaurantID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                columns: new[] { "MenuName", "RestaurantID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Restaurants_RestaurantID",
                table: "Menu",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Restaurants_RestaurantID",
                table: "Review",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Users_UserID",
                table: "Review",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Restaurants_RestaurantID1",
                table: "Table",
                column: "RestaurantID1",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
