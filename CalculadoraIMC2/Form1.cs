using System;
using System.Data;
using System.Windows.Forms;

namespace CalculadoraIMC2
{
    public partial class Form1 : Form
    {
        // Variável para saber se o último clique foi operador
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txtTela.Text;

                // Evitar erro se terminar com operador
                if (expressao.EndsWith("+") || expressao.EndsWith("-") ||
                    expressao.EndsWith("*") || expressao.EndsWith("/"))
                {
                    expressao = expressao.Substring(0, expressao.Length - 1);
                }

                var resultado = new DataTable().Compute(expressao, null);

                // Se for NaN ou infinito, mostrar mensagem personalizada
                if (resultado == DBNull.Value ||
                    resultado.ToString() == "NaN" ||
                    resultado.ToString() == "∞" ||
                    resultado.ToString() == "-∞")
                {
                    txtTela.Text = ":c";
                }
                else
                {
                    txtTela.Text = resultado.ToString();
                }
            }
            catch
            {
                txtTela.Text = ":c"; // Erro genérico
            }
        }

        private void numero_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            // Se a tela estiver "0" ou acabou de clicar operador, concatena o número
            if (txtTela.Text == "0" || operadorClicado == true)
            {
                txtTela.Text += botaoClicado.Text;
            }
            else
            {
                txtTela.Text += botaoClicado.Text;
            }

            operadorClicado = false;
        }

        private void operador_Click(object sender, EventArgs e)
        {
            if (operadorClicado == false)
            {
                Button botaoClicado = (Button)sender;
                txtTela.Text += botaoClicado.Text;

                operadorClicado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTela.Text = ""; // limpa a tela
            operadorClicado = true;
        }
    }
}
