using Intelitrader.Dominio.Comandos.VagaCommands;
using Intelitrader.Dominio.Handlers.Autenticacao;
using Intelitrader.Dominio.Handlers.Autenticacao.VagaHandler;
using Intelitrader.Dominio.Handlers.Usuarios;
using Intelitrader.Dominio.Handlers.UsuariosHandler;
using Intelitrader.Dominio.Repositorios;
using Intelitrader.Infa.Data.Contexts;
using Intelitrader.Infa.Data.Repositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intelitrader.Api
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

            // Contexto de banco

            services.AddDbContext<IntelitraderContext>(z => z.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen(c =>
            {   
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Intelitrader.Api", Version = "v1" });
            });

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {

                options.TokenValidationParameters = new TokenValidationParameters
                {

                    //quem est? emitindo
                    ValidateIssuer = true,

                    //quem est? validando
                    ValidateAudience = true,

                    //define que o tempo de expira??o ser? validado
                    ValidateLifetime = true,

                    ValidateIssuerSigningKey = true,

                    //nome do issuer, de onde est? vindo
                    ValidIssuer = "Intelitreder",

                    //nome do audience, de onde est? indo
                    ValidAudience = "Intelitreder",

                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("ChaveSecretaIntelitraderSenai132"))

                };

            });

            // CORS
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                                        .AllowAnyMethod()
                                        .AllowAnyHeader());
            });


            // Inje??es de depend?ncias
            #region Inje??o de depend?ncia dos Usuarios
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<CriarContaHandle, CriarContaHandle>();
            services.AddTransient<LogarHandle, LogarHandle>();
            services.AddTransient<AtualizarContaHandle, AtualizarContaHandle>();
            //services.AddTransient<DeletarUsuarioHandle, DeletarUsuarioHandle>();
            #endregion

            #region Inje??o de depend?ncia das Vagas
            services.AddTransient<IVagaRepositorio, VagaRepositorio>();
            services.AddTransient<CriarVagaHandle, CriarVagaHandle>();
            services.AddTransient<ListarVagaHandle, ListarVagaHandle>();
            services.AddTransient<AtualizarVagaHandle, AtualizarVagaHandle>();
            //services.AddTransient<DeletarVagaHandle, DeletarVagaHandle>();
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Intelitrader.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(), "Resources")),
                RequestPath = "/Resources/Imagens"
            });


            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
