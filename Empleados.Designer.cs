﻿namespace ShowTime_DatabseProject
{
    partial class Empleados
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
            btnRegisterEmployee = new Button();
            label4 = new Label();
            txtEmployeeEmail = new TextBox();
            label3 = new Label();
            txtEmployeeNumber = new TextBox();
            label2 = new Label();
            txtEmployeeLastName = new TextBox();
            label1 = new Label();
            TxtEmployeeName = new TextBox();
            btnUpdateEmployee = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            dgvEmployees = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterEmployee
            // 
            btnRegisterEmployee.Dock = DockStyle.Fill;
            btnRegisterEmployee.FlatAppearance.BorderSize = 0;
            btnRegisterEmployee.FlatStyle = FlatStyle.Flat;
            btnRegisterEmployee.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRegisterEmployee.Location = new Point(39, 4);
            btnRegisterEmployee.Margin = new Padding(4);
            btnRegisterEmployee.Name = "btnRegisterEmployee";
            btnRegisterEmployee.Size = new Size(237, 27);
            btnRegisterEmployee.TabIndex = 28;
            btnRegisterEmployee.Text = "Registrar Empelado";
            btnRegisterEmployee.UseVisualStyleBackColor = true;
            btnRegisterEmployee.Click += btnRegisterEmployee_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 99);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 33);
            label4.TabIndex = 26;
            label4.Text = "Correo electronico";
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.BorderStyle = BorderStyle.None;
            txtEmployeeEmail.Dock = DockStyle.Fill;
            txtEmployeeEmail.ForeColor = Color.Black;
            txtEmployeeEmail.Location = new Point(179, 103);
            txtEmployeeEmail.Margin = new Padding(4);
            txtEmployeeEmail.Multiline = true;
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(167, 25);
            txtEmployeeEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 24;
            label3.Text = "Numero";
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.BorderStyle = BorderStyle.None;
            txtEmployeeNumber.Dock = DockStyle.Fill;
            txtEmployeeNumber.ForeColor = Color.Black;
            txtEmployeeNumber.Location = new Point(179, 70);
            txtEmployeeNumber.Margin = new Padding(4);
            txtEmployeeNumber.Multiline = true;
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(167, 25);
            txtEmployeeNumber.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.BorderStyle = BorderStyle.None;
            txtEmployeeLastName.Dock = DockStyle.Fill;
            txtEmployeeLastName.ForeColor = Color.Black;
            txtEmployeeLastName.Location = new Point(179, 37);
            txtEmployeeLastName.Margin = new Padding(4);
            txtEmployeeLastName.Multiline = true;
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(167, 25);
            txtEmployeeLastName.TabIndex = 21;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(692, 50);
            label1.TabIndex = 20;
            label1.Text = "Administrar empleados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtEmployeeName
            // 
            TxtEmployeeName.BorderStyle = BorderStyle.None;
            TxtEmployeeName.ForeColor = Color.Black;
            TxtEmployeeName.Location = new Point(179, 4);
            TxtEmployeeName.Margin = new Padding(4);
            TxtEmployeeName.Multiline = true;
            TxtEmployeeName.Name = "TxtEmployeeName";
            TxtEmployeeName.Size = new Size(167, 25);
            TxtEmployeeName.TabIndex = 19;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Dock = DockStyle.Fill;
            btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            btnUpdateEmployee.FlatStyle = FlatStyle.Flat;
            btnUpdateEmployee.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdateEmployee.Location = new Point(39, 114);
            btnUpdateEmployee.Margin = new Padding(4);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(237, 27);
            btnUpdateEmployee.TabIndex = 32;
            btnUpdateEmployee.Text = "Actualizar Empelado";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(179, 169);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(167, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Dock = DockStyle.Fill;
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(179, 136);
            txtUser.Margin = new Padding(4);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(167, 25);
            txtUser.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 30;
            label7.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 132);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 28;
            label6.Text = "Usuario";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvEmployees, 0, 2);
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
            tableLayoutPanel1.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 267F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 267F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 200);
            panel2.TabIndex = 35;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btnRegisterEmployee, 1, 0);
            tableLayoutPanel4.Controls.Add(btnUpdateEmployee, 1, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.Size = new Size(350, 200);
            tableLayoutPanel4.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 200);
            panel1.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(txtPassword, 1, 5);
            tableLayoutPanel3.Controls.Add(txtUser, 1, 4);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtEmployeeEmail, 1, 3);
            tableLayoutPanel3.Controls.Add(label7, 0, 5);
            tableLayoutPanel3.Controls.Add(txtEmployeeNumber, 1, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtEmployeeLastName, 1, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 4);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(TxtEmployeeName, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(350, 200);
            tableLayoutPanel3.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 74;
            label5.Text = "Nombres";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.Black;
            dgvEmployees.Location = new Point(0, 250);
            dgvEmployees.Margin = new Padding(0);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.ShowCellErrors = false;
            dgvEmployees.ShowRowErrors = false;
            dgvEmployees.Size = new Size(700, 250);
            dgvEmployees.TabIndex = 73;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Empleados";
            Text = "Empleados";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterEmployee;
        private Label label4;
        private TextBox txtEmployeeEmail;
        private Label label3;
        private TextBox txtEmployeeNumber;
        private Label label2;
        private TextBox txtEmployeeLastName;
        private Label label1;
        private TextBox TxtEmployeeName;
        private Button btnUpdateEmployee;
        private TextBox txtUser;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvEmployees;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
    }
}