using HotChocolate.AspNetCore;
using Refit;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.File(path: @"logs\log.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));


builder.Services
        .AddScoped<IDeviceOneRepository, DeviceOneRepository>()
        .AddScoped<IDeviceTwoRepository, DeviceTwoRepository>()
        .AddGraphQLServer()
        .AddQueryType(d => d.Name("Query"))
            .AddTypeExtension<DeviceOneRoot>()
            .AddTypeExtension<DeviceTwoRoot>()
        .AddErrorFilter<GraphQLErrorFilter>();

builder.Services
    .AddRefitClient<DeviceApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration["ManagementApiUrl"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

app.UseHttpsRedirection();

//app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints
        .MapGraphQL().WithOptions(new GraphQLServerOptions
        {
            Tool =
        { // Disable the graphql interactive playground when building release.
#if DEBUG
						Enable = true
#else
						Enable = true
#endif
        }
        }); ;
});

app.UseGraphQLVoyager("/graphql-voyager");
app.Run();