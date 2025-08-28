using SatellitesQL.LocalDefinedSatellites;
using SatellitesQL.Response;
using SatellitesQL.Response.Types.Abstract;
using SatellitesQL.Schema;
using SatellitesQL.Schema.Mutations;
using SatellitesQL.Serfvice;
using static SatellitesQL.Serfvice.SatelliteCategories;

namespace SatellitesQL
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<N2YOService>();
            services.AddSingleton<N2YOService>();

            services.AddGraphQLServer()
                    .AddQueryType<Query>()
                    .AddMutationType<SatelliteMutation>()
                    .AddType<SatelliteCategoryType>()
                    .AddType<ObjectType<JsonType>>()
                    .AddType<ObjectType<JsonValue>>();

        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseWebSockets();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
