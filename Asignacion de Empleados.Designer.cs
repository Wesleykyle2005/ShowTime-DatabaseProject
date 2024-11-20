namespace ShowTime_DatabseProject
{
    partial class Asignacion_de_Empleados
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
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(140, 104);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 28);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(140, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 62;
            label1.Text = "Evento";
            // 
            // button3
            // 
            button3.Location = new Point(97, 149);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 0;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 78);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 67;
            label2.Text = "Empleado";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 121, 131);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(313, 196);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asiganción de empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 104);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 68;
            label3.Text = "Rol";
            // 
            // Asignacion_de_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Asignacion_de_Empleados";
            Text = "Asignacion_de_Empleados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
    }
}