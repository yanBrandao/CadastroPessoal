namespace CadastroPessoal.Presentation
{
    partial class RegisterCompanyForm
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
            this.pbCompanyIcon = new System.Windows.Forms.PictureBox();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyIcon)).BeginInit();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCompanyIcon
            // 
            this.pbCompanyIcon.Location = new System.Drawing.Point(260, 20);
            this.pbCompanyIcon.Margin = new System.Windows.Forms.Padding(6);
            this.pbCompanyIcon.Name = "pbCompanyIcon";
            this.pbCompanyIcon.Size = new System.Drawing.Size(80, 80);
            this.pbCompanyIcon.TabIndex = 0;
            this.pbCompanyIcon.TabStop = false;
            // 
            // pnBackground
            // 
            this.pnBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBackground.Controls.Add(this.btnSave);
            this.pnBackground.Controls.Add(this.textBox1);
            this.pnBackground.Controls.Add(this.lbNome);
            this.pnBackground.Controls.Add(this.pbClose);
            this.pnBackground.Controls.Add(this.pbCompanyIcon);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(600, 346);
            this.pnBackground.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(474, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 32);
            this.textBox1.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(75, 182);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(195, 25);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome da Companhia:";
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = global::CadastroPessoal.Properties.Resources.close_icon;
            this.pbClose.Location = new System.Drawing.Point(10, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // RegisterCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 346);
            this.Controls.Add(this.pnBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 13.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "la";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyIcon)).EndInit();
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCompanyIcon;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNome;
    }
}