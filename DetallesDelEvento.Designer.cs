﻿namespace ShowTime_DatabseProject
{
    partial class DetallesDelEvento
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUbicacion = new TextBox();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtDetalles = new TextBox();
            txtCantidadAsistentes = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            dtpFechaReserva = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            txtHoraFin = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            CloseButton = new Button();
            continueButton = new Button();
            label1 = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(255, 229, 217);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(400, 550);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(txtUbicacion, 3, 0);
            tableLayoutPanel1.Controls.Add(txtDireccion, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 1, 6);
            tableLayoutPanel1.Controls.Add(txtDetalles, 3, 6);
            tableLayoutPanel1.Controls.Add(txtCantidadAsistentes, 3, 5);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 1, 4);
            tableLayoutPanel1.Controls.Add(dtpFechaReserva, 3, 2);
            tableLayoutPanel1.Controls.Add(txtHoraInicio, 3, 3);
            tableLayoutPanel1.Controls.Add(txtHoraFin, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(400, 220);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 3;
            label2.Text = "Ubicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 4;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 5;
            label4.Text = "Fecha";
            // 
            // txtUbicacion
            // 
            txtUbicacion.BorderStyle = BorderStyle.None;
            txtUbicacion.Dock = DockStyle.Fill;
            txtUbicacion.Location = new Point(224, 4);
            txtUbicacion.Margin = new Padding(4);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(132, 24);
            txtUbicacion.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Location = new Point(224, 36);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(132, 24);
            txtDireccion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 192);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(131, 28);
            label7.TabIndex = 13;
            label7.Text = "Detalles Adicionales";
            // 
            // txtDetalles
            // 
            txtDetalles.BorderStyle = BorderStyle.None;
            txtDetalles.Dock = DockStyle.Fill;
            txtDetalles.Location = new Point(224, 196);
            txtDetalles.Margin = new Padding(4);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(132, 20);
            txtDetalles.TabIndex = 14;
            // 
            // txtCantidadAsistentes
            // 
            txtCantidadAsistentes.BorderStyle = BorderStyle.None;
            txtCantidadAsistentes.Dock = DockStyle.Fill;
            txtCantidadAsistentes.Location = new Point(224, 164);
            txtCantidadAsistentes.Margin = new Padding(4);
            txtCantidadAsistentes.Multiline = true;
            txtCantidadAsistentes.Name = "txtCantidadAsistentes";
            txtCantidadAsistentes.Size = new Size(132, 24);
            txtCantidadAsistentes.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 11;
            label6.Text = "Asistentes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 96);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 6;
            label5.Text = "Hora inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 15;
            label8.Text = "Hora final";
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Format = DateTimePickerFormat.Short;
            dtpFechaReserva.Location = new Point(223, 67);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(134, 27);
            dtpFechaReserva.TabIndex = 17;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Format = DateTimePickerFormat.Time;
            txtHoraInicio.Location = new Point(223, 99);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(134, 27);
            txtHoraInicio.TabIndex = 18;
            // 
            // txtHoraFin
            // 
            txtHoraFin.Format = DateTimePickerFormat.Time;
            txtHoraFin.Location = new Point(223, 131);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new Size(134, 27);
            txtHoraFin.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(CloseButton, 1, 1);
            tableLayoutPanel3.Controls.Add(continueButton, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 302);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(400, 192);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(44, 61);
            CloseButton.Margin = new Padding(4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(132, 49);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Salir";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Fill;
            continueButton.FlatAppearance.BorderSize = 0;
            continueButton.FlatStyle = FlatStyle.Flat;
            continueButton.Location = new Point(224, 61);
            continueButton.Margin = new Padding(4);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(132, 49);
            continueButton.TabIndex = 1;
            continueButton.Text = "Continuar";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 55);
            label1.TabIndex = 2;
            label1.Text = "Informacion del evento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetallesDelEvento
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 550);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DetallesDelEvento";
            Text = "DetallesDelEvento";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUbicacion;
        private TextBox txtDireccion;
        private TextBox EmailTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CloseButton;
        private Button continueButton;
        private Label label1;
        private Label label6;
        private TextBox txtCantidadAsistentes;
        private Label label7;
        private TextBox txtDetalles;
        private Label label8;
        private TextBox textBox3;
        private DateTimePicker dtpFechaReserva;
        private DateTimePicker txtHoraInicio;
        private DateTimePicker txtHoraFin;
    }
}