namespace ShowTime_DatabseProject
{
    partial class Clientes
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
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label2 = new Label();
            txtClienteEmail = new TextBox();
            label3 = new Label();
            txtClienteLastName = new TextBox();
            label4 = new Label();
            TxtClienteName = new TextBox();
            numTelefono = new MaskedTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnRegisterCliente = new Button();
            btnUpdateCliente = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvClientes = new DataGridView();
            label1 = new Label();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtClienteEmail, 1, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtClienteLastName, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(TxtClienteName, 1, 0);
            tableLayoutPanel3.Controls.Add(numTelefono, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.Size = new Size(350, 250);
            tableLayoutPanel3.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 74;
            label5.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.BorderStyle = BorderStyle.None;
            txtClienteEmail.Dock = DockStyle.Fill;
            txtClienteEmail.ForeColor = Color.Black;
            txtClienteEmail.Location = new Point(181, 191);
            txtClienteEmail.Margin = new Padding(6, 5, 6, 5);
            txtClienteEmail.Multiline = true;
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.Size = new Size(163, 54);
            txtClienteEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 24;
            label3.Text = "Numero";
            // 
            // txtClienteLastName
            // 
            txtClienteLastName.BorderStyle = BorderStyle.None;
            txtClienteLastName.Dock = DockStyle.Fill;
            txtClienteLastName.ForeColor = Color.Black;
            txtClienteLastName.Location = new Point(181, 67);
            txtClienteLastName.Margin = new Padding(6, 5, 6, 5);
            txtClienteLastName.Multiline = true;
            txtClienteLastName.Name = "txtClienteLastName";
            txtClienteLastName.Size = new Size(163, 52);
            txtClienteLastName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 186);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 42);
            label4.TabIndex = 26;
            label4.Text = "Correo electronico";
            // 
            // TxtClienteName
            // 
            TxtClienteName.BorderStyle = BorderStyle.None;
            TxtClienteName.Dock = DockStyle.Fill;
            TxtClienteName.ForeColor = Color.Black;
            TxtClienteName.Location = new Point(181, 5);
            TxtClienteName.Margin = new Padding(6, 5, 6, 5);
            TxtClienteName.Multiline = true;
            TxtClienteName.Name = "TxtClienteName";
            TxtClienteName.Size = new Size(163, 52);
            TxtClienteName.TabIndex = 19;
            // 
            // numTelefono
            // 
            numTelefono.Dock = DockStyle.Fill;
            numTelefono.Location = new Point(179, 128);
            numTelefono.Margin = new Padding(4);
            numTelefono.Mask = "99999999";
            numTelefono.Name = "numTelefono";
            numTelefono.Size = new Size(167, 27);
            numTelefono.TabIndex = 77;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 250);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 250);
            panel2.TabIndex = 35;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btnRegisterCliente, 1, 0);
            tableLayoutPanel4.Controls.Add(btnUpdateCliente, 1, 2);
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
            tableLayoutPanel4.Size = new Size(350, 250);
            tableLayoutPanel4.TabIndex = 37;
            // 
            // btnRegisterCliente
            // 
            btnRegisterCliente.Dock = DockStyle.Fill;
            btnRegisterCliente.FlatAppearance.BorderSize = 0;
            btnRegisterCliente.FlatStyle = FlatStyle.Flat;
            btnRegisterCliente.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRegisterCliente.Location = new Point(41, 5);
            btnRegisterCliente.Margin = new Padding(6, 5, 6, 5);
            btnRegisterCliente.Name = "btnRegisterCliente";
            btnRegisterCliente.Size = new Size(233, 33);
            btnRegisterCliente.TabIndex = 28;
            btnRegisterCliente.Text = "Registrar Cliente";
            btnRegisterCliente.UseVisualStyleBackColor = true;
            btnRegisterCliente.Click += btnRegisterCliente_Click;
            // 
            // btnUpdateCliente
            // 
            btnUpdateCliente.Dock = DockStyle.Fill;
            btnUpdateCliente.FlatAppearance.BorderSize = 0;
            btnUpdateCliente.FlatStyle = FlatStyle.Flat;
            btnUpdateCliente.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnUpdateCliente.Location = new Point(41, 73);
            btnUpdateCliente.Margin = new Padding(6, 5, 6, 5);
            btnUpdateCliente.Name = "btnUpdateCliente";
            btnUpdateCliente.Size = new Size(233, 33);
            btnUpdateCliente.TabIndex = 32;
            btnUpdateCliente.Text = "Actualizar Cliente";
            btnUpdateCliente.UseVisualStyleBackColor = true;
            btnUpdateCliente.Click += btnUpdateCliente_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 25);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel2.Size = new Size(700, 250);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvClientes, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(700, 500);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(255, 202, 212);
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(0, 275);
            dgvClientes.Margin = new Padding(0);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.ShowCellErrors = false;
            dgvClientes.ShowRowErrors = false;
            dgvClientes.Size = new Size(700, 225);
            dgvClientes.TabIndex = 73;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(6, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(688, 25);
            label1.TabIndex = 20;
            label1.Text = "Administrar clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Clientes";
            Text = "Clientes";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label2;
        private TextBox txtClienteEmail;
        private Label label3;
        private TextBox txtClienteLastName;
        private Label label4;
        private TextBox TxtClienteName;
        private MaskedTextBox numTelefono;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnRegisterCliente;
        private Button btnUpdateCliente;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvClientes;
        private Label label1;
    }
}