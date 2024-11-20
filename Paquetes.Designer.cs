namespace ShowTime_DatabseProject
{
    partial class Paquetes
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
            label5 = new Label();
            label3 = new Label();
            txtPackageDescription = new TextBox();
            label1 = new Label();
            txtPackageName = new TextBox();
            label2 = new Label();
            txtPackageCost = new TextBox();
            chkbPackageStatus = new CheckBox();
            btnFiltlerPackage = new Button();
            btnDeletePackage = new Button();
            btnUpdatePackage = new Button();
            btnRegisterPackage = new Button();
            dgvPackages = new DataGridView();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 9);
            label5.Name = "label5";
            label5.Size = new Size(195, 28);
            label5.TabIndex = 37;
            label5.Text = "Contol de Paquetes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 34;
            label3.Text = "Descripcion";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(12, 99);
            txtPackageDescription.Multiline = true;
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(382, 60);
            txtPackageDescription.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 54);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(77, 51);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(317, 23);
            txtPackageName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 40;
            label2.Text = "Costo";
            // 
            // txtPackageCost
            // 
            txtPackageCost.Location = new Point(58, 165);
            txtPackageCost.Name = "txtPackageCost";
            txtPackageCost.Size = new Size(68, 23);
            txtPackageCost.TabIndex = 39;
            // 
            // chkbPackageStatus
            // 
            chkbPackageStatus.AutoSize = true;
            chkbPackageStatus.Location = new Point(15, 194);
            chkbPackageStatus.Name = "chkbPackageStatus";
            chkbPackageStatus.Size = new Size(97, 19);
            chkbPackageStatus.TabIndex = 42;
            chkbPackageStatus.Text = "Diponibilidad";
            chkbPackageStatus.UseVisualStyleBackColor = true;
            chkbPackageStatus.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnFiltlerPackage
            // 
            btnFiltlerPackage.Location = new Point(433, 163);
            btnFiltlerPackage.Name = "btnFiltlerPackage";
            btnFiltlerPackage.Size = new Size(136, 31);
            btnFiltlerPackage.TabIndex = 46;
            btnFiltlerPackage.Text = "Filtrar Paquete";
            btnFiltlerPackage.UseVisualStyleBackColor = true;
            // 
            // btnDeletePackage
            // 
            btnDeletePackage.Location = new Point(433, 126);
            btnDeletePackage.Name = "btnDeletePackage";
            btnDeletePackage.Size = new Size(136, 31);
            btnDeletePackage.TabIndex = 45;
            btnDeletePackage.Text = "Eliminar Paquete";
            btnDeletePackage.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePackage
            // 
            btnUpdatePackage.Location = new Point(433, 89);
            btnUpdatePackage.Name = "btnUpdatePackage";
            btnUpdatePackage.Size = new Size(136, 31);
            btnUpdatePackage.TabIndex = 44;
            btnUpdatePackage.Text = "Actualizar Paquete";
            btnUpdatePackage.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPackage
            // 
            btnRegisterPackage.Location = new Point(433, 51);
            btnRegisterPackage.Name = "btnRegisterPackage";
            btnRegisterPackage.Size = new Size(136, 31);
            btnRegisterPackage.TabIndex = 43;
            btnRegisterPackage.Text = "Registrar Paquete";
            btnRegisterPackage.UseVisualStyleBackColor = true;
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Dock = DockStyle.Bottom;
            dgvPackages.Location = new Point(0, 265);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.Size = new Size(600, 205);
            dgvPackages.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 169);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 63;
            label4.Text = "Servicios incluidos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(252, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 64;
            // 
            // Paquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 470);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dgvPackages);
            Controls.Add(btnFiltlerPackage);
            Controls.Add(btnDeletePackage);
            Controls.Add(btnUpdatePackage);
            Controls.Add(btnRegisterPackage);
            Controls.Add(chkbPackageStatus);
            Controls.Add(label2);
            Controls.Add(txtPackageCost);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtPackageDescription);
            Controls.Add(label1);
            Controls.Add(txtPackageName);
            Name = "Paquetes";
            Text = "Paquetes";
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private TextBox txtPackageDescription;
        private Label label1;
        private TextBox txtPackageName;
        private Label label2;
        private TextBox txtPackageCost;
        private CheckBox chkbPackageStatus;
        private Button btnFiltlerPackage;
        private Button btnDeletePackage;
        private Button btnUpdatePackage;
        private Button btnRegisterPackage;
        private DataGridView dgvPackages;
        private Label label4;
        private ComboBox comboBox1;
    }
}