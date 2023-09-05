namespace Cliente_SMTP_Tutorial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtServidor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtDe = new TextBox();
            groupBox2 = new GroupBox();
            btnEnviar = new Button();
            label7 = new Label();
            txtContenido = new TextBox();
            label6 = new Label();
            txtAsunto = new TextBox();
            label5 = new Label();
            txtPara = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(37, 53);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(207, 23);
            txtServidor.TabIndex = 0;
            txtServidor.Text = "smtp.live.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(37, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(207, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "tenemriq@outlook.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 151);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(207, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtServidor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 230);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 30);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 8;
            label4.Text = "De";
            label4.Click += label4_Click;
            // 
            // txtDe
            // 
            txtDe.Location = new Point(37, 48);
            txtDe.Name = "txtDe";
            txtDe.Size = new Size(152, 23);
            txtDe.TabIndex = 7;
            txtDe.Text = "tenemriq@outlook.com";
            txtDe.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtContenido);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAsunto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPara);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDe);
            groupBox2.Location = new Point(12, 264);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 174);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(407, 134);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 15;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 92);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "Contenido";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(213, 110);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(152, 47);
            txtContenido.TabIndex = 13;
            txtContenido.Text = "asdasd";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 30);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Asunto";
            label6.Click += label6_Click;
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(213, 48);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(152, 23);
            txtAsunto.TabIndex = 11;
            txtAsunto.Text = "sdad";
            txtAsunto.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 92);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "Para";
            // 
            // txtPara
            // 
            txtPara.Location = new Point(37, 110);
            txtPara.Name = "txtPara";
            txtPara.Size = new Size(152, 23);
            txtPara.TabIndex = 9;
            txtPara.Text = "lojanoneysser@gmail.com";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cliente SMTP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtServidor;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtPassword;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtDe;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtContenido;
        private Label label6;
        private TextBox txtAsunto;
        private Label label5;
        private TextBox txtPara;
        private Button btnEnviar;
    }
}