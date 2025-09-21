namespace ReservaSalasUCL.Forms
{
    partial class TelaAdmin
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
            this.panelTelaAdmin = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarSalas = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTelaAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTelaAdmin
            // 
            this.panelTelaAdmin.Controls.Add(this.btnSair);
            this.panelTelaAdmin.Controls.Add(this.btnCadastrarSalas);
            this.panelTelaAdmin.Controls.Add(this.btnGerenciar);
            this.panelTelaAdmin.Controls.Add(this.lblFrase);
            this.panelTelaAdmin.Controls.Add(this.lblTitulo);
            this.panelTelaAdmin.Location = new System.Drawing.Point(12, 12);
            this.panelTelaAdmin.Name = "panelTelaAdmin";
            this.panelTelaAdmin.Size = new System.Drawing.Size(750, 450);
            this.panelTelaAdmin.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(213, 341);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(311, 26);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarSalas
            // 
            this.btnCadastrarSalas.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarSalas.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSalas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSalas.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarSalas.Location = new System.Drawing.Point(213, 254);
            this.btnCadastrarSalas.Name = "btnCadastrarSalas";
            this.btnCadastrarSalas.Size = new System.Drawing.Size(311, 26);
            this.btnCadastrarSalas.TabIndex = 3;
            this.btnCadastrarSalas.Text = "Cadastrar Salas";
            this.btnCadastrarSalas.UseVisualStyleBackColor = false;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.Green;
            this.btnGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Location = new System.Drawing.Point(213, 184);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(311, 26);
            this.btnGerenciar.TabIndex = 2;
            this.btnGerenciar.Text = "Gerenciar Reservas";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFrase.Location = new System.Drawing.Point(201, 99);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(342, 18);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Selecione uma opção para gerenciar o sistema.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(206, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Administrador";
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 475);
            this.Controls.Add(this.panelTelaAdmin);
            this.Name = "TelaAdmin";
            this.Text = "TelaAdmin";
            this.Load += new System.EventHandler(this.TelaAdmin_Load);
            this.panelTelaAdmin.ResumeLayout(false);
            this.panelTelaAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTelaAdmin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrarSalas;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblTitulo;
    }
}