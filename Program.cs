using Assessment_BernersLee_API.Data;
using Assessment_BernersLee_API.Repositories;
using Assessment_BernersLee_API.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

Env.Load();
//Create the environment variables
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
//Configuration of the connection string
var connectionString = $"server={dbHost};port={dbPort};database={dbName};uid={dbUsername};password={dbPassword}";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.80-mysql")));

// Add services to the container.

builder.Services.AddScoped<IAdminRepository, AdminServices>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
