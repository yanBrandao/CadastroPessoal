namespace CadastroPessoal
{
    partial class TelaInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grauDeInstruçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpAbasPrograma = new System.Windows.Forms.TabControl();
            this.abaPessoa = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdicionarPessoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPessoas = new System.Windows.Forms.DataGridView();
            this.cmsMenuCelula = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tbpAbasPrograma.SuspendLayout();
            this.abaPessoa.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).BeginInit();
            this.cmsMenuCelula.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 62);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(122, 54);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.grauDeInstruçãoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(181, 54);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.pessoaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(419, 54);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // grauDeInstruçãoToolStripMenuItem
            // 
            this.grauDeInstruçãoToolStripMenuItem.Name = "grauDeInstruçãoToolStripMenuItem";
            this.grauDeInstruçãoToolStripMenuItem.Size = new System.Drawing.Size(419, 54);
            this.grauDeInstruçãoToolStripMenuItem.Text = "Grau de Instrução";
            this.grauDeInstruçãoToolStripMenuItem.Click += new System.EventHandler(this.grauDeInstruçãoToolStripMenuItem_Click);
            // 
            // tbpAbasPrograma
            // 
            this.tbpAbasPrograma.Controls.Add(this.abaPessoa);
            this.tbpAbasPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpAbasPrograma.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAbasPrograma.Location = new System.Drawing.Point(0, 62);
            this.tbpAbasPrograma.Margin = new System.Windows.Forms.Padding(6);
            this.tbpAbasPrograma.Name = "tbpAbasPrograma";
            this.tbpAbasPrograma.SelectedIndex = 0;
            this.tbpAbasPrograma.Size = new System.Drawing.Size(1600, 803);
            this.tbpAbasPrograma.TabIndex = 1;
            this.tbpAbasPrograma.Visible = false;
            // 
            // abaPessoa
            // 
            this.abaPessoa.Controls.Add(this.panel4);
            this.abaPessoa.Location = new System.Drawing.Point(8, 64);
            this.abaPessoa.Margin = new System.Windows.Forms.Padding(6);
            this.abaPessoa.Name = "abaPessoa";
            this.abaPessoa.Padding = new System.Windows.Forms.Padding(6);
            this.abaPessoa.Size = new System.Drawing.Size(1584, 731);
            this.abaPessoa.TabIndex = 0;
            this.abaPessoa.Text = "Pessoa";
            this.abaPessoa.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1572, 719);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1572, 137);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExportar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1336, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 137);
            this.panel5.TabIndex = 3;
            // 
            // btnExportar
            // 
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportar.Location = new System.Drawing.Point(0, 0);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(236, 137);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdicionarPessoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 137);
            this.panel3.TabIndex = 1;
            // 
            // btnAdicionarPessoa
            // 
            this.btnAdicionarPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarPessoa.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionarPessoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdicionarPessoa.Name = "btnAdicionarPessoa";
            this.btnAdicionarPessoa.Size = new System.Drawing.Size(214, 137);
            this.btnAdicionarPessoa.TabIndex = 0;
            this.btnAdicionarPessoa.Text = "Inserir";
            this.btnAdicionarPessoa.UseVisualStyleBackColor = true;
            this.btnAdicionarPessoa.Click += new System.EventHandler(this.btnAdicionarPessoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridPessoas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 719);
            this.panel1.TabIndex = 1;
            // 
            // gridPessoas
            // 
            this.gridPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPessoas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPessoas.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPessoas.Location = new System.Drawing.Point(0, 0);
            this.gridPessoas.Margin = new System.Windows.Forms.Padding(6);
            this.gridPessoas.Name = "gridPessoas";
            this.gridPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPessoas.Size = new System.Drawing.Size(1572, 719);
            this.gridPessoas.TabIndex = 0;
            this.gridPessoas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPessoas_CellMouseClick);
            this.gridPessoas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridPessoas_MouseDown);
            // 
            // cmsMenuCelula
            // 
            this.cmsMenuCelula.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsMenuCelula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.cmsMenuCelula.Name = "cmsMenuCelula";
            this.cmsMenuCelula.Size = new System.Drawing.Size(185, 76);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(214, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 137);
            this.button1.TabIndex = 4;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tbpAbasPrograma);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.TelaInicio_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaInicio_FormClosing);
            this.Load += new System.EventHandler(this.TelaInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbpAbasPrograma.ResumeLayout(false);
            this.abaPessoa.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoas)).EndInit();
            this.cmsMenuCelula.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.TabControl tbpAbasPrograma;
        private System.Windows.Forms.TabPage abaPessoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridPessoas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionarPessoa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip cmsMenuCelula;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grauDeInstruçãoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

