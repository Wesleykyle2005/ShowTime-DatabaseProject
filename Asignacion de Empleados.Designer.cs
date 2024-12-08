namespace ShowTime_DatabseProject
{
    partial class Asignacion_de_Empleados
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            comboBoxRol = new ComboBox();
            comboBoxEmpleado = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvEventos = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            Registerrol = new Button();
            btnClose = new Button();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = Color.White;
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.ItemHeight = 20;
            comboBoxRol.Location = new Point(280, 66);
            comboBoxRol.Margin = new Padding(0);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(280, 28);
            comboBoxRol.TabIndex = 6;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.BackColor = Color.White;
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FlatStyle = FlatStyle.Flat;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.ItemHeight = 20;
            comboBoxEmpleado.Location = new Point(280, 0);
            comboBoxEmpleado.Margin = new Padding(0);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(280, 28);
            comboBoxEmpleado.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(157, 129, 137);
            label2.Location = new Point(143, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 67;
            label2.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(157, 129, 137);
            label3.Location = new Point(143, 66);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 68;
            label3.Text = "Rol";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(157, 129, 137);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvEventos, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(700, 500);
            tableLayoutPanel1.TabIndex = 75;
            // 
            // dgvEventos
            // 
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.AllowUserToResizeColumns = false;
            dgvEventos.AllowUserToResizeRows = false;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventos.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvEventos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle4.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle5.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvEventos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvEventos.EnableHeadersVisualStyles = false;
            dgvEventos.GridColor = Color.Black;
            dgvEventos.Location = new Point(0, 250);
            dgvEventos.Margin = new Padding(0);
            dgvEventos.MultiSelect = false;
            dgvEventos.Name = "dgvEventos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle6.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEventos.ScrollBars = ScrollBars.Vertical;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.ShowCellErrors = false;
            dgvEventos.ShowRowErrors = false;
            dgvEventos.Size = new Size(700, 250);
            dgvEventos.TabIndex = 76;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(157, 129, 137);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(comboBoxEmpleado, 3, 0);
            tableLayoutPanel2.Controls.Add(comboBoxRol, 3, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 1);
            tableLayoutPanel2.Controls.Add(Registerrol, 3, 2);
            tableLayoutPanel2.Controls.Add(btnClose, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 77;
            // 
            // Registerrol
            // 
            Registerrol.BackColor = Color.FromArgb(157, 129, 137);
            Registerrol.Dock = DockStyle.Fill;
            Registerrol.FlatAppearance.BorderSize = 0;
            Registerrol.FlatStyle = FlatStyle.Flat;
            Registerrol.Location = new Point(283, 135);
            Registerrol.Name = "Registerrol";
            Registerrol.Size = new Size(274, 62);
            Registerrol.TabIndex = 69;
            Registerrol.Text = "Registrar";
            Registerrol.UseVisualStyleBackColor = false;
            Registerrol.Click += Registerrol_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(157, 129, 137);
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(143, 135);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 62);
            btnClose.TabIndex = 70;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(694, 50);
            label4.TabIndex = 78;
            label4.Text = "Administrar empleados por evento";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Asignacion_de_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 129, 137);
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Asignacion_de_Empleados";
            Text = "Asignacion_de_Empleados";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxRol;
        private ComboBox comboBoxEmpleado;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvEventos;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Button Registerrol;
        private Button btnClose;
    }
}