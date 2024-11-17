namespace ShowTime_DatabseProject
{
    partial class Roles
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
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 38;
            label3.Text = "Descripcion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 127);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 173);
            textBox3.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 36;
            label1.Text = "Nombres";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 8);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 39;
            label2.Text = "Roles";
            // 
            // button1
            // 
            button1.Location = new Point(134, 319);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 40;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 353);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Roles";
            Text = "Roles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}