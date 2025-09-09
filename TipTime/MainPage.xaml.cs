namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        private double valorTemp;     // valor da compra
        private double valorGorjeta;  // valor da gorjeta
        private double valorTotal;    // valor total (compra + gorjeta)

        public MainPage()
        {
            InitializeComponent();
            PorcentagemSlider.Value = 17;
            CalcularTotal(PorcentagemSlider.Value);
        }

        // Quando o usuário digitar o valor da compra
        private void ValorCompra_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(valorCompra.Text, out double valor))
                valorTemp = valor;
            else
                valorTemp = 0;

            CalcularTotal(PorcentagemSlider.Value);
        }

        // Quando mudar a porcentagem no slider
        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CalcularTotal(e.NewValue);
        }

        // Botões de gorjeta fixa
        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
            CalcularTotal(15);
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
            CalcularTotal(20);
        }

        // Método central que calcula gorjeta e total
        private void CalcularTotal(double porcentagem)
        {
            valorGorjeta = valorTemp * (porcentagem / 100);
            valorTotal = valorTemp + valorGorjeta;

            valorGorjetaLabel.Text = $"Valor da gorjeta: {valorGorjeta:C2}";
            valorTotalLabel.Text = $"Valor Total da Comanda: {valorTotal:C2}";
            valorSliderLabel.Text = $"{porcentagem:F2}%";
        }

        // Botões de arredondamento
        private void ArredondarCimaBtn_Clicked(object sender, EventArgs e)
        {
            double cima = Math.Ceiling(valorTotal / 5)*5;

            valorTotalLabel.Text = $"Valor Total da Comanda: {cima:C2}";
            valorSliderLabel.Text = $"{PorcentagemSlider.Value:F2}%";
        }

        private void ArredondarBaixoBtn_Clicked(object sender, EventArgs e)
        {
            double baixo = Math.Floor(valorTotal / 5) * 5;

            valorTotalLabel.Text = $"Valor Total da Comanda: {baixo:C2}";
            valorSliderLabel.Text = $"{PorcentagemSlider.Value:F2}%";
        }

    
    }

}
