using PizzaOrder.Data;
using static PizzaOrder.AppBuilder;

args.SetValue("PizzaOrderDB", args.Length);

var app = AppBuilderSetup(args).Build();

app.UseGraphQLAltair();

app.Services.GetService<PizzaDBContext>()?.Seed();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseWebSockets();

app.UseAuthorization();

app.MapControllers();

app.Run();
