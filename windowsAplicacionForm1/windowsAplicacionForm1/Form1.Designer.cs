namespace windowsAplicacionForm1
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            cmbDescripcionTipo = new ComboBox();
            cmbDescripcionRazon = new ComboBox();
            panelFooter = new Panel();
            lblComprobarTransaccion = new Label();
            txtValueTipo = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtTipo = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            txtRazon = new TextBox();
            label1 = new Label();
            panelFooter.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(291, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(120, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 3;
            label2.Text = "Fecha de transaccion";
            // 
            // button1
            // 
            button1.Location = new Point(575, 178);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 4;
            button1.Text = "Generar tarjeta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 5;
            label3.Text = "Comercio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 8;
            label4.Text = "Valor de transacción";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tía", "Comisariato", "Tuti", "Ganga" });
            comboBox1.Location = new Point(12, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 23);
            textBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 33);
            label5.TabIndex = 11;
            label5.Text = "Tipo de transacción";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDescripcionTipo
            // 
            cmbDescripcionTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescripcionTipo.FlatStyle = FlatStyle.System;
            cmbDescripcionTipo.FormattingEnabled = true;
            cmbDescripcionTipo.Items.AddRange(new object[] { "" });
            cmbDescripcionTipo.Location = new Point(16, 12);
            cmbDescripcionTipo.Name = "cmbDescripcionTipo";
            cmbDescripcionTipo.Size = new Size(27, 23);
            cmbDescripcionTipo.TabIndex = 12;
            cmbDescripcionTipo.SelectedIndexChanged += cmbDescripcionTipo_SelectedIndexChanged;
            // 
            // cmbDescripcionRazon
            // 
            cmbDescripcionRazon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescripcionRazon.FormattingEnabled = true;
            cmbDescripcionRazon.Location = new Point(16, 12);
            cmbDescripcionRazon.Name = "cmbDescripcionRazon";
            cmbDescripcionRazon.Size = new Size(27, 23);
            cmbDescripcionRazon.TabIndex = 14;
            cmbDescripcionRazon.SelectedIndexChanged += cmbDescripcionRazon_SelectedIndexChanged;
            // 
            // panelFooter
            // 
            panelFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFooter.BackColor = Color.FromArgb(0, 69, 99);
            panelFooter.Controls.Add(lblComprobarTransaccion);
            panelFooter.Location = new Point(0, 546);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(885, 54);
            panelFooter.TabIndex = 17;
            // 
            // lblComprobarTransaccion
            // 
            lblComprobarTransaccion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblComprobarTransaccion.AutoSize = true;
            lblComprobarTransaccion.Cursor = Cursors.Hand;
            lblComprobarTransaccion.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobarTransaccion.ForeColor = Color.White;
            lblComprobarTransaccion.Location = new Point(80, 14);
            lblComprobarTransaccion.Name = "lblComprobarTransaccion";
            lblComprobarTransaccion.Size = new Size(275, 21);
            lblComprobarTransaccion.TabIndex = 2;
            lblComprobarTransaccion.Text = "Comprobar estado de transacción";
            lblComprobarTransaccion.Click += lblComprobarTransaccion_Click;
            // 
            // txtValueTipo
            // 
            txtValueTipo.BackColor = SystemColors.Window;
            txtValueTipo.BorderStyle = BorderStyle.None;
            txtValueTipo.Location = new Point(302, 12);
            txtValueTipo.Name = "txtValueTipo";
            txtValueTipo.ReadOnly = true;
            txtValueTipo.Size = new Size(51, 16);
            txtValueTipo.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(13, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 98);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.Controls.Add(txtTipo);
            panel2.Controls.Add(cmbDescripcionTipo);
            panel2.Controls.Add(txtValueTipo);
            panel2.Location = new Point(12, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 51);
            panel2.TabIndex = 12;
            // 
            // txtTipo
            // 
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(54, 12);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(205, 20);
            txtTipo.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 393);
            panel3.Name = "panel3";
            panel3.Size = new Size(413, 98);
            panel3.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 255);
            panel4.Controls.Add(txtRazon);
            panel4.Controls.Add(cmbDescripcionRazon);
            panel4.Location = new Point(12, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 51);
            panel4.TabIndex = 12;
            // 
            // txtRazon
            // 
            txtRazon.BorderStyle = BorderStyle.None;
            txtRazon.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazon.Location = new Point(54, 15);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(221, 20);
            txtRazon.TabIndex = 19;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 33);
            label1.TabIndex = 11;
            label1.Text = "Especifique la razón";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(232, 231, 231);
            ClientSize = new Size(881, 599);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelFooter);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de transacciones";
            Load += Form1_Load;
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label5;
        private ComboBox cmbDescripcionTipo;
        private ComboBox cmbDescripcionRazon;
        private Panel panelFooter;
        private Label lblComprobarTransaccion;
        private TextBox txtValueTipo;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtTipo;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtRazon;
        private Label label1;
    }
}