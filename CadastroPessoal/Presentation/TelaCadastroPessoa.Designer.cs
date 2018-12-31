namespace CadastroPessoal
{
    partial class TelaCadastroPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbCertificacoes = new System.Windows.Forms.ComboBox();
            this.lbGrau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(373, 182);
            this.tbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(396, 57);
            this.tbNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(230, 185);
            this.lbNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(131, 50);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(125, 283);
            this.lbNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(236, 50);
            this.lbNascimento.TabIndex = 3;
            this.lbNascimento.Text = "Nascimento: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(348, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Location = new System.Drawing.Point(373, 278);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(396, 57);
            this.dtpNascimento.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(329, 477);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 90);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbCertificacoes
            // 
            this.cbCertificacoes.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCertificacoes.FormattingEnabled = true;
            this.cbCertificacoes.Location = new System.Drawing.Point(373, 382);
            this.cbCertificacoes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCertificacoes.Name = "cbCertificacoes";
            this.cbCertificacoes.Size = new System.Drawing.Size(396, 58);
            this.cbCertificacoes.TabIndex = 7;
            // 
            // lbGrau
            // 
            this.lbGrau.AutoSize = true;
            this.lbGrau.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrau.Location = new System.Drawing.Point(30, 385);
            this.lbGrau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGrau.Name = "lbGrau";
            this.lbGrau.Size = new System.Drawing.Size(331, 50);
            this.lbGrau.TabIndex = 8;
            this.lbGrau.Text = "Grau de Instrução: ";
            // 
            // TelaCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 594);
            this.Controls.Add(this.lbGrau);
            this.Controls.Add(this.cbCertificacoes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroPessoa";
            this.Load += new System.EventHandler(this.TelaCadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbCertificacoes;
        private System.Windows.Forms.Label lbGrau;
    }
}