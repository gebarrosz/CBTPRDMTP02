/*
Nome: Luiz Felipe Gonçalves da Silva
Prontuário: CB3030539

Nome: Geovanna Barros de Assunção
Prontuário: 303271X
*/
using Microsoft.Extensions.DependencyInjection;

namespace TarefasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
