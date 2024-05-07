using PizzaOrder.Data;
using static PizzaOrder.AppBuilder;

var app = AppBuilderSetup([.. args,"PizzaOrderDB"]).Build();

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
