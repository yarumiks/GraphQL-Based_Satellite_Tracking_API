using SatellitesQL.Schema;
using SatellitesQL.Serfvice;

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
                    .AddType<TLEQuery>();


        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            //use for Subscriptions
            app.UseWebSockets();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
