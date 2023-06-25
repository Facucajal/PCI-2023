using Microsoft.AspNetCore.Builder;
using System.Reflection;
using Microsoft.OpenApi.Models;
using BETARJETA_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "BETarjeta", Version = "v1" });
        });
        services.AddDbContext<AplicationDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}
