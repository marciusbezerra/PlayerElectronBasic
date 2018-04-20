using ElectronNET.API;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PlayerElectronBasic
{
    public class Program
    {
        /*
         * PARA TESTAR:
         * 
         * 1. É necessário adicionar as seguintes tags ao arquivo de projeto .csproj:
         * 
         * <ItemGroup>
         *   <DotNetCliToolReference Include="ElectronNET.CLI" Version="*" />
         * </ItemGroup>
         * 
         * 2. Abrir um prompt no pasta onde se encontra o projeto (csproj) e digitar os seguintes comandos:
         * 
         * dotnet electronize init
         * dotnet electronize start
         * 
         */

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseElectron(args)
                .UseStartup<Startup>()
                .Build();
    }
}
