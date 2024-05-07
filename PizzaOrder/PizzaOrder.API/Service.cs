using GraphQL;
using Microsoft.EntityFrameworkCore;
using PizzaOrder.Business.Services;
using PizzaOrder.Data;

namespace PizzaOrder;

public static class AppBuilder
{
    public static WebApplicationBuilder AppBuilderSetup(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<PizzaDBContext>(
            optionsAction:
                o =>
                {
                    o.UseSqlServer(builder.Configuration.GetConnectionString(args[args.Length - 1]));
                },
            contextLifetime:
                ServiceLifetime.Singleton
        );
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddGraphQL(GQLSettings);
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddTransient<IOrderDetailService, OrderDetailsService>();
        builder.Services.AddTransient<IPizzaDeteailService, PizzaDeteailService>();
        
        builder.Services.AddScoped<IServiceProvider>(
            svc => new FuncServiceProvider(
                typ => svc.GetRequiredService(typ)
                ));
        return builder;
    }
    private static void GQLSettings(GraphQL.DI.IGraphQLBuilder o)
    {
        o.AddUnhandledExceptionHandler(err => Console.WriteLine(err.OriginalException.Message));
        o.UseTelemetry();
    }
}
