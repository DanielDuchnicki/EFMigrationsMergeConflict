using EFMigrationsMergeConflictApi.Infrastructure;
using Microsoft.EntityFrameworkCore;

const string ConnectionStringName = "EFMigrationsMergeConflictDb";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Entity Framework config
builder.Services.AddDbContext<EFMigrationsMergeConflictContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionStringName)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
