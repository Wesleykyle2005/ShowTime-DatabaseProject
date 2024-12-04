namespace ShowTime_DatabseProject
{
    partial class Utileria
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
            dgvUtileria = new DataGridView();
            btnUpdateUtileria = new Button();
            btnRegisterProp = new Button();
            label2 = new Label();
            txtPropQuantity = new TextBox();
            label1 = new Label();
            txtPropName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUtileria).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUtileria
            // 
            dgvUtileria.AllowUserToAddRows = false;
            dgvUtileria.AllowUserToDeleteRows = false;
            dgvUtileria.AllowUserToResizeColumns = false;
            dgvUtileria.AllowUserToResizeRows = false;
            dgvUtileria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtileria.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvUtileria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUtileria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUtileria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUtileria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUtileria.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUtileria.Dock = DockStyle.Fill;
            dgvUtileria.EnableHeadersVisualStyles = false;
            dgvUtileria.GridColor = Color.Black;
            dgvUtileria.Location = new Point(0, 250);
            dgvUtileria.Margin = new Padding(0);
            dgvUtileria.MultiSelect = false;
            dgvUtileria.Name = "dgvUtileria";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUtileria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUtileria.RowHeadersVisible = false;
            dgvUtileria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUtileria.ScrollBars = ScrollBars.Vertical;
            dgvUtileria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtileria.ShowCellErrors = false;
            dgvUtileria.ShowRowErrors = false;
            dgvUtileria.Size = new Size(900, 250);
            dgvUtileria.TabIndex = 72;
            dgvUtileria.CellClick += dgvUtileria_CellClick;
            // 
            // btnUpdateUtileria
            // 
            btnUpdateUtileria.FlatAppearance.BorderSize = 0;
            btnUpdateUtileria.FlatStyle = FlatStyle.Flat;
            btnUpdateUtileria.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdateUtileria.Location = new Point(251, 65);
            btnUpdateUtileria.Margin = new Padding(4);
            btnUpdateUtileria.Name = "btnUpdateUtileria";
            btnUpdateUtileria.Size = new Size(149, 31);
            btnUpdateUtileria.TabIndex = 69;
            btnUpdateUtileria.Text = "Actualizar Utileria";
            btnUpdateUtileria.UseVisualStyleBackColor = true;
            btnUpdateUtileria.Click += btnUpdateService_Click;
            // 
            // btnRegisterProp
            // 
            btnRegisterProp.FlatAppearance.BorderSize = 0;
            btnRegisterProp.FlatStyle = FlatStyle.Flat;
            btnRegisterProp.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRegisterProp.Location = new Point(49, 65);
            btnRegisterProp.Margin = new Padding(4);
            btnRegisterProp.Name = "btnRegisterProp";
            btnRegisterProp.Size = new Size(149, 31);
            btnRegisterProp.TabIndex = 68;
            btnRegisterProp.Text = "Registrar Utileria";
            btnRegisterProp.UseVisualStyleBackColor = true;
            btnRegisterProp.Click += btnRegisterProp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(4, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 56);
            label2.TabIndex = 67;
            label2.Text = "Cantidad";
            // 
            // txtPropQuantity
            // 
            txtPropQuantity.Dock = DockStyle.Top;
            txtPropQuantity.Location = new Point(135, 56);
            txtPropQuantity.Margin = new Padding(0);
            txtPropQuantity.Name = "txtPropQuantity";
            txtPropQuantity.Size = new Size(315, 27);
            txtPropQuantity.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 56);
            label1.TabIndex = 62;
            label1.Text = "Nombre";
            // 
            // txtPropName
            // 
            txtPropName.Dock = DockStyle.Top;
            txtPropName.Location = new Point(135, 0);
            txtPropName.Margin = new Padding(0);
            txtPropName.Name = "txtPropName";
            txtPropName.Size = new Size(315, 27);
            txtPropName.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvUtileria, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(900, 500);
            tableLayoutPanel1.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 250);
            panel1.TabIndex = 73;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(900, 250);
            tableLayoutPanel2.TabIndex = 74;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Location = new Point(225, 25);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 225);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(450, 225);
            tableLayoutPanel3.TabIndex = 74;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Controls.Add(btnRegisterProp, 1, 3);
            tableLayoutPanel4.Controls.Add(btnUpdateUtileria, 3, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 112);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(450, 113);
            tableLayoutPanel4.TabIndex = 74;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 112);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(txtPropQuantity, 1, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(txtPropName, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(450, 112);
            tableLayoutPanel5.TabIndex = 68;
            // 
            // label3
            // 
            label3.Location = new Point(229, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(442, 25);
            label3.TabIndex = 1;
            label3.Text = "Administrar utileria";
            // 
            // Utileria
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(900, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Utileria";
            Text = "Utileria";
            ((System.ComponentModel.ISupportInitialize)dgvUtileria).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUtileria;
        private Button btnUpdateUtileria;
        private Button btnRegisterProp;
        private Label label2;
        private TextBox txtPropQuantity;
        private Label label1;
        private TextBox txtPropName;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
    }
}