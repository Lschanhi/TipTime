namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        private double valorTemp;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ValorCompra_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(ValorCompra.Text, out double valor))
            {
                valorTemp = valor;
            }
            else
            {
                valorTemp = 0;
            }



        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
            double total = valorTemp * 0.15;
            double soma = valorTemp + total;
            valorGorjetaLabel.Text = $"Valor da gorjeta: R$ {total:F2}";
            valorTotalLabel.Text = $"Valor da gorjeta: R$ {soma:F2}";

        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
            double total = valorTemp * 0.20;
            double soma = valorTemp + total;
            valorGorjetaLabel.Text = $"Valor da gorjeta: R$ {total:F2}";
            valorTotalLabel.Text = $"Valor Total da Comanda: R$ {soma:F2}";
        }

        private void ArredondarCimaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ArredondarBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valor = PorcentagemSlider.Value;
            double total = valorTemp * (valor / 100);
            double soma = valorTemp + total;
            valorGorjetaLabel.Text = $"Valor Total da Comanda: R$ {total:F2}";
            valorTotalLabel.Text = $"Valor Total da Comanda: R$ {soma:F2}";
            valorSliderlabel.Text = $"{valor:F2}%";
        }

     
    }

}
