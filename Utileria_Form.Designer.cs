namespace ShowTime_DatabseProject
{
    partial class Utileria_Form
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
            dgvUtileria = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvUtileria).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUtileria
            // 
            dgvUtileria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtileria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtileria.Dock = DockStyle.Bottom;
            dgvUtileria.Location = new Point(0, 269);
            dgvUtileria.Name = "dgvUtileria";
            dgvUtileria.Size = new Size(700, 231);
            dgvUtileria.TabIndex = 72;
            // 
            // btnFiltlerService
            // 
            btnFiltlerService.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnFiltlerService.Location = new Point(340, 214);
            btnFiltlerService.Name = "btnFiltlerService";
            btnFiltlerService.Size = new Size(136, 31);
            btnFiltlerService.TabIndex = 71;
            btnFiltlerService.Text = "Filtrar Utileria";
            btnFiltlerService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnDeleteService.Location = new Point(198, 214);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(136, 31);
            btnDeleteService.TabIndex = 70;
            btnDeleteService.Text = "Eliminar Utileria";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnUpdateService.Location = new Point(340, 177);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(136, 31);
            btnUpdateService.TabIndex = 69;
            btnUpdateService.Text = "Actualizar Utileria";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnRegisterProp
            // 
            btnRegisterProp.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnRegisterProp.Location = new Point(198, 177);
            btnRegisterProp.Name = "btnRegisterProp";
            btnRegisterProp.Size = new Size(136, 31);
            btnRegisterProp.TabIndex = 68;
            btnRegisterProp.Text = "Registrar Utileria";
            btnRegisterProp.UseVisualStyleBackColor = true;
            btnRegisterProp.Click += btnRegisterProp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 67;
            label2.Text = "Cantidad";
            // 
            // txtPropQuantity
            // 
            txtPropQuantity.Location = new Point(95, 61);
            txtPropQuantity.Name = "txtPropQuantity";
            txtPropQuantity.Size = new Size(200, 26);
            txtPropQuantity.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(244, 9);
            label5.Name = "label5";
            label5.Size = new Size(195, 25);
            label5.TabIndex = 65;
            label5.Text = "Contol de Utileria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 62;
            label1.Text = "Nombre";
            // 
            // txtPropName
            // 
            txtPropName.Location = new Point(95, 22);
            txtPropName.Name = "txtPropName";
            txtPropName.Size = new Size(200, 26);
            txtPropName.TabIndex = 61;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPropQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPropName);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(186, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(313, 97);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Utileria";
            // 
            // Utileria_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(groupBox1);
            Controls.Add(dgvUtileria);
            Controls.Add(btnFiltlerService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnUpdateService);
            Controls.Add(btnRegisterProp);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Utileria_Form";
            Text = "Utileria";
            ((System.ComponentModel.ISupportInitialize)dgvUtileria).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUtileria;
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