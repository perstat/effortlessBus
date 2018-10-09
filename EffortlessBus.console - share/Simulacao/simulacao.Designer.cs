namespace Simulacao
{
    partial class simulacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progresso_onibus = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pessoa_ponto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pessoa_destino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linha_onibus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comecar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progresso_onibus
            // 
            this.progresso_onibus.Location = new System.Drawing.Point(42, 413);
            this.progresso_onibus.Name = "progresso_onibus";
            this.progresso_onibus.Size = new System.Drawing.Size(724, 32);
            this.progresso_onibus.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubatuba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caraguatatuba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "São Sebastião";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Está:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pessoa_ponto
            // 
            this.pessoa_ponto.FormattingEnabled = true;
            this.pessoa_ponto.Items.AddRange(new object[] {
            "Ubatuba",
            "Caraguatatuba",
            "São Sebastião"});
            this.pessoa_ponto.Location = new System.Drawing.Point(21, 60);
            this.pessoa_ponto.Name = "pessoa_ponto";
            this.pessoa_ponto.Size = new System.Drawing.Size(697, 21);
            this.pessoa_ponto.TabIndex = 6;
            this.pessoa_ponto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pessoa_destino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pessoa_ponto);
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Pessoa ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pessoa_destino
            // 
            this.pessoa_destino.FormattingEnabled = true;
            this.pessoa_destino.Items.AddRange(new object[] {
            "Ubatuba",
            "Caraguatatuba",
            "São Sebastião"});
            this.pessoa_destino.Location = new System.Drawing.Point(21, 129);
            this.pessoa_destino.Name = "pessoa_destino";
            this.pessoa_destino.Size = new System.Drawing.Size(697, 21);
            this.pessoa_destino.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quer ir para:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linha_onibus);
            this.groupBox2.Location = new System.Drawing.Point(44, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 83);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Onibus ";
            // 
            // linha_onibus
            // 
            this.linha_onibus.AutoSize = true;
            this.linha_onibus.Location = new System.Drawing.Point(304, 41);
            this.linha_onibus.Name = "linha_onibus";
            this.linha_onibus.Size = new System.Drawing.Size(134, 13);
            this.linha_onibus.TabIndex = 10;
            this.linha_onibus.Text = "Aguardando informações...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // comecar_btn
            // 
            this.comecar_btn.Location = new System.Drawing.Point(44, 323);
            this.comecar_btn.Name = "comecar_btn";
            this.comecar_btn.Size = new System.Drawing.Size(724, 38);
            this.comecar_btn.TabIndex = 9;
            this.comecar_btn.Text = "Começar simulação";
            this.comecar_btn.UseVisualStyleBackColor = true;
            this.comecar_btn.Click += new System.EventHandler(this.comecar_btn_Click);
            // 
            // simulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.comecar_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progresso_onibus);
            this.Name = "simulacao";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progresso_onibus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pessoa_ponto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox pessoa_destino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button comecar_btn;
        private System.Windows.Forms.Label linha_onibus;
    }
}

