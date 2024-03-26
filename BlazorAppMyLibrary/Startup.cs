using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Other service configurations...

        services.AddCors(options =>
        {
            options.AddPolicy("AllowBlazorProject",
                builder =>
                {
                    builder.WithOrigins("http://localhost:5250")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        // Other service configurations...
    }

    public void Configure(IApplicationBuilder app)
    {
        // Other middleware configurations...

        app.UseCors("AllowBlazorProject");

        // Other middleware configurations...

        app.UseStaticFiles();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }
}
