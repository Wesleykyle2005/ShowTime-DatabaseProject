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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label5.Location = new Point(240, 9);
            label5.Name = "label5";
            label5.Size = new Size(193, 24);
            label5.TabIndex = 37;
            label5.Text = "Contol de Paquetes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 52);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 34;
            label3.Text = "Descripcion";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(2, 75);
            txtPackageDescription.Multiline = true;
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(382, 55);
            txtPackageDescription.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(118, 22);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(266, 26);
            txtPackageName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 140);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 40;
            label2.Text = "Costo";
            // 
            // txtPackageCost
            // 
            txtPackageCost.Location = new Point(67, 136);
            txtPackageCost.Name = "txtPackageCost";
            txtPackageCost.Size = new Size(49, 26);
            txtPackageCost.TabIndex = 39;
            // 
            // chkbPackageStatus
            // 
            chkbPackageStatus.AutoSize = true;
            chkbPackageStatus.Location = new Point(27, 163);
            chkbPackageStatus.Name = "chkbPackageStatus";
            chkbPackageStatus.Size = new Size(131, 24);
            chkbPackageStatus.TabIndex = 42;
            chkbPackageStatus.Text = "Diponibilidad";
            chkbPackageStatus.UseVisualStyleBackColor = true;
            chkbPackageStatus.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnFiltlerPackage
            // 
            btnFiltlerPackage.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnFiltlerPackage.Location = new Point(513, 176);
            btnFiltlerPackage.Name = "btnFiltlerPackage";
            btnFiltlerPackage.Size = new Size(148, 31);
            btnFiltlerPackage.TabIndex = 46;
            btnFiltlerPackage.Text = "Filtrar Paquete";
            btnFiltlerPackage.UseVisualStyleBackColor = true;
            // 
            // btnDeletePackage
            // 
            btnDeletePackage.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnDeletePackage.Location = new Point(513, 139);
            btnDeletePackage.Name = "btnDeletePackage";
            btnDeletePackage.Size = new Size(148, 31);
            btnDeletePackage.TabIndex = 45;
            btnDeletePackage.Text = "Eliminar Paquete";
            btnDeletePackage.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePackage
            // 
            btnUpdatePackage.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnUpdatePackage.Location = new Point(513, 102);
            btnUpdatePackage.Name = "btnUpdatePackage";
            btnUpdatePackage.Size = new Size(148, 31);
            btnUpdatePackage.TabIndex = 44;
            btnUpdatePackage.Text = "Actualizar Paquete";
            btnUpdatePackage.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPackage
            // 
            btnRegisterPackage.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnRegisterPackage.Location = new Point(513, 64);
            btnRegisterPackage.Name = "btnRegisterPackage";
            btnRegisterPackage.Size = new Size(148, 31);
            btnRegisterPackage.TabIndex = 43;
            btnRegisterPackage.Text = "Registrar Paquete";
            btnRegisterPackage.UseVisualStyleBackColor = true;
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Dock = DockStyle.Bottom;
            dgvPackages.Location = new Point(0, 295);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.Size = new Size(700, 205);
            dgvPackages.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 140);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 63;
            label4.Text = "Servicios incluidos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(298, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 28);
            comboBox1.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkbPackageStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPackageCost);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPackageDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPackageName);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(104, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 200);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Paquete";
            // 
            // Paquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(groupBox1);
            Controls.Add(dgvPackages);
            Controls.Add(btnFiltlerPackage);
            Controls.Add(btnDeletePackage);
            Controls.Add(btnUpdatePackage);
            Controls.Add(btnRegisterPackage);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Paquetes";
            Text = "Paquetes";
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
    }
}