using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacao
{
    public partial class simulacao : Form
    {
        static void erro()
        {
            MessageBox.Show("Ocorreu um erro");
        }
        static void erroMesmoLugar()
        {
            MessageBox.Show("Você ja está no seu destino");
        }
        static void destinoChegado()
        {
            MessageBox.Show("Você chegou ao seu destino!");
        }
        public simulacao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region Destino e local iguais
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pessoa_ponto.SelectedItem == pessoa_destino.SelectedItem)
            {
                linha_onibus.Enabled = false;
            }

            else if (pessoa_ponto.SelectedItem != pessoa_destino.SelectedItem)
            {
                linha_onibus.Enabled = true;
            }

            else
            {
                linha_onibus.Text = (pessoa_destino.SelectedText);
            }

        }
        #endregion

        #region Verificações ao iniciar a simulação
        private void comecar_btn_Click(object sender, EventArgs e)
        {
            #region Adicionar local
            if (pessoa_ponto.SelectedText == "Ubatuba")
            {
                progresso_onibus.Value = 0;
            }

            else if (pessoa_ponto.SelectedText == "Caraguatatuba")
            {
                progresso_onibus.Value = 50;
            }

            else if (pessoa_ponto.SelectedText == "São Sebastião")
            {
                progresso_onibus.Value = 100;
            }

            else
            {
                erro();
            }
            #endregion

            #region Validar ponto
            if (pessoa_ponto.SelectedText == pessoa_destino.SelectedText)
            {
                erroMesmoLugar();
            }
            #endregion

            #region Começar timer
            if  (pessoa_ponto.SelectedText == "Ubatuba" && pessoa_destino.SelectedText == "Caraguatatuba")
            {
                while (progresso_onibus.Value < 50)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (pessoa_ponto.SelectedText == "Caraguatatuba" && pessoa_destino.SelectedText == "São Sebastião")
            {
                while (progresso_onibus.Value < 100)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (pessoa_ponto.SelectedText == "São Sebastião" && pessoa_destino.SelectedText == "Caraguatatuba")
            {
                while (progresso_onibus.Value > 50)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (pessoa_ponto.SelectedText == "Caraguatatuba" && pessoa_destino.SelectedText == "Ubatuba")
            {
                while (progresso_onibus.Value > 50)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            #endregion
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pessoa_destino.SelectedText == "Caraguatatuba" && pessoa_ponto.SelectedText == "São Sebastião" || pessoa_destino.SelectedText == "Ubatuba" && pessoa_ponto.SelectedText == "Caraguatatuba")
            {
                progresso_onibus.Value -= 10;
            }
            else
            {
                progresso_onibus.Value += 10;
            }
        }
    }
}
