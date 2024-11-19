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
            dgvServices = new DataGridView();
            btnFiltlerService = new Button();
            btnDeleteService = new Button();
            btnUpdateService = new Button();
            btnRegisterProp = new Button();
            label2 = new Label();
            txtPropQuantity = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtPropName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Dock = DockStyle.Bottom;
            dgvServices.Location = new Point(0, 193);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(316, 301);
            dgvServices.TabIndex = 72;
            // 
            // btnFiltlerService
            // 
            btnFiltlerService.Location = new Point(157, 156);
            btnFiltlerService.Name = "btnFiltlerService";
            btnFiltlerService.Size = new Size(136, 31);
            btnFiltlerService.TabIndex = 71;
            btnFiltlerService.Text = "Filtrar Utileria";
            btnFiltlerService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(15, 156);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(136, 31);
            btnDeleteService.TabIndex = 70;
            btnDeleteService.Text = "Eliminar Utileria";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Location = new Point(157, 119);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(136, 31);
            btnUpdateService.TabIndex = 69;
            btnUpdateService.Text = "Actualizar Utileria";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnRegisterProp
            // 
            btnRegisterProp.Location = new Point(15, 119);
            btnRegisterProp.Name = "btnRegisterProp";
            btnRegisterProp.Size = new Size(136, 31);
            btnRegisterProp.TabIndex = 68;
            btnRegisterProp.Text = "Registrar Utileria";
            btnRegisterProp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 67;
            label2.Text = "Cantidad";
            // 
            // txtPropQuantity
            // 
            txtPropQuantity.Location = new Point(77, 82);
            txtPropQuantity.Name = "txtPropQuantity";
            txtPropQuantity.Size = new Size(227, 23);
            txtPropQuantity.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 9);
            label5.Name = "label5";
            label5.Size = new Size(179, 28);
            label5.TabIndex = 65;
            label5.Text = "Contol de Utileria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 62;
            label1.Text = "Nombre";
            // 
            // txtPropName
            // 
            txtPropName.Location = new Point(77, 44);
            txtPropName.Name = "txtPropName";
            txtPropName.Size = new Size(227, 23);
            txtPropName.TabIndex = 61;
            // 
            // Utileria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 494);
            Controls.Add(dgvServices);
            Controls.Add(btnFiltlerService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnUpdateService);
            Controls.Add(btnRegisterProp);
            Controls.Add(label2);
            Controls.Add(txtPropQuantity);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtPropName);
            Name = "Utileria";
            Text = "Utileria";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private Button btnFiltlerService;
        private Button btnDeleteService;
        private Button btnUpdateService;
        private Button btnRegisterProp;
        private Label label2;
        private TextBox txtPropQuantity;
        private Label label5;
        private Label label1;
        private TextBox txtPropName;
    }
}