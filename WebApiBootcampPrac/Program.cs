using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiBootcampPrac.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebApiBootcampPracContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevDb") ?? throw new InvalidOperationException("Connection string 'WebApiBootcampPracContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
