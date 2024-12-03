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
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnFiltlerEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterEmployee
            // 
            btnRegisterEmployee.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnRegisterEmployee.Location = new Point(506, 61);
            btnRegisterEmployee.Name = "btnRegisterEmployee";
            btnRegisterEmployee.Size = new Size(159, 31);
            btnRegisterEmployee.TabIndex = 28;
            btnRegisterEmployee.Text = "Registrar Empelado";
            btnRegisterEmployee.UseVisualStyleBackColor = true;
            btnRegisterEmployee.Click += btnRegisterEmployee_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 9);
            label5.Name = "label5";
            label5.Size = new Size(218, 24);
            label5.TabIndex = 27;
            label5.Text = "Control de Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 114);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 26;
            label4.Text = "Correo electronico";
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Location = new Point(185, 111);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(200, 26);
            txtEmployeeEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 24;
            label3.Text = "Numero";
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.Location = new Point(185, 80);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(200, 26);
            txtEmployeeNumber.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(185, 51);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(200, 26);
            txtEmployeeLastName.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombres";
            // 
            // TxtEmployeeName
            // 
            TxtEmployeeName.Location = new Point(186, 19);
            TxtEmployeeName.Name = "TxtEmployeeName";
            TxtEmployeeName.Size = new Size(200, 26);
            TxtEmployeeName.TabIndex = 19;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.Location = new Point(0, 261);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(700, 239);
            dgvEmployees.TabIndex = 31;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnUpdateEmployee.Location = new Point(506, 135);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(159, 31);
            btnUpdateEmployee.TabIndex = 32;
            btnUpdateEmployee.Text = "Actualizar Empelado";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnDeleteEmployee.Location = new Point(506, 98);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(159, 31);
            btnDeleteEmployee.TabIndex = 33;
            btnDeleteEmployee.Text = "Eliminar Empelado";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmployeeEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmployeeNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmployeeLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtEmployeeName);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(40, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 211);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 26);
            txtPassword.TabIndex = 29;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(185, 140);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(200, 26);
            txtUser.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 173);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 30;
            label7.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 143);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 28;
            label6.Text = "Usuario";
            // 
            // btnFiltlerEmployee
            // 
            btnFiltlerEmployee.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnFiltlerEmployee.Location = new Point(506, 172);
            btnFiltlerEmployee.Name = "btnFiltlerEmployee";
            btnFiltlerEmployee.Size = new Size(159, 31);
            btnFiltlerEmployee.TabIndex = 36;
            btnFiltlerEmployee.Text = "Filtrar Empelado";
            btnFiltlerEmployee.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(btnFiltlerEmployee);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(dgvEmployees);
            Controls.Add(btnRegisterEmployee);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtUser;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
    }
}