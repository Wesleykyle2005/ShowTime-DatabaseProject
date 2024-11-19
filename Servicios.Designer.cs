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
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Dock = DockStyle.Bottom;
            dgvServices.Location = new Point(0, 207);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(581, 251);
            dgvServices.TabIndex = 60;
            // 
            // btnFiltlerService
            // 
            btnFiltlerService.Location = new Point(433, 158);
            btnFiltlerService.Name = "btnFiltlerService";
            btnFiltlerService.Size = new Size(136, 31);
            btnFiltlerService.TabIndex = 59;
            btnFiltlerService.Text = "Filtrar Servicio";
            btnFiltlerService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(433, 121);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(136, 31);
            btnDeleteService.TabIndex = 58;
            btnDeleteService.Text = "Eliminar Servicio";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Location = new Point(433, 84);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(136, 31);
            btnUpdateService.TabIndex = 57;
            btnUpdateService.Text = "Actualizar Servicio";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnRegisterService
            // 
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
            label2.Location = new Point(11, 164);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 54;
            label2.Text = "Costo";
            // 
            // txtServiceCost
            // 
            txtServiceCost.Location = new Point(58, 160);
            txtServiceCost.Name = "txtServiceCost";
            txtServiceCost.Size = new Size(208, 23);
            txtServiceCost.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 4);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 52;
            label5.Text = "Contol de Servicios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 51;
            label3.Text = "Descripcion";
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Location = new Point(12, 94);
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(382, 60);
            txtServiceDescription.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 49;
            label1.Text = "Nombre";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(77, 46);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(317, 23);
            txtServiceName.TabIndex = 48;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 458);
            Controls.Add(dgvServices);
            Controls.Add(btnFiltlerService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnUpdateService);
            Controls.Add(btnRegisterService);
            Controls.Add(label2);
            Controls.Add(txtServiceCost);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtServiceDescription);
            Controls.Add(label1);
            Controls.Add(txtServiceName);
            Name = "Servicios";
            Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
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
    }
}