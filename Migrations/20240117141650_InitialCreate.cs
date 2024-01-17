using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RecettesAPI_HBKMAM.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id_categorie = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Photo_url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id_categorie);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id_Ingredient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ingredient_name = table.Column<string>(type: "text", nullable: false),
                    Photo_url_ingredient = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id_Ingredient);
                });

            migrationBuilder.CreateTable(
                name: "Recette",
                columns: table => new
                {
                    Id_Recipe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_categorie = table.Column<int>(type: "integer", nullable: false),
                    Photo_url = table.Column<string>(type: "text", nullable: false),
                    Photo_array = table.Column<List<string>>(type: "text[]", nullable: false),
                    Time = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recette", x => x.Id_Recipe);
                });

            migrationBuilder.CreateTable(
                name: "IngredientAmount",
                columns: table => new
                {
                    Id_IngredientRecipe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Ingredient = table.Column<int>(type: "integer", nullable: false),
                    Id_Recipe = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<string>(type: "text", nullable: false),
                    RecipeId_Recipe = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientAmount", x => x.Id_IngredientRecipe);
                    table.ForeignKey(
                        name: "FK_IngredientAmount_Recette_RecipeId_Recipe",
                        column: x => x.RecipeId_Recipe,
                        principalTable: "Recette",
                        principalColumn: "Id_Recipe");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientAmount_RecipeId_Recipe",
                table: "IngredientAmount",
                column: "RecipeId_Recipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "IngredientAmount");

            migrationBuilder.DropTable(
                name: "Recette");
        }
    }
}
