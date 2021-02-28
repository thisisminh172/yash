using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
using yash.Application.Catalog.Carts;
using yash.Application.Catalog.Categories;
using yash.Application.Catalog.Certifications;
using yash.Application.Catalog.Diamonds;
using yash.Application.Catalog.Golds;
using yash.Application.Catalog.Items;
using yash.Application.Catalog.ProductTypes;
using yash.Application.Catalog.RingSizes;
using yash.Application.Users;
using yash.Data.EF;
using yash.Utilities.Constants;

namespace yash.WebApi
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
            //cach 1 ket noi database>>>>>>>>>>>>>>>
            //services.AddDbContext<YashDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("YashDb")));

            //cach 2 ket noi database>>>>>>>>>>>>>>
            services.AddDbContext<YashDbContext>(options => options.UseSqlServer(SystemConstants.ConnectionString));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Yash", Version = "v1" });
            });
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICertificationService, CertificationService>();
            services.AddTransient<IDiamondService, DiamondService>();
            services.AddTransient<IGoldService, GoldService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.AddTransient<IRingSizeService, RingSizeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IItemService, ItemService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Yash V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
