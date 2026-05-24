using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0,
                Imagem = "superluxo.jpg",
                DescricaoCompleta = "Suíte premium com hidromassagem e vista panorâmica."
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0,
                Imagem = "luxo.jpg",
                DescricaoCompleta = "Quarto sofisticado com muito conforto."
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25,
                Imagem = "single.jpg",
                DescricaoCompleta = "Ideal para viagens rápidas e econômicas."

            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5,
                Imagem = "crise.jpg",
                DescricaoCompleta = "Acomodação econômica para descansar gastando pouco."
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PaginaInicial());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}