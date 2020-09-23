using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.Dividir;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.MaisMenos;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.Multiplicar;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.Porcentagem;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.RaizQuadrada;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.Somar;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Calculadora.Subitrair;
using CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Extensao.MemoriaMRC;
using CalculadoraBlazorBindings.Calculadora_InterfaceDoUsuario;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using Xamarin.Forms;

namespace CalculadoraBlazorBindings
{
    public class App : Application
    {
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    services.AddSingleton<Somar>();
                    services.AddSingleton<Subitrair>();
                    services.AddSingleton<Multiplicar>();
                    services.AddSingleton<Dividir>();
                    services.AddSingleton<Porcentagem>();
                    services.AddSingleton<RaizQuadrada>();
                    services.AddSingleton<MaisMenos>();
                    services.AddSingleton<MemoriaMRC>();
                })
                .Build();

            MainPage = new ContentPage();
            host.AddComponent<TelaInicial>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
