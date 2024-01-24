using AppIMC.Models;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {

            var peso = double.Parse(entryPeso.Text);
            var altura = double.Parse(entryAltura.Text);
            var imc = peso / (altura * altura);

            //Resultado
            entryIMC.Text = imc.ToString("0.00");

            var persona = new Persona
            {
                Peso = peso,
                Altura = altura,
                IMC = imc
            };

            await App.PersonaRepo.AgregarPersona(persona);
        }

        private async void OnVerDatosClicked(object sender, EventArgs e)
        {

            var personas = await App.PersonaRepo.ObtenerPersonas();
            foreach (var persona in personas)
            {
                Console.WriteLine($"ID: {persona.Id}, Peso: {persona.Peso}, Altura: {persona.Altura}, IMC: {persona.IMC}");
            }

        }

    }

}
