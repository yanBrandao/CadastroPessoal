﻿namespace CadastroPessoal
{
    partial class TelaCadastroInstrução
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
            this.lbInstrução = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(220, 146);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(170, 32);
            this.tbNome.TabIndex = 0;
            // 
            // lbInstrução
            // 
            this.lbInstrução.AutoSize = true;
            this.lbInstrução.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrução.Location = new System.Drawing.Point(38, 148);
            this.lbInstrução.Name = "lbInstrução";
            this.lbInstrução.Size = new System.Drawing.Size(171, 25);
            this.lbInstrução.TabIndex = 1;
            this.lbInstrução.Text = "Grau de Instrução: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(168, 242);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 47);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(179, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 63);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCadastroInstrução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 297);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbInstrução);
            this.Controls.Add(this.tbNome);
            this.Name = "TelaCadastroInstrução";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroInstrução";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbInstrução;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}