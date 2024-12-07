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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            comboBoxRol = new ComboBox();
            comboBoxEmpleado = new ComboBox();
            comboBoxEvento = new ComboBox();
            label1 = new Label();
            Registerrol = new Button();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CierreSesion = new FontAwesome.Sharp.IconButton();
            dgvRolesEmpleados = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolesEmpleados).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = Color.White;
            comboBoxRol.Dock = DockStyle.Fill;
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(140, 132);
            comboBoxRol.Margin = new Padding(0);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(420, 28);
            comboBoxRol.TabIndex = 6;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.BackColor = Color.White;
            comboBoxEmpleado.Dock = DockStyle.Fill;
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FlatStyle = FlatStyle.Flat;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(140, 66);
            comboBoxEmpleado.Margin = new Padding(0);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(420, 28);
            comboBoxEmpleado.TabIndex = 5;
            // 
            // comboBoxEvento
            // 
            comboBoxEvento.BackColor = Color.White;
            comboBoxEvento.Dock = DockStyle.Fill;
            comboBoxEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEvento.FlatStyle = FlatStyle.Flat;
            comboBoxEvento.FormattingEnabled = true;
            comboBoxEvento.Location = new Point(140, 0);
            comboBoxEvento.Margin = new Padding(0);
            comboBoxEvento.Name = "comboBoxEvento";
            comboBoxEvento.Size = new Size(420, 28);
            comboBoxEvento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(157, 129, 137);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 62;
            label1.Text = "Evento";
            // 
            // Registerrol
            // 
            Registerrol.BackColor = Color.FromArgb(157, 129, 137);
            Registerrol.Dock = DockStyle.Fill;
            Registerrol.FlatAppearance.BorderSize = 0;
            Registerrol.FlatStyle = FlatStyle.Flat;
            Registerrol.Location = new Point(563, 3);
            Registerrol.Name = "Registerrol";
            Registerrol.Size = new Size(134, 60);
            Registerrol.TabIndex = 0;
            Registerrol.Text = "Registrar";
            Registerrol.UseVisualStyleBackColor = false;
            Registerrol.Click += Registerrol_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(157, 129, 137);
            label2.Location = new Point(3, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 67;
            label2.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(157, 129, 137);
            label3.Location = new Point(3, 132);
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
            tableLayoutPanel1.Controls.Add(CierreSesion, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvRolesEmpleados, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
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
            // CierreSesion
            // 
            CierreSesion.BackColor = Color.FromArgb(157, 129, 137);
            CierreSesion.Dock = DockStyle.Fill;
            CierreSesion.FlatAppearance.BorderSize = 0;
            CierreSesion.FlatStyle = FlatStyle.Flat;
            CierreSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            CierreSesion.IconColor = Color.Black;
            CierreSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CierreSesion.IconSize = 30;
            CierreSesion.ImageAlign = ContentAlignment.TopRight;
            CierreSesion.Location = new Point(0, 0);
            CierreSesion.Margin = new Padding(0);
            CierreSesion.Name = "CierreSesion";
            CierreSesion.Size = new Size(700, 50);
            CierreSesion.TabIndex = 78;
            CierreSesion.UseVisualStyleBackColor = false;
            CierreSesion.Click += CierreSesion_Click;
            // 
            // dgvRolesEmpleados
            // 
            dgvRolesEmpleados.AllowUserToAddRows = false;
            dgvRolesEmpleados.AllowUserToDeleteRows = false;
            dgvRolesEmpleados.AllowUserToResizeColumns = false;
            dgvRolesEmpleados.AllowUserToResizeRows = false;
            dgvRolesEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRolesEmpleados.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvRolesEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRolesEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRolesEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRolesEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRolesEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRolesEmpleados.EnableHeadersVisualStyles = false;
            dgvRolesEmpleados.GridColor = Color.Black;
            dgvRolesEmpleados.Location = new Point(0, 250);
            dgvRolesEmpleados.Margin = new Padding(0);
            dgvRolesEmpleados.MultiSelect = false;
            dgvRolesEmpleados.Name = "dgvRolesEmpleados";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRolesEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRolesEmpleados.RowHeadersVisible = false;
            dgvRolesEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRolesEmpleados.ScrollBars = ScrollBars.Vertical;
            dgvRolesEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRolesEmpleados.ShowCellErrors = false;
            dgvRolesEmpleados.ShowRowErrors = false;
            dgvRolesEmpleados.Size = new Size(700, 250);
            dgvRolesEmpleados.TabIndex = 76;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(157, 129, 137);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(comboBoxEvento, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBoxEmpleado, 1, 1);
            tableLayoutPanel2.Controls.Add(comboBoxRol, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(Registerrol, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
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
            ((System.ComponentModel.ISupportInitialize)dgvRolesEmpleados).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxRol;
        private ComboBox comboBoxEmpleado;
        private ComboBox comboBoxEvento;
        private Label label1;
        private Button Registerrol;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvRolesEmpleados;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton CierreSesion;
    }
}