using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http;
//using demoApplicationLayer;
//using demoInfrastructure;
//using demoPresentationLayer;
//using Serilog;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this m ethod to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /////
            /// PROJECT D.I.
            /// 
            //services.AddApplication()
            //    .AddInfrastructure()
            //    .AddPresentation();


            /////
            /// ADD SERILOG
            /// 
            //Host.UseSerilog((context, configuration) =>
            //configuration.ReadFrom.Configuration(context.Configuration));


            /////
            /// ENABLE C.O.R.S
            /// 
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });


            /////
            /// JSON SERIALIZER
            ///                
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
                = new DefaultContractResolver());


            ///
            services.AddControllers();

            /////
            /// ADDED SWAGGER/OPEN API
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });


            /////   DATABASE CONNECTION
            ///     ADD TO CONNECT TO SPECIFIC CLASSES USING EFCORE
            services.AddDbContext<OGDatabaseSchemaV2Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));  //You have to save DBConnectionString in the appsettings.json file
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            ///////   USE
            ///// EXAMPLE OF USE METHOD & CONTEXT RESPONSE WRITE ASYNC
            ///// CAN WRITE TO HOME PAGE OF API
            ///////
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from USE Method \n");

            //    await next();
            //});


            ///////   CUSTOM MIDDLEWARE
            ///// EXAMPLE OF BRANCH MAPPING USING THE MAP OR MAPWHEN Method
            ///// ALONG WITH GENERATING A METHOD
            ///////
            //app.Map("/api/Adrian", CustomCode);


            ///////   RUN
            ///// EXAMPLE OF RUN CONTEXT METHOD & RESPONSE WRITE ASYNC
            ///// CAN WRITE TO HOME PAGE OF API
            ///////
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from RUN Method \n");
            //});


            //////
            ///ENABLE C.O.R.S.
            ///
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                /////
                /// ADDED SWAGGER ENDPOINTS
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));


            }


            app.UseDefaultFiles();
            app.UseStaticFiles();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


        ///// <summary>
        ///// GENERATED METHOD FOR CUSTOMCODE
        ///// </summary>
        ///// <param name="obj"></param>
        //private void CustomCode(IApplicationBuilder app)
        //{
        //    app.Use(async (context, next) =>
        //    {
        //        await context.Response.WriteAsync("Hello from Adrian \n");                               
        //    });
        //}
    }
}
