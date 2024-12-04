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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvRolesEmpleados = new DataGridView();
            label10 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            registerEvent = new FontAwesome.Sharp.IconButton();
            editEvent = new FontAwesome.Sharp.IconButton();
            payEvent = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolesEmpleados).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(dgvRolesEmpleados, 0, 2);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle10.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvRolesEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvRolesEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle11.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvRolesEmpleados.DefaultCellStyle = dataGridViewCellStyle11;
            dgvRolesEmpleados.Dock = DockStyle.Fill;
            dgvRolesEmpleados.EnableHeadersVisualStyles = false;
            dgvRolesEmpleados.GridColor = Color.Black;
            dgvRolesEmpleados.Location = new Point(0, 250);
            dgvRolesEmpleados.Margin = new Padding(0);
            dgvRolesEmpleados.MultiSelect = false;
            dgvRolesEmpleados.Name = "dgvRolesEmpleados";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 202, 212);
            dataGridViewCellStyle12.Font = new Font("Courier New", 13F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(10, 180, 180, 180);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvRolesEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvRolesEmpleados.RowHeadersVisible = false;
            dgvRolesEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRolesEmpleados.ScrollBars = ScrollBars.Vertical;
            dgvRolesEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRolesEmpleados.ShowCellErrors = false;
            dgvRolesEmpleados.ShowRowErrors = false;
            dgvRolesEmpleados.Size = new Size(700, 250);
            dgvRolesEmpleados.TabIndex = 77;
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
            tableLayoutPanel2.Controls.Add(editEvent, 3, 1);
            tableLayoutPanel2.Controls.Add(payEvent, 5, 1);
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
            // editEvent
            // 
            editEvent.Dock = DockStyle.Fill;
            editEvent.FlatAppearance.BorderSize = 0;
            editEvent.FlatStyle = FlatStyle.Flat;
            editEvent.Font = new Font("Courier New", 13F, FontStyle.Bold);
            editEvent.IconChar = FontAwesome.Sharp.IconChar.None;
            editEvent.IconColor = Color.Black;
            editEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editEvent.Location = new Point(284, 44);
            editEvent.Margin = new Padding(4);
            editEvent.Name = "editEvent";
            editEvent.Size = new Size(132, 112);
            editEvent.TabIndex = 1;
            editEvent.Text = "Editar evento";
            editEvent.UseVisualStyleBackColor = true;
            editEvent.Click += editEvent_Click;
            // 
            // payEvent
            // 
            payEvent.Dock = DockStyle.Fill;
            payEvent.FlatAppearance.BorderSize = 0;
            payEvent.FlatStyle = FlatStyle.Flat;
            payEvent.Font = new Font("Courier New", 13F, FontStyle.Bold);
            payEvent.IconChar = FontAwesome.Sharp.IconChar.None;
            payEvent.IconColor = Color.Black;
            payEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            payEvent.Location = new Point(494, 44);
            payEvent.Margin = new Padding(4);
            payEvent.Name = "payEvent";
            payEvent.Size = new Size(132, 112);
            payEvent.TabIndex = 2;
            payEvent.Text = "Registrar pagos de eventos";
            payEvent.UseVisualStyleBackColor = true;
            payEvent.Click += payEvent_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgvRolesEmpleados).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvRolesEmpleados;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton registerEvent;
        private FontAwesome.Sharp.IconButton editEvent;
        private FontAwesome.Sharp.IconButton payEvent;
    }
}