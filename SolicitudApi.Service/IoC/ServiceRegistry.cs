using Microsoft.Extensions.DependencyInjection;
using SolicitudApi.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Service.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ISolicitudeService, SolicitudeService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IFileService, FileService>();
        }
    }
}
