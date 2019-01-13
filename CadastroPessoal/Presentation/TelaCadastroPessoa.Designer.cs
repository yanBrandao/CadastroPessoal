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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbGrau = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.lvCertificatesAdded = new System.Windows.Forms.ListView();
            this.cbCertificates = new System.Windows.Forms.ComboBox();
            this.lbSeg = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.pnBackground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(109, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 32);
            this.tbName.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(36, 91);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(67, 25);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(328, 91);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(48, 25);
            this.lbNascimento.TabIndex = 3;
            this.lbNascimento.Text = "CPF:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(567, 416);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 41);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbGrau
            // 
            this.lbGrau.AutoSize = true;
            this.lbGrau.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrau.Location = new System.Drawing.Point(36, 142);
            this.lbGrau.Name = "lbGrau";
            this.lbGrau.Size = new System.Drawing.Size(115, 25);
            this.lbGrau.TabIndex = 8;
            this.lbGrau.Text = "RG ou CTPS:";
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(382, 88);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(195, 32);
            this.tbCPF.TabIndex = 9;
            // 
            // tbRG
            // 
            this.tbRG.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRG.Location = new System.Drawing.Point(157, 139);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(200, 32);
            this.tbRG.TabIndex = 10;
            // 
            // lvCertificatesAdded
            // 
            this.lvCertificatesAdded.Location = new System.Drawing.Point(41, 245);
            this.lvCertificatesAdded.Name = "lvCertificatesAdded";
            this.lvCertificatesAdded.Size = new System.Drawing.Size(604, 161);
            this.lvCertificatesAdded.TabIndex = 11;
            this.lvCertificatesAdded.UseCompatibleStateImageBehavior = false;
            this.lvCertificatesAdded.View = System.Windows.Forms.View.List;
            // 
            // cbCertificates
            // 
            this.cbCertificates.DropDownWidth = 200;
            this.cbCertificates.Font = new System.Drawing.Font("Segoe UI", 13.875F);
            this.cbCertificates.FormattingEnabled = true;
            this.cbCertificates.Location = new System.Drawing.Point(272, 196);
            this.cbCertificates.Name = "cbCertificates";
            this.cbCertificates.Size = new System.Drawing.Size(131, 33);
            this.cbCertificates.TabIndex = 13;
            // 
            // lbSeg
            // 
            this.lbSeg.AutoSize = true;
            this.lbSeg.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeg.Location = new System.Drawing.Point(36, 200);
            this.lbSeg.Name = "lbSeg";
            this.lbSeg.Size = new System.Drawing.Size(236, 25);
            this.lbSeg.TabIndex = 14;
            this.lbSeg.Text = "Certificados de Segurança:";
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = global::CadastroPessoal.Properties.Resources.add_icon;
            this.pbAdd.Location = new System.Drawing.Point(615, 197);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(30, 30);
            this.pbAdd.TabIndex = 15;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbSair
            // 
            this.pbSair.BackgroundImage = global::CadastroPessoal.Properties.Resources.close_icon;
            this.pbSair.Location = new System.Drawing.Point(3, 3);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(20, 20);
            this.pbSair.TabIndex = 12;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CadastroPessoal.Properties.Resources._27825;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtExpirationDate
            // 
            this.dtExpirationDate.Font = new System.Drawing.Font("Segoe UI", 13.875F);
            this.dtExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpirationDate.Location = new System.Drawing.Point(410, 196);
            this.dtExpirationDate.Name = "dtExpirationDate";
            this.dtExpirationDate.Size = new System.Drawing.Size(200, 32);
            this.dtExpirationDate.TabIndex = 16;
            // 
            // pnBackground
            // 
            this.pnBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBackground.Controls.Add(this.pbSair);
            this.pnBackground.Controls.Add(this.dtExpirationDate);
            this.pnBackground.Controls.Add(this.pictureBox1);
            this.pnBackground.Controls.Add(this.pbAdd);
            this.pnBackground.Controls.Add(this.tbName);
            this.pnBackground.Controls.Add(this.lbSeg);
            this.pnBackground.Controls.Add(this.lbNome);
            this.pnBackground.Controls.Add(this.cbCertificates);
            this.pnBackground.Controls.Add(this.lbNascimento);
            this.pnBackground.Controls.Add(this.lvCertificatesAdded);
            this.pnBackground.Controls.Add(this.btnSalvar);
            this.pnBackground.Controls.Add(this.tbRG);
            this.pnBackground.Controls.Add(this.lbGrau);
            this.pnBackground.Controls.Add(this.tbCPF);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(668, 474);
            this.pnBackground.TabIndex = 17;
            // 
            // TelaCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 474);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroPessoa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaCadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbGrau;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.ListView lvCertificatesAdded;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.ComboBox cbCertificates;
        private System.Windows.Forms.Label lbSeg;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DateTimePicker dtExpirationDate;
        private System.Windows.Forms.Panel pnBackground;
    }
}