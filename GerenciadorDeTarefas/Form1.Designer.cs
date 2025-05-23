namespace GerenciadorDeTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeTarefa = new System.Windows.Forms.Label();
            this.txbNomeTarefa = new System.Windows.Forms.TextBox();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.lblNomeResponsavel = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblDataLimite = new System.Windows.Forms.Label();
            this.dtpDataLmt = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.grbTarefas = new System.Windows.Forms.GroupBox();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.pibApagar = new System.Windows.Forms.PictureBox();
            this.grbAdicionar.SuspendLayout();
            this.grbTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Schadow BT", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(314, 71);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(366, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciador De Tarefas";
            // 
            // lblNomeTarefa
            // 
            this.lblNomeTarefa.AutoSize = true;
            this.lblNomeTarefa.Font = new System.Drawing.Font("Schadow BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTarefa.Location = new System.Drawing.Point(9, 37);
            this.lblNomeTarefa.Name = "lblNomeTarefa";
            this.lblNomeTarefa.Size = new System.Drawing.Size(109, 17);
            this.lblNomeTarefa.TabIndex = 2;
            this.lblNomeTarefa.Text = "Nome Da Tarefa:";
            // 
            // txbNomeTarefa
            // 
            this.txbNomeTarefa.Location = new System.Drawing.Point(169, 36);
            this.txbNomeTarefa.Multiline = true;
            this.txbNomeTarefa.Name = "txbNomeTarefa";
            this.txbNomeTarefa.Size = new System.Drawing.Size(227, 29);
            this.txbNomeTarefa.TabIndex = 3;
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Location = new System.Drawing.Point(169, 76);
            this.txbResponsavel.Multiline = true;
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(227, 29);
            this.txbResponsavel.TabIndex = 5;
            // 
            // lblNomeResponsavel
            // 
            this.lblNomeResponsavel.AutoSize = true;
            this.lblNomeResponsavel.Font = new System.Drawing.Font("Schadow BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResponsavel.Location = new System.Drawing.Point(9, 77);
            this.lblNomeResponsavel.Name = "lblNomeResponsavel";
            this.lblNomeResponsavel.Size = new System.Drawing.Size(148, 17);
            this.lblNomeResponsavel.TabIndex = 4;
            this.lblNomeResponsavel.Text = "Nome Do Responsavel:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Schadow BT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(73, 124);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(56, 21);
            this.lblSetor.TabIndex = 6;
            this.lblSetor.Text = "Setor:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(169, 123);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(227, 27);
            this.cmbSetor.TabIndex = 8;
            // 
            // lblDataLimite
            // 
            this.lblDataLimite.AutoSize = true;
            this.lblDataLimite.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLimite.Location = new System.Drawing.Point(37, 167);
            this.lblDataLimite.Name = "lblDataLimite";
            this.lblDataLimite.Size = new System.Drawing.Size(92, 19);
            this.lblDataLimite.TabIndex = 9;
            this.lblDataLimite.Text = "Data Limite:";
            // 
            // dtpDataLmt
            // 
            this.dtpDataLmt.Location = new System.Drawing.Point(169, 166);
            this.dtpDataLmt.Name = "dtpDataLmt";
            this.dtpDataLmt.Size = new System.Drawing.Size(227, 27);
            this.dtpDataLmt.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(32, 224);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(364, 38);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.lblNomeTarefa);
            this.grbAdicionar.Controls.Add(this.btnAdicionar);
            this.grbAdicionar.Controls.Add(this.txbNomeTarefa);
            this.grbAdicionar.Controls.Add(this.dtpDataLmt);
            this.grbAdicionar.Controls.Add(this.lblNomeResponsavel);
            this.grbAdicionar.Controls.Add(this.lblDataLimite);
            this.grbAdicionar.Controls.Add(this.txbResponsavel);
            this.grbAdicionar.Controls.Add(this.cmbSetor);
            this.grbAdicionar.Controls.Add(this.lblSetor);
            this.grbAdicionar.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdicionar.Location = new System.Drawing.Point(3, 143);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(422, 353);
            this.grbAdicionar.TabIndex = 12;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar";
            // 
            // grbTarefas
            // 
            this.grbTarefas.Controls.Add(this.dgvTarefas);
            this.grbTarefas.Font = new System.Drawing.Font("Schadow BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTarefas.Location = new System.Drawing.Point(459, 143);
            this.grbTarefas.Name = "grbTarefas";
            this.grbTarefas.Size = new System.Drawing.Size(511, 422);
            this.grbTarefas.TabIndex = 13;
            this.grbTarefas.TabStop = false;
            this.grbTarefas.Text = "Tarefas";
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(-8, 15);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(513, 338);
            this.dgvTarefas.TabIndex = 0;
            this.dgvTarefas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellDoubleClick);
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::GerenciadorDeTarefas.Properties.Resources.task;
            this.pibLogo.Location = new System.Drawing.Point(172, 55);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(136, 82);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // pibApagar
            // 
            this.pibApagar.Image = global::GerenciadorDeTarefas.Properties.Resources.delete;
            this.pibApagar.Location = new System.Drawing.Point(871, 502);
            this.pibApagar.Name = "pibApagar";
            this.pibApagar.Size = new System.Drawing.Size(84, 63);
            this.pibApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibApagar.TabIndex = 14;
            this.pibApagar.TabStop = false;
            this.pibApagar.Click += new System.EventHandler(this.pibApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 635);
            this.Controls.Add(this.pibApagar);
            this.Controls.Add(this.grbTarefas);
            this.Controls.Add(this.grbAdicionar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Schadow BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciador De Tarefas";
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            this.grbTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeTarefa;
        private System.Windows.Forms.TextBox txbNomeTarefa;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.Label lblNomeResponsavel;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label lblDataLimite;
        private System.Windows.Forms.DateTimePicker dtpDataLmt;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.GroupBox grbTarefas;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.PictureBox pibApagar;
    }
}

