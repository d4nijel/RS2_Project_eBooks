using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using eBooks.WebAPI.Database;
using eBooks.WebAPI.Filters;
using eBooks.WebAPI.Security;
using eBooks.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eBooks.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            var connection = @"Server=.;Database=140256;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<_140256Context>(options => options.UseSqlServer(connection));

            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKupciService, KupciService>();

            services.AddScoped<IService<Model.Drzave, object>, DrzaveService>();
            services.AddScoped<IService<Model.Gradovi, object>, BaseService<Model.Gradovi, object, Database.Gradovi>>();
            services.AddScoped<IService<Model.Kategorije, object>, BaseService<Model.Kategorije, object, Database.Kategorije>>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();

            services.AddScoped<ICRUDService<Model.AutoriKnjige, object, Model.AutoriKnjige, Model.AutoriKnjige>, BaseCRUDService<Model.AutoriKnjige, object, Database.AutoriKnjige, Model.AutoriKnjige, Model.AutoriKnjige>>();
            services.AddScoped<ICRUDService<Model.KnjigeKategorije, object, Model.KnjigeKategorije, Model.KnjigeKategorije>, BaseCRUDService<Model.KnjigeKategorije, object, Database.KnjigeKategorije, Model.KnjigeKategorije, Model.KnjigeKategorije>>();


            services.AddScoped<ICRUDService<Model.Autori, Model.Requests.AutoriSearchRequest, Model.Requests.AutoriUpsertRequest, Model.Requests.AutoriUpsertRequest>, AutoriServices>();
            services.AddScoped<ICRUDService<Model.Knjige, Model.Requests.KnjigeSearchRequest, Model.Requests.KnjigeUpsertRequest, Model.Requests.KnjigeUpsertRequest>, KnjigeService>();
            services.AddScoped<ICRUDService<Model.Narudzbe, Model.Requests.NarudzbeSearchRequest, Model.Requests.NarudzbeUpsertRequest, Model.Requests.NarudzbeUpsertRequest>, NarudzbeService>();
            services.AddScoped<ICRUDService<Model.Racuni, Model.Requests.RacuniSearchRequest, Model.Requests.RacuniUpsertRequest, Model.Requests.RacuniUpsertRequest>, RacuniService>();
            services.AddScoped<ICRUDService<Model.RacunStavke, Model.Requests.RacunStavkeSearchRequest, Model.Requests.RacunStavkeUpsertRequest, Model.Requests.RacunStavkeUpsertRequest>, RacunStavkeService>();
            services.AddScoped<ICRUDService<Model.NarudzbaStavke, Model.Requests.NarudzbeStavkeSearchRequest, Model.Requests.NarudzbeStavkeUpsertRequest, Model.Requests.NarudzbeStavkeUpsertRequest>, NarudzbeStavkeService>();
            services.AddScoped<ICRUDService<Model.Ocjene, Model.Requests.OcjeneSearchRequest, Model.Requests.OcjeneUpsertRequest, Model.Requests.OcjeneUpsertRequest>, OcjeneService>();
            services.AddScoped<ICRUDService<Model.Izdavaci, Model.Requests.IzdavaciSearchRequest, Model.Requests.IzdavaciUpsertRequest, Model.Requests.IzdavaciUpsertRequest>, IzdavaciServices>();
            services.AddScoped<ICRUDService<Model.Kolekcije, Model.Requests.KolekcijeSearchRequest, Model.Requests.KolekcijeUpsertRequest, Model.Requests.KolekcijeUpsertRequest>, KolekcijeService>();
            services.AddScoped<ICRUDService<Model.Ugovori, Model.Requests.UgovoriSearchRequest, Model.Requests.UgovoriUpsertRequest, Model.Requests.UgovoriUpsertRequest>, UgovoriService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
