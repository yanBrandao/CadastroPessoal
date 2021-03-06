﻿namespace CadastroPessoal.Presentation
{
    partial class TelaImportarExcel
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
            this.dgImportar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salvar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbContador = new System.Windows.Forms.Label();
            this.pbImport = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgImportar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgImportar
            // 
            this.dgImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgImportar.Location = new System.Drawing.Point(0, 0);
            this.dgImportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgImportar.Name = "dgImportar";
            this.dgImportar.RowTemplate.Height = 33;
            this.dgImportar.Size = new System.Drawing.Size(954, 505);
            this.dgImportar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgImportar);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 509);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbImport);
            this.panel2.Controls.Add(this.lbContador);
            this.panel2.Controls.Add(this.Salvar);
            this.panel2.Controls.Add(this.btnImportar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 84);
            this.panel2.TabIndex = 2;
            // 
            // Salvar
            // 
            this.Salvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salvar.Location = new System.Drawing.Point(893, 0);
            this.Salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(82, 84);
            this.Salvar.TabIndex = 1;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportar.Location = new System.Drawing.Point(0, 0);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(88, 84);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 606);
            this.panel3.TabIndex = 3;
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.Location = new System.Drawing.Point(93, 55);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(212, 20);
            this.lbContador.TabIndex = 2;
            this.lbContador.Text = "Aguardando Importação: 0/0";
            // 
            // pbImport
            // 
            this.pbImport.Location = new System.Drawing.Point(97, 13);
            this.pbImport.Name = "pbImport";
            this.pbImport.Size = new System.Drawing.Size(791, 39);
            this.pbImport.Step = 1;
            this.pbImport.TabIndex = 3;
            // 
            // TelaImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 606);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaImportarExcel";
            this.Text = "TelaImportarExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgImportar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbContador;
        private System.Windows.Forms.ProgressBar pbImport;
    }
}