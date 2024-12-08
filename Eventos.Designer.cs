namespace ShowTime_DatabseProject
{
    partial class Eventos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvEventos = new DataGridView();
            label10 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            registerEvent = new FontAwesome.Sharp.IconButton();
            btnAsignarEmpleado = new FontAwesome.Sharp.IconButton();
            btnRealizarPago = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(dgvEventos, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
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
            tableLayoutPanel1.TabIndex = 79;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle1.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle2.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEventos.Dock = DockStyle.Fill;
            dgvEventos.EnableHeadersVisualStyles = false;
            dgvEventos.GridColor = Color.Black;
            dgvEventos.Location = new Point(0, 250);
            dgvEventos.Margin = new Padding(0);
            dgvEventos.MultiSelect = false;
            dgvEventos.Name = "dgvEventos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle3.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEventos.ScrollBars = ScrollBars.Vertical;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.ShowCellErrors = false;
            dgvEventos.ShowRowErrors = false;
            dgvEventos.Size = new Size(700, 250);
            dgvEventos.TabIndex = 77;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(4, 0);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(692, 50);
            label10.TabIndex = 78;
            label10.Text = "Administrar eventos";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(registerEvent, 1, 1);
            tableLayoutPanel2.Controls.Add(btnAsignarEmpleado, 3, 1);
            tableLayoutPanel2.Controls.Add(btnRealizarPago, 5, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(700, 200);
            tableLayoutPanel2.TabIndex = 79;
            // 
            // registerEvent
            // 
            registerEvent.Dock = DockStyle.Fill;
            registerEvent.FlatAppearance.BorderSize = 0;
            registerEvent.FlatStyle = FlatStyle.Flat;
            registerEvent.Font = new Font("Courier New", 13F, FontStyle.Bold);
            registerEvent.IconChar = FontAwesome.Sharp.IconChar.None;
            registerEvent.IconColor = Color.Black;
            registerEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            registerEvent.Location = new Point(74, 44);
            registerEvent.Margin = new Padding(4);
            registerEvent.Name = "registerEvent";
            registerEvent.Size = new Size(132, 112);
            registerEvent.TabIndex = 0;
            registerEvent.Text = "Registrar evento";
            registerEvent.UseVisualStyleBackColor = true;
            registerEvent.Click += registerEvent_Click;
            // 
            // btnAsignarEmpleado
            // 
            btnAsignarEmpleado.Dock = DockStyle.Fill;
            btnAsignarEmpleado.FlatAppearance.BorderSize = 0;
            btnAsignarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAsignarEmpleado.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnAsignarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAsignarEmpleado.IconColor = Color.Black;
            btnAsignarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsignarEmpleado.Location = new Point(284, 44);
            btnAsignarEmpleado.Margin = new Padding(4);
            btnAsignarEmpleado.Name = "btnAsignarEmpleado";
            btnAsignarEmpleado.Size = new Size(132, 112);
            btnAsignarEmpleado.TabIndex = 1;
            btnAsignarEmpleado.Text = "Asignar empleados";
            btnAsignarEmpleado.UseVisualStyleBackColor = true;
            btnAsignarEmpleado.Click += editEvent_Click;
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Dock = DockStyle.Fill;
            btnRealizarPago.FlatAppearance.BorderSize = 0;
            btnRealizarPago.FlatStyle = FlatStyle.Flat;
            btnRealizarPago.Font = new Font("Courier New", 13F, FontStyle.Bold);
            btnRealizarPago.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRealizarPago.IconColor = Color.Black;
            btnRealizarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRealizarPago.Location = new Point(494, 44);
            btnRealizarPago.Margin = new Padding(4);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(132, 112);
            btnRealizarPago.TabIndex = 2;
            btnRealizarPago.Text = "Realizar pagos";
            btnRealizarPago.UseVisualStyleBackColor = true;
            btnRealizarPago.Click += btnRealizarPago_Click;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Eventos";
            Text = "Eventos";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvEventos;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton registerEvent;
        private FontAwesome.Sharp.IconButton btnAsignarEmpleado;
        private FontAwesome.Sharp.IconButton btnRealizarPago;
    }
}