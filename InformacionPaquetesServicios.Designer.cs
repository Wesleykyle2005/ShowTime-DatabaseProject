﻿namespace ShowTime_DatabseProject
{
    partial class InformacionPaquetesServicios
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
            label5 = new Label();
            numberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            ServiciosListBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            CloseButton = new Button();
            button1 = new Button();
            label1 = new Label();
            PaquetesListBox = new ListBox();
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
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
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(numberTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(EmailTextBox, 3, 3);
            tableLayoutPanel1.Controls.Add(ServiciosListBox, 3, 0);
            tableLayoutPanel1.Controls.Add(PaquetesListBox, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(400, 192);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(43, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 48);
            label2.TabIndex = 3;
            label2.Text = "Servicios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(43, 48);
            label3.Name = "label3";
            label3.Size = new Size(134, 48);
            label3.TabIndex = 4;
            label3.Text = "Paquetes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(43, 96);
            label4.Name = "label4";
            label4.Size = new Size(134, 48);
            label4.TabIndex = 5;
            label4.Text = "Costo total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(43, 144);
            label5.Name = "label5";
            label5.Size = new Size(134, 48);
            label5.TabIndex = 6;
            label5.Text = "Pago inicial";
            // 
            // numberTextBox
            // 
            numberTextBox.BorderStyle = BorderStyle.None;
            numberTextBox.Dock = DockStyle.Fill;
            numberTextBox.Location = new Point(223, 99);
            numberTextBox.Multiline = true;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(134, 42);
            numberTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Dock = DockStyle.Fill;
            EmailTextBox.Location = new Point(223, 147);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(134, 42);
            EmailTextBox.TabIndex = 10;
            // 
            // ServiciosListBox
            // 
            ServiciosListBox.BorderStyle = BorderStyle.None;
            ServiciosListBox.Dock = DockStyle.Fill;
            ServiciosListBox.FormattingEnabled = true;
            ServiciosListBox.ItemHeight = 20;
            ServiciosListBox.Location = new Point(223, 3);
            ServiciosListBox.MultiColumn = true;
            ServiciosListBox.Name = "ServiciosListBox";
            ServiciosListBox.SelectionMode = SelectionMode.MultiSimple;
            ServiciosListBox.Size = new Size(134, 42);
            ServiciosListBox.TabIndex = 11;
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
            tableLayoutPanel3.Controls.Add(button1, 3, 1);
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
            CloseButton.Location = new Point(43, 60);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(134, 51);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Salir";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(223, 60);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 1;
            button1.Text = "Registrar evento";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 21);
            label1.TabIndex = 2;
            label1.Text = "Informacion del cliente";
            // 
            // PaquetesListBox
            // 
            PaquetesListBox.BorderStyle = BorderStyle.None;
            PaquetesListBox.Dock = DockStyle.Fill;
            PaquetesListBox.FormattingEnabled = true;
            PaquetesListBox.ItemHeight = 20;
            PaquetesListBox.Location = new Point(223, 51);
            PaquetesListBox.MultiColumn = true;
            PaquetesListBox.Name = "PaquetesListBox";
            PaquetesListBox.SelectionMode = SelectionMode.MultiSimple;
            PaquetesListBox.Size = new Size(134, 42);
            PaquetesListBox.TabIndex = 12;
            // 
            // InformacionPaquetesServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 550);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformacionPaquetesServicios";
            Text = "InformacionPaquetesServicios";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TextBox numberTextBox;
        private TextBox EmailTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CloseButton;
        private Button button1;
        private Label label1;
        private ListBox ServiciosListBox;
        private ListBox PaquetesListBox;
    }
}