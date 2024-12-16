using CleanCode_Labb2.Data;
using CleanCode_Labb2.Interfaces;
using CleanCode_Labb2.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<BookDbContext>(
    options => options.UseSqlServer(connectionString)
);


builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BookDbContext>();
    dbContext.Database.Migrate();
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
