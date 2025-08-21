using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC2
{
    public partial class Form1 : Form

    {
        // Variáveis Globais:
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // implementar depois...
        }
        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento
            Button BotaoClicado = (Button)sender;

            // Adiconar o text do botão clidado no TextBox
            txtTela.Text = BotaoClicado.Text;

            // "abaixar badeirinha
            operadorClicado = false;

        }
        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda não foi clicado:
            if (operadorClicado == false)
            {
                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox:
                txtTela.Text += botaoClicado.Text;

                // Mudar o operadorClicado para true (levantar a bandeirinha):
                operadorClicado = true;
            }




        }
    }
}














