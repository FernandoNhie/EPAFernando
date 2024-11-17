namespace EPAFernando
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtIdade = new NumericUpDown();
            txtCPF = new TextBox();
            btnSalvar = new Button();
            lblDadosExibidos = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            lblCPF = new Label();
            ((System.ComponentModel.ISupportInitialize)txtIdade).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(136, 70);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(136, 161);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(200, 23);
            txtIdade.TabIndex = 3;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(136, 205);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 23);
            txtCPF.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(12, 250);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(324, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblDadosExibidos
            // 
            lblDadosExibidos.BorderStyle = BorderStyle.FixedSingle;
            lblDadosExibidos.Location = new Point(12, 288);
            lblDadosExibidos.Name = "lblDadosExibidos";
            lblDadosExibidos.Size = new Size(324, 150);
            lblDadosExibidos.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 73);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(13, 163);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(39, 15);
            lblIdade.TabIndex = 10;
            lblIdade.Text = "Idade:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 208);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 11;
            lblCPF.Text = "CPF:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 461);
            Controls.Add(lblCPF);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblDadosExibidos);
            Controls.Add(btnSalvar);
            Controls.Add(txtCPF);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Cadastro de Clientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDadosExibidos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCPF;
    }
}
