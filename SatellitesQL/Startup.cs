using Microsoft.AspNetCore.Builder;
using SatellitesQL.LocalDefinedSatellites;
using SatellitesQL.Request;
using SatellitesQL.Response;
using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using SatellitesQL.Schema;
using SatellitesQL.Schema.Mutations;
using SatellitesQL.Schema.Subscriptions;
using SatellitesQL.Serfvice;
using System.Net.WebSockets;
using System.Text;
using static SatellitesQL.Serfvice.SatelliteCategories;
using JsonType = SatellitesQL.LocalDefinedSatellites.JsonType;

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
            //SatelliteCategories.LoadGroups("satellites.json");
            
            services.AddHttpClient<N2YOService>();
            
            services.AddSingleton<N2YOService>();
            services.AddSingleton<IObserverService, ObserverService>();
            services.AddSingleton<PositionPublisher>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });

            });

            services.AddGraphQLServer()
                .AddType<SatelliteCategoryType>()
                .AddType<InputObjectType<PositionRequest>>()
                .AddType<InputObjectType<CurrentObserver>>()
                .AddType<ObjectType<JsonType>>()
                .AddType<ObjectType<JsonValue>>()
                .AddQueryType<Query>()
                .AddTypeExtension<ObserverQuery>()
                .AddTypeExtension<SatelliteQuery>()
                .AddMutationType<Mutation>()
                .AddTypeExtension<ObserverMutation>()
                .AddTypeExtension<SatelliteMutation>()
                .AddSubscriptionType<SatelliteSubscription>()
                .AddInMemorySubscriptions()
                .InitializeOnStartup();

        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWebSockets();


            app.UseRouting();

            app.UseGraphQLAltair();

            //banana cake pop UI close
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL().WithOptions(new HotChocolate.AspNetCore.GraphQLServerOptions
                {
                    Tool = { Enable = false }
                });
            });

            //altair UI config
            app.UseGraphQLAltair("/ui/altair", new GraphQL.Server.Ui.Altair.AltairOptions
            {
                GraphQLEndPoint = "/graphql"
            });
        }
    }
}
