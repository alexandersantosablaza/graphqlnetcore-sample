using Microsoft.EntityFrameworkCore;
using PizzaOrder.Data;

var builder = WebApplication.CreateBuilder(args);

string PizzaOrderDB = "PizzaOrderDB";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<PizzaDBContext>(
    optionsAction: 
        o => o.UseSqlServer(builder.Configuration.GetConnectionString(PizzaOrderDB)), 
    contextLifetime:
        ServiceLifetime.Singleton
        );
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.Services.GetService<PizzaDBContext>()?.Seed();

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
