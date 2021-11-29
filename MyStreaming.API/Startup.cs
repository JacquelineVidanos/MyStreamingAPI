using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyStreaming.API.Services.AlertasService;
using MyStreaming.API.Services.CapitulosService;
using MyStreaming.API.Services.DatosBanService;
using MyStreaming.API.Services.SuscripcionesService;
using MyStreaming.API.Services.TemporadasService;
using MyStreaming.API.UsuariosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API
{
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
            services.AddControllers();
            services.AddDbContextPool<MyStreamingContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MyStreamingDBContextConnectionString")));
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IAlertaService, AlertaService>();
            services.AddScoped<ICapituloService, CapituloService>();
            services.AddScoped<IDatoBanService, DatoBanService>();
            services.AddScoped<ISuscripcionService, SuscripcionService>();
            services.AddScoped<ITemporadaService, TemporadaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
