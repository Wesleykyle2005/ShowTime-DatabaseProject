﻿namespace ShowTime_DatabseProject
{
    partial class Paquetes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            txtPackageDescription = new TextBox();
            label1 = new Label();
            txtPackageName = new TextBox();
            label2 = new Label();
            btnUpdatePackage = new Button();
            btnRegisterPackage = new Button();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPackages = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            comboBoxDisponibilidad = new ComboBox();
            ServicesListBox = new ListBox();
            label7 = new Label();
            numCantidad = new NumericUpDown();
            numCosto = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 34;
            label3.Text = "Descripcion";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Dock = DockStyle.Fill;
            txtPackageDescription.Location = new Point(144, 37);
            txtPackageDescription.Margin = new Padding(4);
            txtPackageDescription.Multiline = true;
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(412, 25);
            txtPackageDescription.TabIndex = 33;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(692, 50);
            label1.TabIndex = 30;
            label1.Text = "Administrar paquetes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPackageName
            // 
            txtPackageName.Dock = DockStyle.Fill;
            txtPackageName.Location = new Point(144, 4);
            txtPackageName.Margin = new Padding(4);
            txtPackageName.Multiline = true;
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(412, 25);
            txtPackageName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 40;
            label2.Text = "Costo";
            // 
            // btnUpdatePackage
            // 
            btnUpdatePackage.Dock = DockStyle.Fill;
            btnUpdatePackage.FlatAppearance.BorderSize = 0;
            btnUpdatePackage.FlatStyle = FlatStyle.Flat;
            btnUpdatePackage.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdatePackage.Location = new Point(564, 37);
            btnUpdatePackage.Margin = new Padding(4);
            btnUpdatePackage.Name = "btnUpdatePackage";
            btnUpdatePackage.Size = new Size(132, 25);
            btnUpdatePackage.TabIndex = 44;
            btnUpdatePackage.Text = "Actualizar Paquete";
            btnUpdatePackage.UseVisualStyleBackColor = true;
            btnUpdatePackage.Click += btnUpdatePackage_Click;
            // 
            // btnRegisterPackage
            // 
            btnRegisterPackage.Dock = DockStyle.Fill;
            btnRegisterPackage.FlatAppearance.BorderSize = 0;
            btnRegisterPackage.FlatStyle = FlatStyle.Flat;
            btnRegisterPackage.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRegisterPackage.Location = new Point(564, 4);
            btnRegisterPackage.Margin = new Padding(4);
            btnRegisterPackage.Name = "btnRegisterPackage";
            btnRegisterPackage.Size = new Size(132, 25);
            btnRegisterPackage.TabIndex = 43;
            btnRegisterPackage.Text = "Registrar Paquete";
            btnRegisterPackage.UseVisualStyleBackColor = true;
            btnRegisterPackage.Click += btnRegisterPackage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 33);
            label4.TabIndex = 63;
            label4.Text = "Servicios incluidos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 229, 217);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(dgvPackages, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(700, 500);
            tableLayoutPanel1.TabIndex = 66;
            // 
            // dgvPackages
            // 
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.AllowUserToDeleteRows = false;
            dgvPackages.AllowUserToResizeColumns = false;
            dgvPackages.AllowUserToResizeRows = false;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPackages.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvPackages.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPackages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPackages.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPackages.Dock = DockStyle.Fill;
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.GridColor = Color.Black;
            dgvPackages.Location = new Point(0, 250);
            dgvPackages.Margin = new Padding(0);
            dgvPackages.MultiSelect = false;
            dgvPackages.Name = "dgvPackages";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPackages.RowHeadersVisible = false;
            dgvPackages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.ShowCellErrors = false;
            dgvPackages.ShowRowErrors = false;
            dgvPackages.Size = new Size(700, 250);
            dgvPackages.TabIndex = 74;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(btnUpdatePackage, 2, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(btnRegisterPackage, 2, 0);
            tableLayoutPanel2.Controls.Add(txtPackageName, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPackageDescription, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 5);
            tableLayoutPanel2.Controls.Add(comboBoxDisponibilidad, 1, 5);
            tableLayoutPanel2.Controls.Add(ServicesListBox, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(numCantidad, 1, 3);
            tableLayoutPanel2.Controls.Add(numCosto, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 67;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 35);
            label5.TabIndex = 65;
            label5.Text = "Disponibilidad";
            // 
            // comboBoxDisponibilidad
            // 
            comboBoxDisponibilidad.Dock = DockStyle.Fill;
            comboBoxDisponibilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDisponibilidad.FlatStyle = FlatStyle.Flat;
            comboBoxDisponibilidad.FormattingEnabled = true;
            comboBoxDisponibilidad.Location = new Point(144, 169);
            comboBoxDisponibilidad.Margin = new Padding(4);
            comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
            comboBoxDisponibilidad.Size = new Size(412, 28);
            comboBoxDisponibilidad.TabIndex = 66;
            // 
            // ServicesListBox
            // 
            ServicesListBox.BorderStyle = BorderStyle.None;
            ServicesListBox.Dock = DockStyle.Fill;
            ServicesListBox.FormattingEnabled = true;
            ServicesListBox.ItemHeight = 20;
            ServicesListBox.Items.AddRange(new object[] { "as", "as", "as", "as", "as", "as", "as", "as" });
            ServicesListBox.Location = new Point(140, 132);
            ServicesListBox.Margin = new Padding(0);
            ServicesListBox.Name = "ServicesListBox";
            ServicesListBox.SelectionMode = SelectionMode.MultiSimple;
            ServicesListBox.Size = new Size(420, 33);
            ServicesListBox.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 99);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 69;
            label7.Text = "Cantidad";
            // 
            // numCantidad
            // 
            numCantidad.Dock = DockStyle.Fill;
            numCantidad.Location = new Point(143, 102);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(414, 27);
            numCantidad.TabIndex = 70;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Dock = DockStyle.Fill;
            numCosto.Location = new Point(143, 69);
            numCosto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(414, 27);
            numCosto.TabIndex = 71;
            // 
            // Paquetes
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Paquetes";
            Text = "Paquetes";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TextBox txtPackageDescription;
        private Label label1;
        private TextBox txtPackageName;
        private Label label2;
        private Button btnFiltlerPackage;
        private Button btnDeletePackage;
        private Button btnUpdatePackage;
        private Button btnRegisterPackage;
        private Label label4;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvPackages;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBoxDisponibilidad;
        private Label label5;
        private Label label6;
        private ListBox ServicesListBox;
        private Label label7;
        private NumericUpDown numCantidad;
        private NumericUpDown numCosto;
    }
}