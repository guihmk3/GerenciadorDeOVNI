namespace GerenciadorDeOVNI
{
    partial class TelaInicial
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
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.txbAbduzidos = new System.Windows.Forms.TextBox();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(127, 106);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(116, 13);
            this.lblTripulantes.TabIndex = 0;
            this.lblTripulantes.Text = "Máximo de Tripulantes:";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(249, 103);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(100, 20);
            this.txbTripulantes.TabIndex = 1;
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(249, 132);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(100, 20);
            this.txbAbduzidos.TabIndex = 3;
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(127, 135);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(113, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Máximo de Abduzidos:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(127, 162);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(97, 13);
            this.lblPlaneta.TabIndex = 4;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(249, 159);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(100, 21);
            this.cmbPlanetas.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(116, 203);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(250, 47);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(124, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "UFO MANAGER 5000";
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::GerenciadorDeOVNI.Properties.Resources.abduction;
            this.pibIcon.Location = new System.Drawing.Point(17, 19);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(92, 81);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcon.TabIndex = 8;
            this.pibIcon.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 294);
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblTripulantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.TextBox txbAbduzidos;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcon;
    }
}