using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecettesAPI_HBKMAM.Migrations
{
    /// <inheritdoc />
    public partial class editRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientAmount_Recette_RecipeId_Recipe",
                table: "IngredientAmount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recette",
                table: "Recette");

            migrationBuilder.RenameTable(
                name: "Recette",
                newName: "Recipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id_Recipe");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientAmount_Recipe_RecipeId_Recipe",
                table: "IngredientAmount",
                column: "RecipeId_Recipe",
                principalTable: "Recipe",
                principalColumn: "Id_Recipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientAmount_Recipe_RecipeId_Recipe",
                table: "IngredientAmount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recette");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recette",
                table: "Recette",
                column: "Id_Recipe");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientAmount_Recette_RecipeId_Recipe",
                table: "IngredientAmount",
                column: "RecipeId_Recipe",
                principalTable: "Recette",
                principalColumn: "Id_Recipe");
        }
    }
}
