using System.Collections.Generic;
using System.Windows.Controls;

namespace Book.Views
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class StartPage : ContentControl
    {
        public StartPage()
        {
            InitializeComponent();
            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
        }


        internal class ConsumoViewModel
        {
            public List<Consumo> Consumo { get; private set; }

            public ConsumoViewModel(Consumo consumo)
            {
                Consumo = new List<Consumo>();
                Consumo.Add(consumo);
            }
        }

        internal class Consumo
        {
            public string Titulo { get; private set; }
            public int Porcentagem { get; private set; }

            public Consumo()
            {
                Titulo = "жүктелді";
                Porcentagem = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                return 100; //Calculo da porcentagem de consumo
            }
        }

    }
}
