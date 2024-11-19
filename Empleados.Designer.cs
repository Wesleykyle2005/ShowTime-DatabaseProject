namespace ShowTime_DatabseProject
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
            btnRegisterEmployee = new Button();
            label5 = new Label();
            label4 = new Label();
            txtEmployeeEmail = new TextBox();
            label3 = new Label();
            txtEmployeeNumber = new TextBox();
            label2 = new Label();
            txtEmployeeLastName = new TextBox();
            label1 = new Label();
            TxtEmployeeName = new TextBox();
            dgvEmployees = new DataGridView();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            groupBox1 = new GroupBox();
            btnFiltlerEmployee = new Button();
            label6 = new Label();
            cmbEmployeeStatus = new ComboBox();
            cmbEmployeeRole = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterEmployee
            // 
            btnRegisterEmployee.Location = new Point(377, 46);
            btnRegisterEmployee.Name = "btnRegisterEmployee";
            btnRegisterEmployee.Size = new Size(136, 31);
            btnRegisterEmployee.TabIndex = 28;
            btnRegisterEmployee.Text = "Registrar Empelado";
            btnRegisterEmployee.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 4);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 27;
            label5.Text = "Control de Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 26;
            label4.Text = "Correo electronico";
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Location = new Point(118, 103);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(233, 23);
            txtEmployeeEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 24;
            label3.Text = "Numero";
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.Location = new Point(68, 74);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(283, 23);
            txtEmployeeNumber.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(68, 45);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(283, 23);
            txtEmployeeLastName.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombres";
            // 
            // TxtEmployeeName
            // 
            TxtEmployeeName.Location = new Point(68, 16);
            TxtEmployeeName.Name = "TxtEmployeeName";
            TxtEmployeeName.Size = new Size(283, 23);
            TxtEmployeeName.TabIndex = 19;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.Location = new Point(0, 212);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(520, 273);
            dgvEmployees.TabIndex = 31;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(377, 120);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(136, 31);
            btnUpdateEmployee.TabIndex = 32;
            btnUpdateEmployee.Text = "Actualizar Empelado";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(377, 83);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(136, 31);
            btnDeleteEmployee.TabIndex = 33;
            btnDeleteEmployee.Text = "Eliminar Empelado";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbEmployeeRole);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbEmployeeStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmployeeEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmployeeNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmployeeLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtEmployeeName);
            groupBox1.Location = new Point(7, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 170);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnFiltlerEmployee
            // 
            btnFiltlerEmployee.Location = new Point(377, 157);
            btnFiltlerEmployee.Name = "btnFiltlerEmployee";
            btnFiltlerEmployee.Size = new Size(136, 31);
            btnFiltlerEmployee.TabIndex = 36;
            btnFiltlerEmployee.Text = "Filtrar Empelado";
            btnFiltlerEmployee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 139);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 29;
            label6.Text = "Estado";
            // 
            // cmbEmployeeStatus
            // 
            cmbEmployeeStatus.FormattingEnabled = true;
            cmbEmployeeStatus.Location = new Point(55, 134);
            cmbEmployeeStatus.Name = "cmbEmployeeStatus";
            cmbEmployeeStatus.Size = new Size(130, 23);
            cmbEmployeeStatus.TabIndex = 30;
            // 
            // cmbEmployeeRole
            // 
            cmbEmployeeRole.FormattingEnabled = true;
            cmbEmployeeRole.Location = new Point(230, 134);
            cmbEmployeeRole.Name = "cmbEmployeeRole";
            cmbEmployeeRole.Size = new Size(121, 23);
            cmbEmployeeRole.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 139);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 31;
            label7.Text = "Estado";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 485);
            Controls.Add(btnFiltlerEmployee);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(dgvEmployees);
            Controls.Add(btnRegisterEmployee);
            Controls.Add(label5);
            Name = "Empleados";
            Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterEmployee;
        private Label label5;
        private Label label4;
        private TextBox txtEmployeeEmail;
        private Label label3;
        private TextBox txtEmployeeNumber;
        private Label label2;
        private TextBox txtEmployeeLastName;
        private Label label1;
        private TextBox TxtEmployeeName;
        private DataGridView dgvEmployees;
        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private GroupBox groupBox1;
        private Button btnFiltlerEmployee;
        private ComboBox cmbEmployeeRole;
        private Label label7;
        private ComboBox cmbEmployeeStatus;
        private Label label6;
    }
}