namespace ShowTime_DatabseProject
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
            txtPackageCost = new TextBox();
            btnFiltlerPackage = new Button();
            btnDeletePackage = new Button();
            btnUpdatePackage = new Button();
            btnRegisterPackage = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPackages = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 34;
            label3.Text = "Descripcion";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Dock = DockStyle.Fill;
            txtPackageDescription.Location = new Point(144, 44);
            txtPackageDescription.Margin = new Padding(4);
            txtPackageDescription.Multiline = true;
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(412, 32);
            txtPackageDescription.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtPackageName
            // 
            txtPackageName.Dock = DockStyle.Fill;
            txtPackageName.Location = new Point(144, 4);
            txtPackageName.Margin = new Padding(4);
            txtPackageName.Multiline = true;
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(412, 32);
            txtPackageName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 40;
            label2.Text = "Costo";
            // 
            // txtPackageCost
            // 
            txtPackageCost.Dock = DockStyle.Fill;
            txtPackageCost.Location = new Point(144, 84);
            txtPackageCost.Margin = new Padding(4);
            txtPackageCost.Multiline = true;
            txtPackageCost.Name = "txtPackageCost";
            txtPackageCost.Size = new Size(412, 32);
            txtPackageCost.TabIndex = 39;
            // 
            // btnFiltlerPackage
            // 
            btnFiltlerPackage.Dock = DockStyle.Fill;
            btnFiltlerPackage.FlatAppearance.BorderSize = 0;
            btnFiltlerPackage.FlatStyle = FlatStyle.Flat;
            btnFiltlerPackage.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnFiltlerPackage.Location = new Point(564, 124);
            btnFiltlerPackage.Margin = new Padding(4);
            btnFiltlerPackage.Name = "btnFiltlerPackage";
            btnFiltlerPackage.Size = new Size(132, 32);
            btnFiltlerPackage.TabIndex = 46;
            btnFiltlerPackage.Text = "Filtrar Paquete";
            btnFiltlerPackage.UseVisualStyleBackColor = true;
            // 
            // btnDeletePackage
            // 
            btnDeletePackage.Dock = DockStyle.Fill;
            btnDeletePackage.FlatAppearance.BorderSize = 0;
            btnDeletePackage.FlatStyle = FlatStyle.Flat;
            btnDeletePackage.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnDeletePackage.Location = new Point(564, 84);
            btnDeletePackage.Margin = new Padding(4);
            btnDeletePackage.Name = "btnDeletePackage";
            btnDeletePackage.Size = new Size(132, 32);
            btnDeletePackage.TabIndex = 45;
            btnDeletePackage.Text = "Eliminar Paquete";
            btnDeletePackage.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePackage
            // 
            btnUpdatePackage.Dock = DockStyle.Fill;
            btnUpdatePackage.FlatAppearance.BorderSize = 0;
            btnUpdatePackage.FlatStyle = FlatStyle.Flat;
            btnUpdatePackage.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdatePackage.Location = new Point(564, 44);
            btnUpdatePackage.Margin = new Padding(4);
            btnUpdatePackage.Name = "btnUpdatePackage";
            btnUpdatePackage.Size = new Size(132, 32);
            btnUpdatePackage.TabIndex = 44;
            btnUpdatePackage.Text = "Actualizar Paquete";
            btnUpdatePackage.UseVisualStyleBackColor = true;
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
            btnRegisterPackage.Size = new Size(132, 32);
            btnRegisterPackage.TabIndex = 43;
            btnRegisterPackage.Text = "Registrar Paquete";
            btnRegisterPackage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 40);
            label4.TabIndex = 63;
            label4.Text = "Servicios incluidos";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 124);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 28);
            comboBox1.TabIndex = 64;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 229, 217);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(dgvPackages, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(700, 500);
            tableLayoutPanel1.TabIndex = 66;
            // 
            // dgvPackages
            // 
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.AllowUserToDeleteRows = false;
            dgvPackages.AllowUserToResizeColumns = false;
            dgvPackages.AllowUserToResizeRows = false;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dgvPackages.ScrollBars = ScrollBars.Vertical;
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
            tableLayoutPanel2.Controls.Add(comboBox2, 1, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnFiltlerPackage, 2, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(btnDeletePackage, 2, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(btnUpdatePackage, 2, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(btnRegisterPackage, 2, 0);
            tableLayoutPanel2.Controls.Add(txtPackageName, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPackageDescription, 1, 1);
            tableLayoutPanel2.Controls.Add(txtPackageCost, 1, 2);
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 75;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 164);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(412, 28);
            comboBox2.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 160);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 40);
            label5.TabIndex = 65;
            label5.Text = "Disponibilidad";
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
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TextBox txtPackageDescription;
        private Label label1;
        private TextBox txtPackageName;
        private Label label2;
        private TextBox txtPackageCost;
        private Button btnFiltlerPackage;
        private Button btnDeletePackage;
        private Button btnUpdatePackage;
        private Button btnRegisterPackage;
        private Label label4;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvPackages;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox2;
        private Label label5;
    }
}