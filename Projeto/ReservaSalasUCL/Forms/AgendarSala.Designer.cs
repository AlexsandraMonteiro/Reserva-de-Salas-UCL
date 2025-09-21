namespace ReservaSalasUCL.Forms
{
    partial class AgendarSala
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
            this.panelAgendarSala = new System.Windows.Forms.Panel();
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblPessoas = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelAgendarSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgendarSala
            // 
            this.panelAgendarSala.BackColor = System.Drawing.Color.White;
            this.panelAgendarSala.Controls.Add(this.txtPessoas);
            this.panelAgendarSala.Controls.Add(this.dtpDia);
            this.panelAgendarSala.Controls.Add(this.cmbHora);
            this.panelAgendarSala.Controls.Add(this.cmbSala);
            this.panelAgendarSala.Controls.Add(this.btnVoltar);
            this.panelAgendarSala.Controls.Add(this.btnEnviar);
            this.panelAgendarSala.Controls.Add(this.lblPessoas);
            this.panelAgendarSala.Controls.Add(this.lblHora);
            this.panelAgendarSala.Controls.Add(this.lblDia);
            this.panelAgendarSala.Controls.Add(this.lblSala);
            this.panelAgendarSala.Controls.Add(this.lblTitulo);
            this.panelAgendarSala.Location = new System.Drawing.Point(34, 12);
            this.panelAgendarSala.Name = "panelAgendarSala";
            this.panelAgendarSala.Size = new System.Drawing.Size(900, 700);
            this.panelAgendarSala.TabIndex = 0;
            // 
            // txtPessoas
            // 
            this.txtPessoas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPessoas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPessoas.Location = new System.Drawing.Point(312, 408);
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(306, 26);
            this.txtPessoas.TabIndex = 12;
            // 
            // dtpDia
            // 
            this.dtpDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Location = new System.Drawing.Point(312, 252);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(306, 26);
            this.dtpDia.TabIndex = 11;
            // 
            // cmbHora
            // 
            this.cmbHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(312, 328);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(306, 26);
            this.cmbHora.TabIndex = 10;
            // 
            // cmbSala
            // 
            this.cmbSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(312, 168);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(306, 26);
            this.cmbSala.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkRed;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(312, 547);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(306, 33);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(312, 478);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(306, 33);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar Solicitação";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoas.ForeColor = System.Drawing.Color.Black;
            this.lblPessoas.Location = new System.Drawing.Point(308, 373);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(190, 19);
            this.lblPessoas.TabIndex = 4;
            this.lblPessoas.Text = "Quantidade de Pessoas";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(308, 294);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 19);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(308, 221);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(34, 19);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Dia";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Black;
            this.lblSala.Location = new System.Drawing.Point(308, 135);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(214, 19);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Escolha a Sala/Laboratório";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(338, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agendar Sala";
            // 
            // AgendarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1095, 765);
            this.Controls.Add(this.panelAgendarSala);
            this.Name = "AgendarSala";
            this.Text = "AgendarSala";
            this.Load += new System.EventHandler(this.AgendarSala_Load);
            this.panelAgendarSala.ResumeLayout(false);
            this.panelAgendarSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgendarSala;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblPessoas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPessoas;
    }
}