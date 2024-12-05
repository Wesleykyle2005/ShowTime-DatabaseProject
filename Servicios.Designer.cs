namespace ShowTime_DatabseProject
{
    partial class Servicios
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnUpdateService = new Button();
            btnRegisterService = new Button();
            label2 = new Label();
            txtServiceCost = new TextBox();
            label3 = new Label();
            txtServiceDescription = new TextBox();
            label1 = new Label();
            txtServiceName = new TextBox();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvServices = new DataGridView();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            UtileriaList = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateService
            // 
            btnUpdateService.FlatAppearance.BorderSize = 0;
            btnUpdateService.FlatStyle = FlatStyle.Flat;
            btnUpdateService.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdateService.Location = new Point(564, 54);
            btnUpdateService.Margin = new Padding(4);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(132, 41);
            btnUpdateService.TabIndex = 57;
            btnUpdateService.Text = "Actualizar Servicio";
            btnUpdateService.UseVisualStyleBackColor = true;
            btnUpdateService.Click += btnUpdateService_Click;
            // 
            // btnRegisterService
            // 
            btnRegisterService.FlatAppearance.BorderSize = 0;
            btnRegisterService.FlatStyle = FlatStyle.Flat;
            btnRegisterService.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRegisterService.Location = new Point(564, 4);
            btnRegisterService.Margin = new Padding(4);
            btnRegisterService.Name = "btnRegisterService";
            btnRegisterService.Size = new Size(132, 41);
            btnRegisterService.TabIndex = 56;
            btnRegisterService.Text = "Registrar Servicio";
            btnRegisterService.UseVisualStyleBackColor = true;
            btnRegisterService.Click += btnRegisterService_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 54;
            label2.Text = "Costo";
            // 
            // txtServiceCost
            // 
            txtServiceCost.Dock = DockStyle.Fill;
            txtServiceCost.Location = new Point(144, 104);
            txtServiceCost.Margin = new Padding(4);
            txtServiceCost.Multiline = true;
            txtServiceCost.Name = "txtServiceCost";
            txtServiceCost.Size = new Size(412, 42);
            txtServiceCost.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 51;
            label3.Text = "Descripcion";
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Dock = DockStyle.Fill;
            txtServiceDescription.Location = new Point(144, 54);
            txtServiceDescription.Margin = new Padding(4);
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(412, 42);
            txtServiceDescription.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 49;
            label1.Text = "Nombre";
            // 
            // txtServiceName
            // 
            txtServiceName.Dock = DockStyle.Fill;
            txtServiceName.Location = new Point(144, 4);
            txtServiceName.Margin = new Padding(4);
            txtServiceName.Multiline = true;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(412, 42);
            txtServiceName.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 42);
            label4.TabIndex = 62;
            label4.Text = "Utileria neceasaria";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvServices, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(700, 500);
            tableLayoutPanel1.TabIndex = 64;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvServices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle10.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle11.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle11;
            dgvServices.Dock = DockStyle.Fill;
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.GridColor = Color.Black;
            dgvServices.Location = new Point(0, 250);
            dgvServices.Margin = new Padding(0);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle12.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvServices.RowHeadersVisible = false;
            dgvServices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvServices.ScrollBars = ScrollBars.Vertical;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.ShowCellErrors = false;
            dgvServices.ShowRowErrors = false;
            dgvServices.Size = new Size(700, 250);
            dgvServices.TabIndex = 73;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(692, 50);
            label5.TabIndex = 62;
            label5.Text = "Administrar servicios";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtServiceName, 1, 0);
            tableLayoutPanel2.Controls.Add(btnUpdateService, 2, 1);
            tableLayoutPanel2.Controls.Add(txtServiceCost, 1, 2);
            tableLayoutPanel2.Controls.Add(btnRegisterService, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(txtServiceDescription, 1, 1);
            tableLayoutPanel2.Controls.Add(UtileriaList, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 61;
            // 
            // UtileriaList
            // 
            UtileriaList.BorderStyle = BorderStyle.None;
            UtileriaList.Dock = DockStyle.Top;
            UtileriaList.FormattingEnabled = true;
            UtileriaList.ItemHeight = 20;
            UtileriaList.Items.AddRange(new object[] { "as", "as", "as", "as", "as", "as", "as", "as" });
            UtileriaList.Location = new Point(143, 153);
            UtileriaList.Name = "UtileriaList";
            UtileriaList.SelectionMode = SelectionMode.MultiSimple;
            UtileriaList.Size = new Size(414, 40);
            UtileriaList.TabIndex = 63;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Servicios";
            Text = "Servicios";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnFiltlerService;
        private Button btnDeleteService;
        private Button btnUpdateService;
        private Button btnRegisterService;
        private Label label2;
        private TextBox txtServiceCost;
        private Label label3;
        private TextBox txtServiceDescription;
        private Label label1;
        private TextBox txtServiceName;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private DataGridView dgvServices;
        private ListBox UtileriaList;
    }
}