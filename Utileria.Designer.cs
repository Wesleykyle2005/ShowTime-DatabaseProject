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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Dock = DockStyle.Bottom;
            dgvServices.Location = new Point(0, 263);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(520, 231);
            dgvServices.TabIndex = 72;
            // 
            // btnFiltlerService
            // 
            btnFiltlerService.Font = new Font("Forte", 11.25F);
            btnFiltlerService.Location = new Point(156, 190);
            btnFiltlerService.Name = "btnFiltlerService";
            btnFiltlerService.Size = new Size(136, 31);
            btnFiltlerService.TabIndex = 71;
            btnFiltlerService.Text = "Filtrar Utileria";
            btnFiltlerService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Font = new Font("Forte", 11.25F);
            btnDeleteService.Location = new Point(14, 190);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(136, 31);
            btnDeleteService.TabIndex = 70;
            btnDeleteService.Text = "Eliminar Utileria";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Forte", 11.25F);
            btnUpdateService.Location = new Point(156, 153);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(136, 31);
            btnUpdateService.TabIndex = 69;
            btnUpdateService.Text = "Actualizar Utileria";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnRegisterProp
            // 
            btnRegisterProp.Font = new Font("Forte", 11.25F);
            btnRegisterProp.Location = new Point(14, 153);
            btnRegisterProp.Name = "btnRegisterProp";
            btnRegisterProp.Size = new Size(136, 31);
            btnRegisterProp.TabIndex = 68;
            btnRegisterProp.Text = "Registrar Utileria";
            btnRegisterProp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 67;
            label2.Text = "Cantidad";
            // 
            // txtPropQuantity
            // 
            txtPropQuantity.Location = new Point(72, 61);
            txtPropQuantity.Name = "txtPropQuantity";
            txtPropQuantity.Size = new Size(227, 28);
            txtPropQuantity.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Forte", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 9);
            label5.Name = "label5";
            label5.Size = new Size(174, 22);
            label5.TabIndex = 65;
            label5.Text = "Contol de Utileria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 62;
            label1.Text = "Nombre";
            // 
            // txtPropName
            // 
            txtPropName.Location = new Point(72, 23);
            txtPropName.Name = "txtPropName";
            txtPropName.Size = new Size(227, 28);
            txtPropName.TabIndex = 61;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPropQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPropName);
            groupBox1.Font = new Font("Forte", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 97);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Utileria";
            // 
            // Utileria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 494);
            Controls.Add(groupBox1);
            Controls.Add(dgvServices);
            Controls.Add(btnFiltlerService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnUpdateService);
            Controls.Add(btnRegisterProp);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Utileria";
            Text = "Utileria";
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
        private Button btnRegisterProp;
        private Label label2;
        private TextBox txtPropQuantity;
        private Label label5;
        private Label label1;
        private TextBox txtPropName;
        private GroupBox groupBox1;
    }
}