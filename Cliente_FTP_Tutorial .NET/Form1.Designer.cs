namespace Cliente_FTP_Tutorial_.NET
{
    partial class frmClienteFtp
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
            btnConectar = new Button();
            txtServidor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            rtbMensaje = new RichTextBox();
            ltvArchivo = new ListView();
            btnDescarga = new Button();
            txtRuta = new TextBox();
            btnCarga = new Button();
            txtArchivoCarga = new TextBox();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(287, 20);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(136, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(159, 21);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(112, 23);
            txtServidor.TabIndex = 1;
            txtServidor.Text = "srvlab05";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 68);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(159, 65);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(112, 23);
            txtLogin.TabIndex = 3;
            txtLogin.Text = "jvasquez";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 68);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Pass";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(323, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "123*abc*456";
            // 
            // rtbMensaje
            // 
            rtbMensaje.Location = new Point(181, 148);
            rtbMensaje.Name = "rtbMensaje";
            rtbMensaje.Size = new Size(329, 265);
            rtbMensaje.TabIndex = 7;
            rtbMensaje.Text = "";
            // 
            // ltvArchivo
            // 
            ltvArchivo.Location = new Point(12, 148);
            ltvArchivo.Name = "ltvArchivo";
            ltvArchivo.Size = new Size(149, 265);
            ltvArchivo.TabIndex = 8;
            ltvArchivo.UseCompatibleStateImageBehavior = false;
            // 
            // btnDescarga
            // 
            btnDescarga.Location = new Point(94, 118);
            btnDescarga.Name = "btnDescarga";
            btnDescarga.Size = new Size(75, 23);
            btnDescarga.TabIndex = 9;
            btnDescarga.Text = "descarga";
            btnDescarga.UseVisualStyleBackColor = true;
            btnDescarga.Click += btnDescarga_Click;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(181, 118);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(152, 23);
            txtRuta.TabIndex = 10;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(435, 118);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(75, 23);
            btnCarga.TabIndex = 11;
            btnCarga.Text = "cargar";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // txtArchivoCarga
            // 
            txtArchivoCarga.Location = new Point(345, 118);
            txtArchivoCarga.Name = "txtArchivoCarga";
            txtArchivoCarga.Size = new Size(84, 23);
            txtArchivoCarga.TabIndex = 12;
            // 
            // frmClienteFtp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(txtArchivoCarga);
            Controls.Add(btnCarga);
            Controls.Add(txtRuta);
            Controls.Add(btnDescarga);
            Controls.Add(ltvArchivo);
            Controls.Add(rtbMensaje);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Controls.Add(txtServidor);
            Controls.Add(btnConectar);
            Name = "frmClienteFtp";
            Text = "clienteFtp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private TextBox txtServidor;
        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private Label label3;
        private TextBox txtPassword;
        private RichTextBox rtbMensaje;
        private ListView ltvArchivo;
        private Button btnDescarga;
        private TextBox txtRuta;
        private Button btnCarga;
        private TextBox txtArchivoCarga;
    }
}