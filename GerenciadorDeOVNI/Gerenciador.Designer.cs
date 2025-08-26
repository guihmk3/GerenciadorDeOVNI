namespace GerenciadorDeOVNI
{
    partial class Gerenciador
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
            this.grbinformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btndesligar = new System.Windows.Forms.Button();
            this.btnligar = new System.Windows.Forms.Button();
            this.lblabduzidos = new System.Windows.Forms.Label();
            this.lbltripulantes = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAdicionarTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetornarDePlaneta = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.grbinformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbinformacoes
            // 
            this.grbinformacoes.Controls.Add(this.lblPlaneta);
            this.grbinformacoes.Controls.Add(this.btndesligar);
            this.grbinformacoes.Controls.Add(this.btnligar);
            this.grbinformacoes.Controls.Add(this.lblabduzidos);
            this.grbinformacoes.Controls.Add(this.lbltripulantes);
            this.grbinformacoes.Controls.Add(this.lblsituacao);
            this.grbinformacoes.Location = new System.Drawing.Point(12, 12);
            this.grbinformacoes.Name = "grbinformacoes";
            this.grbinformacoes.Size = new System.Drawing.Size(263, 280);
            this.grbinformacoes.TabIndex = 0;
            this.grbinformacoes.TabStop = false;
            this.grbinformacoes.Text = "informações";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(3, 98);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(73, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta Atual:";
            // 
            // btndesligar
            // 
            this.btndesligar.Location = new System.Drawing.Point(6, 187);
            this.btndesligar.Name = "btndesligar";
            this.btndesligar.Size = new System.Drawing.Size(160, 48);
            this.btndesligar.TabIndex = 4;
            this.btndesligar.Text = "Desligar";
            this.btndesligar.UseVisualStyleBackColor = true;
            this.btndesligar.Click += new System.EventHandler(this.btndesligar_Click);
            // 
            // btnligar
            // 
            this.btnligar.Location = new System.Drawing.Point(6, 135);
            this.btnligar.Name = "btnligar";
            this.btnligar.Size = new System.Drawing.Size(160, 48);
            this.btnligar.TabIndex = 3;
            this.btnligar.Text = "Ligar";
            this.btnligar.UseVisualStyleBackColor = true;
            this.btnligar.Click += new System.EventHandler(this.btnligar_Click);
            // 
            // lblabduzidos
            // 
            this.lblabduzidos.AutoSize = true;
            this.lblabduzidos.Location = new System.Drawing.Point(6, 76);
            this.lblabduzidos.Name = "lblabduzidos";
            this.lblabduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblabduzidos.TabIndex = 2;
            this.lblabduzidos.Text = "Abduzidos:";
            // 
            // lbltripulantes
            // 
            this.lbltripulantes.AutoSize = true;
            this.lbltripulantes.Location = new System.Drawing.Point(6, 53);
            this.lbltripulantes.Name = "lbltripulantes";
            this.lbltripulantes.Size = new System.Drawing.Size(62, 13);
            this.lbltripulantes.TabIndex = 1;
            this.lbltripulantes.Text = "Tripulantes:";
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Location = new System.Drawing.Point(7, 30);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(52, 13);
            this.lblsituacao.TabIndex = 0;
            this.lblsituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAdicionarTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(12, 298);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(263, 222);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(16, 89);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(227, 47);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAdicionarTripulantes
            // 
            this.btnAdicionarTripulantes.Location = new System.Drawing.Point(16, 36);
            this.btnAdicionarTripulantes.Name = "btnAdicionarTripulantes";
            this.btnAdicionarTripulantes.Size = new System.Drawing.Size(227, 47);
            this.btnAdicionarTripulantes.TabIndex = 0;
            this.btnAdicionarTripulantes.Text = "Adicionar";
            this.btnAdicionarTripulantes.UseVisualStyleBackColor = true;
            this.btnAdicionarTripulantes.Click += new System.EventHandler(this.btnAdicionarTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(290, 298);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(263, 222);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(16, 89);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(232, 47);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(16, 36);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(232, 47);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            this.btnAdicionarAbduzidos.Click += new System.EventHandler(this.btnAdicionarAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetornarDePlaneta);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(290, 12);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(263, 280);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetornarDePlaneta
            // 
            this.btnRetornarDePlaneta.Location = new System.Drawing.Point(16, 130);
            this.btnRetornarDePlaneta.Name = "btnRetornarDePlaneta";
            this.btnRetornarDePlaneta.Size = new System.Drawing.Size(180, 59);
            this.btnRetornarDePlaneta.TabIndex = 2;
            this.btnRetornarDePlaneta.Text = "Retornar";
            this.btnRetornarDePlaneta.UseVisualStyleBackColor = true;
            this.btnRetornarDePlaneta.Click += new System.EventHandler(this.btnRetornarDePlaneta_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(16, 65);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(180, 59);
            this.btnMudarPlaneta.TabIndex = 1;
            this.btnMudarPlaneta.Text = "Mudar De Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(6, 22);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(242, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pibTerra
            // 
            this.pibTerra.Location = new System.Drawing.Point(559, 22);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(259, 359);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 4;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbinformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbinformacoes.ResumeLayout(false);
            this.grbinformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbinformacoes;
        private System.Windows.Forms.Button btndesligar;
        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.Label lblabduzidos;
        private System.Windows.Forms.Label lbltripulantes;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAdicionarTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnRetornarDePlaneta;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Label lblPlaneta;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}