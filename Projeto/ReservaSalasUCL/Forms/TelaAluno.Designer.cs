namespace ReservaSalasUCL.Forms
{
    partial class TelaAluno
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
            this.panelTelaAluno = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnAgendarSalas = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTelaAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTelaAluno
            // 
            this.panelTelaAluno.BackColor = System.Drawing.Color.White;
            this.panelTelaAluno.Controls.Add(this.btnSair);
            this.panelTelaAluno.Controls.Add(this.btnVerificar);
            this.panelTelaAluno.Controls.Add(this.btnAgendarSalas);
            this.panelTelaAluno.Controls.Add(this.lblFrase);
            this.panelTelaAluno.Controls.Add(this.lblTitulo);
            this.panelTelaAluno.Location = new System.Drawing.Point(12, 12);
            this.panelTelaAluno.Name = "panelTelaAluno";
            this.panelTelaAluno.Size = new System.Drawing.Size(750, 450);
            this.panelTelaAluno.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(254, 323);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(258, 27);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Green;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(254, 229);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(258, 27);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar Agendamentos";
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // btnAgendarSalas
            // 
            this.btnAgendarSalas.BackColor = System.Drawing.Color.Green;
            this.btnAgendarSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarSalas.FlatAppearance.BorderSize = 0;
            this.btnAgendarSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarSalas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarSalas.ForeColor = System.Drawing.Color.White;
            this.btnAgendarSalas.Location = new System.Drawing.Point(254, 162);
            this.btnAgendarSalas.Name = "btnAgendarSalas";
            this.btnAgendarSalas.Size = new System.Drawing.Size(258, 27);
            this.btnAgendarSalas.TabIndex = 2;
            this.btnAgendarSalas.Text = "Agendar Salas";
            this.btnAgendarSalas.UseVisualStyleBackColor = false;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFrase.Location = new System.Drawing.Point(205, 86);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(371, 18);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Selecione uma opção para gerenciar suas reservas.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(290, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Olá, Aluno!";
            // 
            // TelaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTelaAluno);
            this.Name = "TelaAluno";
            this.Text = "TelaAluno";
            this.Load += new System.EventHandler(this.TelaAluno_Load);
            this.panelTelaAluno.ResumeLayout(false);
            this.panelTelaAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTelaAluno;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnAgendarSalas;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblTitulo;
    }
}