namespace clienteTcpIP
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
            btnEnviar = new Button();
            txtMensaje = new TextBox();
            rtbSalida = new RichTextBox();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(175, 68);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(47, 68);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(100, 23);
            txtMensaje.TabIndex = 1;
            // 
            // rtbSalida
            // 
            rtbSalida.Location = new Point(47, 108);
            rtbSalida.Name = "rtbSalida";
            rtbSalida.Size = new Size(364, 290);
            rtbSalida.TabIndex = 2;
            rtbSalida.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbSalida);
            Controls.Add(txtMensaje);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "CLIENTE_TCP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtMensaje;
        private RichTextBox rtbSalida;
    }
}