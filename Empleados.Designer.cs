namespace ShowTime_DatabseProject
{
    partial class Empleados
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
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(128, 248);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 28;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 9);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 27;
            label5.Text = "S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 159);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 26;
            label4.Text = "Correo electronico";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 23);
            textBox4.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 24;
            label3.Text = "Numero";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 23);
            textBox3.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombres";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 212);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 29;
            label6.Text = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 23);
            comboBox1.TabIndex = 30;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 316);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Empleados";
            Text = "Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox1;
    }
}