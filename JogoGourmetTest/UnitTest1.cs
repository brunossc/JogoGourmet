using JogoGourmet;
using JogoGourmet.Core;
using JogoGourmet.Core.Repositories;
using JogoGourmet.Infra.Data;
using JogoGourmet.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using System;
using System.Linq;

namespace JogoGourmetTest
{
    public class Tests
    {
        IGourmetService _gourmetService;
        public Tests()
        {
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<GourmetService>();
                    services.AddScoped<IGrupoRepository, GrupoRepository>();
                    services.AddScoped<IPratoRepository, PratoRepository>();
                    services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("GourmetDb"));
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                _gourmetService = services.GetRequiredService<GourmetService>();
            }
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidaGrupo()
        {
            var grupo = _gourmetService.ObterGrupo(1);
            Assert.IsTrue(grupo.Nome.ToLower() == "massa");
        }

        [Test]
        public void ValidaPrato()
        {
            var prato = _gourmetService.ObterGrupo(1).Pratos.ElementAt(0);
            Assert.IsTrue(prato.Nome.ToLower() == "lasanha");
        }
    }
}