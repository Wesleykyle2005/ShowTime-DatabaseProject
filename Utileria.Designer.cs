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
            label3 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 18;
            label3.Text = "Cantidad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombres";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(101, 143);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 39;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 40;
            label2.Text = "Utileria";
            // 
            // Utileria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 189);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Utileria";
            Text = "Utileria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
    }
}