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
        static void erro_mesmolugar()
        {
            MessageBox.Show("Você ja está no seu destino");
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
            if (pessoa_ponto.ValueMember == pessoa_destino.ValueMember)
            {
                linha_onibus.Enabled = false;
            }

            else if (pessoa_ponto.ValueMember != pessoa_destino.ValueMember)
            {
                linha_onibus.Enabled = true;
            }

            else
            {
                // Em progresso
                linha_onibus.Text = ();
            }

        }
        #endregion

        #region Verificações ao iniciar a simulação
        private void comecar_btn_Click(object sender, EventArgs e)
        {
            #region Adicionar local
            if (pessoa_ponto.ValueMember == "Ubatuba")
            {
                progresso_onibus = 0 %;
            }

            else if (pessoa_ponto.ValueMember == "Caraguatatuba")
            {
                progresso_onibus = 50 %;
            }

            else if (pessoa_ponto.ValueMember == "São Sebastião")
            {
                progresso_onibus = 100 %;
            }

            else
            {
                erro()
            }
            #endregion

            #region Validar ponto
            if (pessoa_ponto.ValueMember == pessoa_destino.ValueMember)
            {
                erro_mesmolugar();
            }
            #endregion
        }
        #endregion
    }
}
