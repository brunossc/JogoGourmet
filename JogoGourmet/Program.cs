using JogoGourmet.Core;
using JogoGourmet.Core.Repositories;
using JogoGourmet.Infra.Data;
using JogoGourmet.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Startup());
        }

        private static Form Startup()
        {
            var builder = new HostBuilder()
          .ConfigureServices((hostContext, services) =>
          {
              services.AddSingleton<QuestionForm>();
              services.AddScoped<IGrupoRepository, GrupoRepository>();
              services.AddScoped<IPratoRepository, PratoRepository>();
              services.AddScoped<IGourmetService, GourmetService>();
              services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("GourmetDb"));
          });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var localForm = services.GetRequiredService<QuestionForm>();
                localForm.Size = new System.Drawing.Size(350, 130);
                return localForm;
            }
        }
    }
}
