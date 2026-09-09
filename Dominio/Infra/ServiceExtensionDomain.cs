using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Infra
{
    public static class ServiceExtensionDomain
    {
        public static void ConfigurarDominio(this IServiceCollection services,
                                                IConfiguration configuration)
        {
            ServicesExtensionRepository.ConfigurarRepositorio(services, configuration);
        }
    }
}
