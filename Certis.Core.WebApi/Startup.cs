using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using Certis.Core.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Certis.Core.Repository.Interface;
using Certis.Core.Repository.Implementation;
using Certis.Core.Service.Interface;
using Certis.Core.Service.Impementation;

namespace Certis.Core.WebApi
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
            string connectionstring = Configuration.GetConnectionString("Certis");
            services.AddDbContext<PCSBNRContext>(options => {
                options.UseSqlServer(connectionstring);
            });

            //Repository
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IContractServiceTypeRepository, ContractServiceTypeRepository>();

            //Services
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IContractServiceTypeService, ContractServiceTypeService>();
            services.AddScoped<ISchedulerService, SchedulerService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Certis Api", Version = "v1" });

                
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Certis v1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

