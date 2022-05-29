﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Project1.Models;
//using Project1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Project1
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project1", Version = "v1" });
            });
            
            //services.AddScoped<IRepo<FundTransfer>, FundTransferRepo>();
            services.AddDbContext<Project1Context>(option => option.UseSqlServer(Configuration.GetConnectionString("ProjConn")));
            //services.AddCors();
            /*services.AddCors(options => options.AddPolicy("allow", builder =>
            {
                builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
            }));*/


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory factory)
        {
            //   app.UseCors(options=>options.WithOrigins("http://localhost:4200")
            //.AllowAnyMethod()
            //.AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FundTransferAPI v1"));
            }

            app.UseRouting();

            app.UseCors("allow");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
