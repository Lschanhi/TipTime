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
            valorGorjetaLabel.Text = $"Valor da gorjeta:{total:C2}";
            valorTotalLabel.Text = $"Valor da gorjeta:{soma:C2}";

        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            
            PorcentagemSlider.Value = 20;
            double total = valorTemp * 0.20;
            double soma = valorTemp + total;
            valorGorjetaLabel.Text = $"Valor da gorjeta:{total:C2}";
            valorTotalLabel.Text = $"Valor Total da Comanda:{soma:C2}";
        }

        private void ArredondarCimaBtn_Clicked(object sender, EventArgs e)
        {   
            
            double arredondadoParaCima = Math.Ceiling(PorcentagemSlider.Value);
            double total = valorTemp * arredondadoParaCima;
            double soma = total + valorTemp;
            valorGorjetaLabel.Text = $"Valor da gorjeta:{total:C2}";
            valorTotalLabel.Text = $"Valor Total da Comanda:{soma:C2}";
            

        }

        private void ArredondarBaixoBtn_Clicked(object sender, EventArgs e)
        {
            
               double valor = Convert.ToDouble(valorTotalLabel.Text);
                double baixo = (valor/5)*5;
                valorTotalLabel.Text = baixo.ToString("c");

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try {

               
                double valor = PorcentagemSlider.Value;
                double total = valorTemp * (valor / 100);
                double soma = valorTemp + total;
                valorGorjetaLabel.Text = $"Valor Total da Comanda: {total:C2}";
                valorTotalLabel.Text = $"Valor Total da Comanda: {soma:C2}";
                valorSliderLabel.Text = $"{valor:F2}";
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

     
    }

}
