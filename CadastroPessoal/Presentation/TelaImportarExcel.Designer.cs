namespace CadastroPessoal.Presentation
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.dgImportar.Name = "dgImportar";
            this.dgImportar.RowTemplate.Height = 33;
            this.dgImportar.Size = new System.Drawing.Size(1272, 631);
            this.dgImportar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgImportar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 635);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Salvar);
            this.panel2.Controls.Add(this.btnImportar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 105);
            this.panel2.TabIndex = 2;
            // 
            // btnImportar
            // 
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportar.Location = new System.Drawing.Point(0, 0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(117, 105);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Salvar
            // 
            this.Salvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salvar.Location = new System.Drawing.Point(1190, 0);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(110, 105);
            this.Salvar.TabIndex = 1;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 758);
            this.panel3.TabIndex = 3;
            // 
            // TelaImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 758);
            this.Controls.Add(this.panel3);
            this.Name = "TelaImportarExcel";
            this.Text = "TelaImportarExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgImportar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
    }
}