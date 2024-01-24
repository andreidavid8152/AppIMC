using AppIMC.Services;

namespace AppIMC
{
    public partial class App : Application
    {

        public static PersonaRepository PersonaRepo { get; private set; }

        public App()
        {
            InitializeComponent();

            PersonaRepo = new PersonaRepository();

            MainPage = new AppShell();
        }
    }
}
