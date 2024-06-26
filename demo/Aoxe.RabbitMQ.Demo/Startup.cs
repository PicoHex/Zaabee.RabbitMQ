﻿namespace Aoxe.RabbitMQ.Demo;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSwaggerDocument();
        services.AddControllers();
        services.AddSingleton<IAoxeRabbitMqClient>(
            _ =>
                new AoxeRabbitMqClient(
                    new AoxeRabbitMqOptions
                    {
                        AutomaticRecoveryEnabled = true,
                        // Hosts = new List<string> { "192.168.78.130" },
                        Hosts =  ["127.0.0.1"],
                        UserName = "admin",
                        Password = "123",
                        Serializer = new NewtonsoftJson.Serializer()
                    }
                )
        );
        services.AddScoped<Subscriber, Subscriber>();
        services.AddHostedService<RabbitMqBackgroundService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
        app.UseOpenApi();
        app.UseSwaggerUi();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
