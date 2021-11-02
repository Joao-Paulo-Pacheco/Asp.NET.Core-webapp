using Microsoft.AspNetCore.Hosting;

namespace Alura.ListaLeitura.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();

        }

    }
}
