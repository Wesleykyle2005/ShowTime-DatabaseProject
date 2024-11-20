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
            dgvServices = new DataGridView();
            btnFiltlerService = new Button();
            btnDeleteService = new Button();
            btnUpdateService = new Button();
            btnRegisterService = new Button();
            label2 = new Label();
            txtServiceCost = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtServiceDescription = new TextBox();
            label1 = new Label();
            txtServiceName = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Dock = DockStyle.Bottom;
            dgvServices.Location = new Point(0, 248);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(581, 210);
            dgvServices.TabIndex = 60;
            // 
            // btnFiltlerService
            // 
            btnFiltlerService.Font = new Font("Forte", 11.25F);
            btnFiltlerService.Location = new Point(433, 158);
            btnFiltlerService.Name = "btnFiltlerService";
            btnFiltlerService.Size = new Size(136, 31);
            btnFiltlerService.TabIndex = 59;
            btnFiltlerService.Text = "Filtrar Servicio";
            btnFiltlerService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Font = new Font("Forte", 11.25F);
            btnDeleteService.Location = new Point(433, 121);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(136, 31);
            btnDeleteService.TabIndex = 58;
            btnDeleteService.Text = "Eliminar Servicio";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Forte", 11.25F);
            btnUpdateService.Location = new Point(433, 84);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(136, 31);
            btnUpdateService.TabIndex = 57;
            btnUpdateService.Text = "Actualizar Servicio";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnRegisterService
            // 
            btnRegisterService.Font = new Font("Forte", 11.25F);
            btnRegisterService.Location = new Point(433, 46);
            btnRegisterService.Name = "btnRegisterService";
            btnRegisterService.Size = new Size(136, 31);
            btnRegisterService.TabIndex = 56;
            btnRegisterService.Text = "Registrar Servicio";
            btnRegisterService.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 158);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 54;
            label2.Text = "Costo";
            // 
            // txtServiceCost
            // 
            txtServiceCost.Location = new Point(54, 151);
            txtServiceCost.Name = "txtServiceCost";
            txtServiceCost.Size = new Size(79, 28);
            txtServiceCost.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Forte", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(162, 6);
            label5.Name = "label5";
            label5.Size = new Size(234, 30);
            label5.TabIndex = 52;
            label5.Text = "Contol de Servicios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 51;
            label3.Text = "Descripcion";
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Location = new Point(20, 65);
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(382, 80);
            txtServiceDescription.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 49;
            label1.Text = "Nombre";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(91, 19);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(317, 28);
            txtServiceName.TabIndex = 48;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(242, 242, 242);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(281, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 158);
            label4.Name = "label4";
            label4.Size = new Size(125, 16);
            label4.TabIndex = 62;
            label4.Text = "Utileria neceasaria";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtServiceCost);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtServiceDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtServiceName);
            groupBox1.Font = new Font("Forte", 11.25F);
            groupBox1.Location = new Point(11, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 190);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Servicio";
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(581, 458);
            Controls.Add(groupBox1);
            Controls.Add(dgvServices);
            Controls.Add(btnFiltlerService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnUpdateService);
            Controls.Add(btnRegisterService);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Servicios";
            Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private Button btnFiltlerService;
        private Button btnDeleteService;
        private Button btnUpdateService;
        private Button btnRegisterService;
        private Label label2;
        private TextBox txtServiceCost;
        private Label label5;
        private Label label3;
        private TextBox txtServiceDescription;
        private Label label1;
        private TextBox txtServiceName;
        private ComboBox comboBox1;
        private Label label4;
        private GroupBox groupBox1;
    }
}