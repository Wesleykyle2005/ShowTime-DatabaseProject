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
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(315, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 51;
            checkBox1.Text = "Diponibilidad";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 312);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 50;
            label2.Text = "Costo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 49;
            // 
            // button1
            // 
            button1.Location = new Point(109, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 48;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 9);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 47;
            label5.Text = "Servicios";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 101);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 46;
            label3.Text = "Descripcion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 119);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 173);
            textBox3.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 44;
            label1.Text = "Nombres";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 43;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 430);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Servicios";
            Text = "Servicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox1;
    }
}