namespace Exercicio_Array_Associado_Imagens
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDuracao = new System.Windows.Forms.NumericUpDown();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrase.Location = new System.Drawing.Point(12, 34);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(311, 20);
            this.txtFrase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraduzir.Location = new System.Drawing.Point(12, 77);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(144, 23);
            this.btnTraduzir.TabIndex = 2;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(195, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(15, 107);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(308, 221);
            this.picImagem.TabIndex = 4;
            this.picImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duração das Imagens";
            // 
            // nudDuracao
            // 
            this.nudDuracao.Location = new System.Drawing.Point(129, 348);
            this.nudDuracao.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDuracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracao.Name = "nudDuracao";
            this.nudDuracao.Size = new System.Drawing.Size(32, 20);
            this.nudDuracao.TabIndex = 6;
            this.nudDuracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracao.ValueChanged += new System.EventHandler(this.nudDuracao_ValueChanged);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "A.JPG");
            this.ImageList.Images.SetKeyName(1, "B.JPG");
            this.ImageList.Images.SetKeyName(2, "C.JPG");
            this.ImageList.Images.SetKeyName(3, "D.JPG");
            this.ImageList.Images.SetKeyName(4, "E.JPG");
            this.ImageList.Images.SetKeyName(5, "F.JPG");
            this.ImageList.Images.SetKeyName(6, "G.JPG");
            this.ImageList.Images.SetKeyName(7, "H.JPG");
            this.ImageList.Images.SetKeyName(8, "I.JPG");
            this.ImageList.Images.SetKeyName(9, "J.JPG");
            this.ImageList.Images.SetKeyName(10, "K.JPG");
            this.ImageList.Images.SetKeyName(11, "L.JPG");
            this.ImageList.Images.SetKeyName(12, "M.JPG");
            this.ImageList.Images.SetKeyName(13, "N.JPG");
            this.ImageList.Images.SetKeyName(14, "O.JPG");
            this.ImageList.Images.SetKeyName(15, "P.JPG");
            this.ImageList.Images.SetKeyName(16, "Q.JPG");
            this.ImageList.Images.SetKeyName(17, "R.JPG");
            this.ImageList.Images.SetKeyName(18, "S.JPG");
            this.ImageList.Images.SetKeyName(19, "T.JPG");
            this.ImageList.Images.SetKeyName(20, "U.JPG");
            this.ImageList.Images.SetKeyName(21, "V.JPG");
            this.ImageList.Images.SetKeyName(22, "W.JPG");
            this.ImageList.Images.SetKeyName(23, "X.JPG");
            this.ImageList.Images.SetKeyName(24, "Y.JPG");
            this.ImageList.Images.SetKeyName(25, "Z.JPG");
            // 
            // Relogio
            // 
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 383);
            this.Controls.Add(this.nudDuracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tradutor Linguegem Gestual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraduzir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDuracao;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Timer Relogio;
    }
}

