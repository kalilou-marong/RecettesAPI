using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RecettesAPIContext>(options =>
		options.UseNpgsql(builder.Configuration.GetConnectionString("RecettesAPIContext")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
	options.SwaggerDoc("v1", new OpenApiInfo
	{
		Version = "v1",
		Title = "Recettes API HBKMAM",
		Description = "Une superbe API de recettes, pour les petits et les grands, de 7 à 77 ans",
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;

	SeedData.Initialize(services);
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
