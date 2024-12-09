namespace ShowTime_DatabseProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebarPanel = new TableLayoutPanel();
            dashboardButton = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            empleadoButton = new FontAwesome.Sharp.IconButton();
            paqueteButton = new FontAwesome.Sharp.IconButton();
            serviceButton = new FontAwesome.Sharp.IconButton();
            utileriaButton = new FontAwesome.Sharp.IconButton();
            eventButton = new FontAwesome.Sharp.IconButton();
            principalPanel = new TableLayoutPanel();
            PanelForm = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            UserLabel = new Label();
            CierreSesion = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            principalPanel.SuspendLayout();
            PanelForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(216, 226, 220);
            sidebarPanel.ColumnCount = 2;
            sidebarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            sidebarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            sidebarPanel.Controls.Add(dashboardButton, 1, 2);
            sidebarPanel.Controls.Add(pictureBox1, 1, 0);
            sidebarPanel.Controls.Add(empleadoButton, 1, 12);
            sidebarPanel.Controls.Add(paqueteButton, 1, 10);
            sidebarPanel.Controls.Add(serviceButton, 1, 8);
            sidebarPanel.Controls.Add(utileriaButton, 1, 6);
            sidebarPanel.Controls.Add(eventButton, 1, 4);
            sidebarPanel.Controls.Add(btnClientes, 1, 14);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.RowCount = 18;
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            sidebarPanel.Size = new Size(200, 500);
            sidebarPanel.TabIndex = 1;
            // 
            // dashboardButton
            // 
            dashboardButton.Dock = DockStyle.Fill;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Courier New", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.FromArgb(18, 29, 36);
            dashboardButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            dashboardButton.IconColor = Color.Black;
            dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            dashboardButton.IconSize = 24;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(23, 102);
            dashboardButton.Margin = new Padding(3, 2, 3, 2);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(174, 36);
            dashboardButton.TabIndex = 2;
            dashboardButton.Text = "  Inicio";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // empleadoButton
            // 
            empleadoButton.Dock = DockStyle.Fill;
            empleadoButton.FlatAppearance.BorderSize = 0;
            empleadoButton.FlatStyle = FlatStyle.Flat;
            empleadoButton.Font = new Font("Courier New", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empleadoButton.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            empleadoButton.IconColor = Color.Black;
            empleadoButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            empleadoButton.IconSize = 24;
            empleadoButton.ImageAlign = ContentAlignment.MiddleLeft;
            empleadoButton.Location = new Point(23, 352);
            empleadoButton.Margin = new Padding(3, 2, 3, 2);
            empleadoButton.Name = "empleadoButton";
            empleadoButton.Size = new Size(174, 36);
            empleadoButton.TabIndex = 3;
            empleadoButton.Text = "  Empleados";
            empleadoButton.TextAlign = ContentAlignment.MiddleLeft;
            empleadoButton.UseVisualStyleBackColor = true;
            empleadoButton.Click += empleadoButton_Click;
            // 
            // paqueteButton
            // 
            paqueteButton.Dock = DockStyle.Fill;
            paqueteButton.FlatAppearance.BorderSize = 0;
            paqueteButton.FlatStyle = FlatStyle.Flat;
            paqueteButton.Font = new Font("Courier New", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paqueteButton.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            paqueteButton.IconColor = Color.Black;
            paqueteButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            paqueteButton.IconSize = 24;
            paqueteButton.ImageAlign = ContentAlignment.MiddleLeft;
            paqueteButton.Location = new Point(23, 302);
            paqueteButton.Margin = new Padding(3, 2, 3, 2);
            paqueteButton.Name = "paqueteButton";
            paqueteButton.Size = new Size(174, 36);
            paqueteButton.TabIndex = 4;
            paqueteButton.Text = "  Paquetes";
            paqueteButton.TextAlign = ContentAlignment.MiddleLeft;
            paqueteButton.UseVisualStyleBackColor = true;
            paqueteButton.Click += paqueteButton_Click;
            // 
            // serviceButton
            // 
            serviceButton.Dock = DockStyle.Fill;
            serviceButton.FlatAppearance.BorderSize = 0;
            serviceButton.FlatStyle = FlatStyle.Flat;
            serviceButton.Font = new Font("Courier New", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            serviceButton.IconColor = Color.Black;
            serviceButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            serviceButton.IconSize = 24;
            serviceButton.ImageAlign = ContentAlignment.MiddleLeft;
            serviceButton.Location = new Point(23, 252);
            serviceButton.Margin = new Padding(3, 2, 3, 2);
            serviceButton.Name = "serviceButton";
            serviceButton.Size = new Size(174, 36);
            serviceButton.TabIndex = 3;
            serviceButton.Text = "  Servicio";
            serviceButton.TextAlign = ContentAlignment.MiddleLeft;
            serviceButton.UseVisualStyleBackColor = true;
            serviceButton.Click += serviceButton_Click;
            // 
            // utileriaButton
            // 
            utileriaButton.Dock = DockStyle.Fill;
            utileriaButton.FlatAppearance.BorderSize = 0;
            utileriaButton.FlatStyle = FlatStyle.Flat;
            utileriaButton.Font = new Font("Courier New", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utileriaButton.IconChar = FontAwesome.Sharp.IconChar.Box;
            utileriaButton.IconColor = Color.Black;
            utileriaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            utileriaButton.IconSize = 24;
            utileriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            utileriaButton.Location = new Point(23, 202);
            utileriaButton.Margin = new Padding(3, 2, 3, 2);
            utileriaButton.Name = "utileriaButton";
            utileriaButton.Size = new Size(174, 36);
            utileriaButton.TabIndex = 2;
            utileriaButton.Text = "  Utileria";
            utileriaButton.TextAlign = ContentAlignment.MiddleLeft;
            utileriaButton.UseVisualStyleBackColor = true;
            utileriaButton.Click += utileriaButton_Click;
            // 
            // eventButton
            // 
            eventButton.Dock = DockStyle.Fill;
            eventButton.FlatAppearance.BorderSize = 0;
            eventButton.FlatStyle = FlatStyle.Flat;
            eventButton.Font = new Font("Courier New", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventButton.ForeColor = Color.FromArgb(18, 29, 36);
            eventButton.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            eventButton.IconColor = Color.Black;
            eventButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            eventButton.IconSize = 24;
            eventButton.ImageAlign = ContentAlignment.MiddleLeft;
            eventButton.Location = new Point(23, 152);
            eventButton.Margin = new Padding(3, 2, 3, 2);
            eventButton.Name = "eventButton";
            eventButton.Size = new Size(174, 36);
            eventButton.TabIndex = 1;
            eventButton.Text = "  Eventos";
            eventButton.TextAlign = ContentAlignment.MiddleLeft;
            eventButton.UseVisualStyleBackColor = true;
            eventButton.Click += eventButton_Click;
            // 
            // principalPanel
            // 
            principalPanel.ColumnCount = 2;
            principalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            principalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            principalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            principalPanel.Controls.Add(sidebarPanel, 0, 0);
            principalPanel.Controls.Add(PanelForm, 1, 0);
            principalPanel.Dock = DockStyle.Fill;
            principalPanel.Location = new Point(0, 0);
            principalPanel.Margin = new Padding(0);
            principalPanel.Name = "principalPanel";
            principalPanel.RowCount = 1;
            principalPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            principalPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            principalPanel.Size = new Size(800, 500);
            principalPanel.TabIndex = 2;
            // 
            // PanelForm
            // 
            PanelForm.ColumnCount = 1;
            PanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelForm.Controls.Add(tableLayoutPanel1, 0, 0);
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(200, 0);
            PanelForm.Margin = new Padding(0);
            PanelForm.Name = "PanelForm";
            PanelForm.RowCount = 2;
            PanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            PanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            PanelForm.Size = new Size(600, 500);
            PanelForm.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(nightControlBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(600, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(187, 54, 45);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(229, 229, 229);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(229, 229, 229);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.FromArgb(187, 54, 45);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(229, 229, 229);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(187, 54, 45);
            nightControlBox1.Location = new Point(458, 3);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(187, 54, 45);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(187, 54, 45);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(iconButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(UserLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(CierreSesion, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(360, 40);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(240, 60);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 60);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // UserLabel
            // 
            UserLabel.Dock = DockStyle.Fill;
            UserLabel.FlatStyle = FlatStyle.Flat;
            UserLabel.Font = new Font("Courier New", 13F, FontStyle.Bold);
            UserLabel.Location = new Point(51, 0);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(138, 60);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "Usuario ";
            UserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CierreSesion
            // 
            CierreSesion.Dock = DockStyle.Fill;
            CierreSesion.FlatAppearance.BorderSize = 0;
            CierreSesion.FlatStyle = FlatStyle.Flat;
            CierreSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            CierreSesion.IconColor = Color.Black;
            CierreSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CierreSesion.IconSize = 30;
            CierreSesion.Location = new Point(192, 0);
            CierreSesion.Margin = new Padding(0);
            CierreSesion.Name = "CierreSesion";
            CierreSesion.Size = new Size(48, 60);
            CierreSesion.TabIndex = 0;
            CierreSesion.UseVisualStyleBackColor = true;
            CierreSesion.Click += CierreSesion_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Fill;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Courier New", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnClientes.IconSize = 24;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(23, 402);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(174, 36);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "  Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(800, 500);
            Controls.Add(principalPanel);
            Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(18, 29, 36);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(5, 3, 5, 3);
            Name = "Dashboard";
            Text = "Dashboard";
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            principalPanel.ResumeLayout(false);
            PanelForm.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel sidebarPanel;
        private TableLayoutPanel principalPanel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eventButton;
        private FontAwesome.Sharp.IconButton utileriaButton;
        private FontAwesome.Sharp.IconButton serviceButton;
        private FontAwesome.Sharp.IconButton empleadoButton;
        private FontAwesome.Sharp.IconButton paqueteButton;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private TableLayoutPanel PanelForm;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton CierreSesion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label UserLabel;
        private FontAwesome.Sharp.IconButton btnClientes;
    }
}