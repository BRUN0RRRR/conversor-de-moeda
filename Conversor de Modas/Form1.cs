namespace Conversor_de_Modas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reinicia o campo de saída para calcular de novo
            saida.Text = "";

            float real = 1f;
            float dolar = 5.25f;
            float euro = 6.24f;

            if (double.TryParse(entrada.Text, out double numero))
            {
                if (ent_real.Checked == true && sai_euro.Checked == true)
                {
                    float resultado = ((float)numero / euro);
                    saida.Text = resultado.ToString();
                }
                else if (ent_real.Checked == true && sai_dolar.Checked == true)
                {
                    float resultado = ((float)numero / dolar);
                    saida.Text = resultado.ToString();
                }
                else if (ent_euro.Checked == true && sai_real.Checked == true)
                {
                    float resultado = ((float)numero * euro);
                    saida.Text = resultado.ToString();
                }
                else if (ent_euro.Checked == true && sai_dolar.Checked == true)
                {
                    float resultado = ((float)numero * (dolar / euro));
                    saida.Text = resultado.ToString();
                }
                else if (ent_dolar.Checked == true && sai_real.Checked == true)
                {
                    float resultado = ((float)numero * dolar);
                    saida.Text = resultado.ToString();
                }
                else if (ent_dolar.Checked == true && sai_euro.Checked == true)
                {
                    float resultado = ((float)numero * (euro / dolar));
                    saida.Text = resultado.ToString();
                }
                else
                {
                    saida.Text = numero.ToString();
                }
            }
            
        }


        private void entrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            saida.Text = " ";
            entrada.Text = " ";
        }
    }
}
