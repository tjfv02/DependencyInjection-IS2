using InyeccionDependencia_IS2.Clases;
using InyeccionDependencia_IS2.Interfaces;
using InyeccionDependencia_IS2.Interfaces.InterfacesDI;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InyeccionDependencia_IS2
{
    internal class Program
    {
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddSingleton<IExampleSingletonService,CiudadGuatemala>();
            services.AddScoped<IExampleScopedService,CiudadGuatemala>();
            services.AddTransient<IExampleTransientService,CiudadGuatemala>();

            services.AddSingleton<IExampleSingletonService, DepartamentoBomberos>();
            services.AddScoped<IExampleScopedService, DepartamentoBomberos>();
            services.AddTransient<IExampleTransientService, DepartamentoBomberos>();

            services.AddSingleton<IExampleSingletonService, DepartamentoPolicias>();
            services.AddScoped<IExampleScopedService, DepartamentoPolicias>();
            services.AddTransient<IExampleTransientService, DepartamentoPolicias>();

            services.AddSingleton<IExampleSingletonService, Bombero>();
            services.AddScoped<IExampleScopedService, Bombero>();
            services.AddTransient<IExampleTransientService, Bombero>();

            services.AddSingleton<IExampleSingletonService, Policia>();
            services.AddScoped<IExampleScopedService, Policia>();
            services.AddTransient<IExampleTransientService, Policia>();
        }

        private readonly IExampleSingletonService _singleton ;
        private readonly IExampleScopedService _scoped ;
        private readonly IExampleTransientService _transient;

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            Servicios();
            Console.ReadLine();
        }

        static void Servicios()
        {

        }
    }
}
