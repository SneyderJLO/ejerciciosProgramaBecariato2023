namespace _38_NetworkInformation_Tutorial
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
            label1 = new Label();
            lblDisponibilidadRed = new Label();
            label3 = new Label();
            cmbRed = new ComboBox();
            label2 = new Label();
            lblDnsSuffix = new Label();
            lblBytesSent = new Label();
            label5 = new Label();
            lblBytesreceived = new Label();
            label7 = new Label();
            lblSupportMulticast = new Label();
            label9 = new Label();
            lblOperationalStatus = new Label();
            label11 = new Label();
            lblSpeed = new Label();
            label13 = new Label();
            lstDireccionesIp = new ListView();
            direccion = new ColumnHeader();
            tipo = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Disponibilidad de red: ";
            // 
            // lblDisponibilidadRed
            // 
            lblDisponibilidadRed.BorderStyle = BorderStyle.Fixed3D;
            lblDisponibilidadRed.Location = new Point(182, 24);
            lblDisponibilidadRed.Name = "lblDisponibilidadRed";
            lblDisponibilidadRed.Size = new Size(224, 28);
            lblDisponibilidadRed.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 71);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Interfaces de Red";
            // 
            // cmbRed
            // 
            cmbRed.FormattingEnabled = true;
            cmbRed.Location = new Point(182, 71);
            cmbRed.Name = "cmbRed";
            cmbRed.Size = new Size(224, 23);
            cmbRed.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 135);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "DNS suffix";
            // 
            // lblDnsSuffix
            // 
            lblDnsSuffix.BorderStyle = BorderStyle.Fixed3D;
            lblDnsSuffix.Location = new Point(182, 134);
            lblDnsSuffix.Name = "lblDnsSuffix";
            lblDnsSuffix.Size = new Size(224, 27);
            lblDnsSuffix.TabIndex = 5;
            // 
            // lblBytesSent
            // 
            lblBytesSent.BorderStyle = BorderStyle.Fixed3D;
            lblBytesSent.Location = new Point(182, 190);
            lblBytesSent.Name = "lblBytesSent";
            lblBytesSent.Size = new Size(224, 27);
            lblBytesSent.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 191);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "Bytes sent";
            // 
            // lblBytesreceived
            // 
            lblBytesreceived.BorderStyle = BorderStyle.Fixed3D;
            lblBytesreceived.Location = new Point(182, 247);
            lblBytesreceived.Name = "lblBytesreceived";
            lblBytesreceived.Size = new Size(224, 27);
            lblBytesreceived.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 248);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 8;
            label7.Text = "Bytes received";
            // 
            // lblSupportMulticast
            // 
            lblSupportMulticast.BorderStyle = BorderStyle.Fixed3D;
            lblSupportMulticast.Location = new Point(182, 297);
            lblSupportMulticast.Name = "lblSupportMulticast";
            lblSupportMulticast.Size = new Size(224, 27);
            lblSupportMulticast.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 298);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 10;
            label9.Text = "Support multicast";
            // 
            // lblOperationalStatus
            // 
            lblOperationalStatus.BorderStyle = BorderStyle.Fixed3D;
            lblOperationalStatus.Location = new Point(182, 348);
            lblOperationalStatus.Name = "lblOperationalStatus";
            lblOperationalStatus.Size = new Size(224, 27);
            lblOperationalStatus.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 349);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 12;
            label11.Text = "Operational Status";
            // 
            // lblSpeed
            // 
            lblSpeed.BorderStyle = BorderStyle.Fixed3D;
            lblSpeed.Location = new Point(182, 391);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(224, 27);
            lblSpeed.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 392);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 14;
            label13.Text = "Speed";
            // 
            // lstDireccionesIp
            // 
            lstDireccionesIp.Columns.AddRange(new ColumnHeader[] { direccion, tipo });
            lstDireccionesIp.Location = new Point(412, 25);
            lstDireccionesIp.Name = "lstDireccionesIp";
            lstDireccionesIp.Size = new Size(308, 394);
            lstDireccionesIp.TabIndex = 16;
            lstDireccionesIp.UseCompatibleStateImageBehavior = false;
            lstDireccionesIp.View = View.Details;
            // 
            // direccion
            // 
            direccion.Text = "direccion";
            direccion.Width = 200;
            // 
            // tipo
            // 
            tipo.Text = "tipo";
            tipo.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDireccionesIp);
            Controls.Add(lblSpeed);
            Controls.Add(label13);
            Controls.Add(lblOperationalStatus);
            Controls.Add(label11);
            Controls.Add(lblSupportMulticast);
            Controls.Add(label9);
            Controls.Add(lblBytesreceived);
            Controls.Add(label7);
            Controls.Add(lblBytesSent);
            Controls.Add(label5);
            Controls.Add(lblDnsSuffix);
            Controls.Add(label2);
            Controls.Add(cmbRed);
            Controls.Add(label3);
            Controls.Add(lblDisponibilidadRed);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Información de red";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDisponibilidadRed;
        private Label label3;
        private ComboBox cmbRed;
        private Label label2;
        private Label lblDnsSuffix;
        private Label lblBytesSent;
        private Label label5;
        private Label lblBytesreceived;
        private Label label7;
        private Label lblSupportMulticast;
        private Label label9;
        private Label lblOperationalStatus;
        private Label label11;
        private Label lblSpeed;
        private Label label13;
        private ListView lstDireccionesIp;
        private ColumnHeader direccion;
        private ColumnHeader tipo;
    }
}