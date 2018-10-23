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
        public string ponto;
        public string destino;
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
            ponto = pessoa_ponto.Text;
            if (ponto == destino && ponto != null)
            {
                linha_onibus.Enabled = false;
            }

            else if (ponto != destino)
            {
                linha_onibus.Enabled = true;
                linha_onibus.Text = (destino);
            }

        }
        #endregion

        #region Verificações ao iniciar a simulação
        private void comecar_btn_Click(object sender, EventArgs e)
        {
            #region Adicionar local
            if (ponto == "Ubatuba")
            {
                progresso_onibus.Value = 0;
            }

            else if (ponto == "Caraguatatuba")
            {
                progresso_onibus.Value = 50;
            }

            else if (ponto == "São Sebastião")
            {
                progresso_onibus.Value = 100;
            }

            else
            {
                erro();
            }
            #endregion

            #region Validar ponto
            if (ponto == destino)
            {
                erroMesmoLugar();
            }
            #endregion

            #region Começar timer
            if  (ponto == "Ubatuba" && destino == "Caraguatatuba")
            {
                while (progresso_onibus.Value < 50)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (ponto == "Caraguatatuba" && destino == "São Sebastião")
            {
                while (progresso_onibus.Value < 100)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (ponto == "São Sebastião" && destino == "Caraguatatuba")
            {
                while (progresso_onibus.Value > 50)
                {
                    timer1.Enabled = true;
                }
                timer1.Enabled = false;
            }
            else if (ponto == "Caraguatatuba" && destino == "Ubatuba")
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
            if (destino == "Caraguatatuba" && ponto == "São Sebastião" || destino == "Ubatuba" && ponto == "Caraguatatuba")
            {
                progresso_onibus.Value -= 10;
            }
            else
            {
                progresso_onibus.Value += 10;
            }
        }

        private void pessoa_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            destino = pessoa_destino.Text;
        }
    }
}
