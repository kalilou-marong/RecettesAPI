﻿using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Models;



namespace RecettesAPI_HBKMAM.Data;

public class RecettesAPIContext : DbContext
{
	public RecettesAPIContext() { }
	public RecettesAPIContext(DbContextOptions<RecettesAPIContext> options) : base(options) { }
	public DbSet<Recipe> Recipe { get; set; }
	public DbSet<Ingredient> Ingredient { get; set; }
	public DbSet<Categorie> Category { get; set; }
	
	public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
    public object Categorie { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
		=> optionsbuilder.UseNpgsql("host=localhost:5433;database=RecettesAPI-db;username=recettesAPI_dev;password=pg_strong_password");
}
