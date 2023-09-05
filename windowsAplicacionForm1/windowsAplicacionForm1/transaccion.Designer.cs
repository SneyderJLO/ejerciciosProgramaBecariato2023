namespace windowsAplicacionForm1
{
    partial class transaccion
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
            lblNombre = new Label();
            LBLvISA = new Label();
            labelfECHA = new Label();
            lblNumero = new Label();
            lblNombreBanco = new Label();
            pctCard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctCard).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Popup;
            lblNombre.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(29, 215);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(158, 25);
            lblNombre.TabIndex = 31;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBLvISA
            // 
            LBLvISA.BackColor = Color.Transparent;
            LBLvISA.FlatStyle = FlatStyle.Popup;
            LBLvISA.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBLvISA.ForeColor = Color.White;
            LBLvISA.Location = new Point(315, 213);
            LBLvISA.Name = "LBLvISA";
            LBLvISA.Size = new Size(99, 27);
            LBLvISA.TabIndex = 30;
            LBLvISA.Text = "VISA DEBIT";
            LBLvISA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelfECHA
            // 
            labelfECHA.BackColor = Color.Transparent;
            labelfECHA.FlatStyle = FlatStyle.Popup;
            labelfECHA.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelfECHA.ForeColor = Color.White;
            labelfECHA.Location = new Point(193, 215);
            labelfECHA.Name = "labelfECHA";
            labelfECHA.Size = new Size(79, 25);
            labelfECHA.TabIndex = 29;
            labelfECHA.Text = "00/00";
            labelfECHA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            lblNumero.BackColor = Color.Transparent;
            lblNumero.FlatStyle = FlatStyle.Popup;
            lblNumero.Font = new Font("Courier New", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(29, 165);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(296, 36);
            lblNumero.TabIndex = 28;
            lblNumero.Text = "000000000000000";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreBanco
            // 
            lblNombreBanco.BackColor = Color.Transparent;
            lblNombreBanco.FlatStyle = FlatStyle.Popup;
            lblNombreBanco.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreBanco.ForeColor = Color.White;
            lblNombreBanco.Location = new Point(29, 31);
            lblNombreBanco.Name = "lblNombreBanco";
            lblNombreBanco.Size = new Size(347, 36);
            lblNombreBanco.TabIndex = 27;
            lblNombreBanco.Text = "BANCO  NACIONAL XD";
            lblNombreBanco.Click += lblNombreBanco_Click;
            // 
            // pctCard
            // 
            pctCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pctCard.Image = Properties.Resources.card;
            pctCard.Location = new Point(1, 1);
            pctCard.Name = "pctCard";
            pctCard.Size = new Size(493, 254);
            pctCard.TabIndex = 26;
            pctCard.TabStop = false;
            pctCard.Click += pctCard_Click;
            // 
            // transaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 411);
            Controls.Add(lblNombre);
            Controls.Add(LBLvISA);
            Controls.Add(labelfECHA);
            Controls.Add(lblNumero);
            Controls.Add(lblNombreBanco);
            Controls.Add(pctCard);
            Name = "transaccion";
            Text = "transaccion";
            ((System.ComponentModel.ISupportInitialize)pctCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label LBLvISA;
        private Label labelfECHA;
        private Label lblNumero;
        private Label lblNombreBanco;
        private PictureBox pctCard;
    }
}