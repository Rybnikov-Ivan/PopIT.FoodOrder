using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using popIT.FoodOrder.Application.Extensions;
using popIT.FoodOrder.Application.Validations;
using popIT.FoodOrder.Core.Beverages.Mappings;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Infrastructure.Data;
using popIT.FoodOrder.Infrastructure.Data.UnitOfWork;

namespace popIT.FoodOrder.Application
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
			services.AddControllers(opt =>
                    {
                        opt.Filters.Add(typeof(ValidationActionFilter));
                    })
                    .ConfigureApiBehaviorOptions(opt =>
                    {
                        opt.SuppressModelStateInvalidFilter = false;
                    })
                    .AddFluentValidation(fv =>
                    {
                        fv.RegisterValidatorsFromAssemblyContaining<BeverageAddRequestValidator>();
                    })
                    .AddNewtonsoftJson(opt =>
                    {
                        opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    });

            services.AddAutoMapper(typeof(BeverageProfile));

            services.AddRepositories();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddServices();

            services.AddDbContext<FoodOrderDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("MSSQLConnection"),
                                                    sqlOpt => sqlOpt.MigrationsAssembly(typeof(FoodOrderDbContext).Assembly.FullName)));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
