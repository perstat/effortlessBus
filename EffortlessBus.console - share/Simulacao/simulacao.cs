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
        static void outroOnbius()
        {

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

            #region Adicionar local
            if (ponto == "Ubatuba")
            {
                UCpb.Value = 0;
                CSpb.Value = 0;
            }

            else if (ponto == "Caraguatatuba")
            {
                UCpb.Value = 100;
                CSpb.Value = 0;
            }

            else if (ponto == "São Sebastião")
            {
                UCpb.Value = 100;
                CSpb.Value = 100;
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
        }
        #endregion

        #region Verificações ao iniciar a simulação
        private void comecar_btn_Click(object sender, EventArgs e)
        {
            if (ponto == "Ubatuba" && destino == "Caraguatatuba")
            {
                UC.Enabled = true;
            }
            else if (ponto == "Caraguatatuba" && destino == "Ubatuba")
            {
                CU.Enabled = true;
            }
            else if (ponto == "Caraguatatuba" && destino == "São Sebastião")
            {
                CS.Enabled = true;
            }
            else if (ponto == "São Sebastião" && destino == "Caraguatatuba")
            {
                SC.Enabled = true;
            }
            else if (ponto == "Ubatuba" && destino == "São Sebastião")
            {
                US.Enabled = true;
            }
            else if (ponto == "São Sebastião" && destino == "Ubatuba")
            {
                SU.Enabled = true;
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pessoa_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            destino = pessoa_destino.Text;
            if (ponto == "São Sebastião" && destino == "Ubatuba")
            {
                linha_onibus.Text = "Caraguatatuba / Ubatuba";
            }
            else if (ponto == "Ubatuba" && destino == "São Sebastião")
            {
                linha_onibus.Text = "Caraguatatuba / São Sebastião";
            }
            else
            {
                linha_onibus.Text = pessoa_destino.Text;
            }

        }

        private void simulacao_Load(object sender, EventArgs e)
        {

        }

        private void UC_Tick(object sender, EventArgs e)
        {
            UCpb.Value += 10;
            if (UCpb.Value == 100)
            {
                UC.Enabled = false;
                destinoChegado();
            }
        }

        private void CU_Tick(object sender, EventArgs e)
        {
            UCpb.Value -= 10;
            if (UCpb.Value == 0)
            {
                CU.Enabled = false;
                destinoChegado();
            }
        }

        private void CS_Tick(object sender, EventArgs e)
        {
            CSpb.Value += 10;
            if (CSpb.Value == 100)
            {
                CS.Enabled = false;
                destinoChegado();
            }

        }

        private void SC_Tick(object sender, EventArgs e)
        {
            CSpb.Value -= 10;
            if (CSpb.Value == 0)
            {
                SC.Enabled = false;
                destinoChegado();
            }

        }

        private void SU_Tick(object sender, EventArgs e)
        {
            if (CSpb.Value > 0)
            {
                CSpb.Value -= 10;
            }
            else
            {
                SU.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Para chegar ao seu destino você precisa pegar outro onibus. Você deseja fazer isso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    CU.Enabled = true;
                }

            }
        }

        private void US_Tick(object sender, EventArgs e)
        {
                
           if (UCpb.Value < 100)
           {
                UCpb.Value += 10;
           }
           else
           {
                US.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Para chegar ao seu destino você precisa pegar outro onibus. Você deseja fazer isso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                        CS.Enabled = true;  
                }

           }

        }
    }
}