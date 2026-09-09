using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Infra
{
    public static class ServicesExtensionRepository
    {
        public static void ConfigurarRepositorio(this IServiceCollection services,
                                                IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

            GeradorDeServicos.ServiceProvider = services.BuildServiceProvider();
        }
    }

}
