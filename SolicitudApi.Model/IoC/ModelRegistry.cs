using Microsoft.Extensions.DependencyInjection;
using SolicitudApi.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ISolicitudeRepository, SolicitudeRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
