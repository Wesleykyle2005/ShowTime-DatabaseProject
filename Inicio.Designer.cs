namespace ShowTime_DatabseProject
{
    partial class Inicio
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
            generalPanel = new TableLayoutPanel();
            leftPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            flowLayoutPanelActvity = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            eventsCalendar = new Krypton.Toolkit.KryptonMonthCalendar();
            tablepanelLayoutLog = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanelLog = new FlowLayoutPanel();
            generalPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tablepanelLayoutLog.SuspendLayout();
            SuspendLayout();
            // 
            // generalPanel
            // 
            generalPanel.ColumnCount = 2;
            generalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            generalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            generalPanel.Controls.Add(leftPanel, 0, 0);
            generalPanel.Controls.Add(tablepanelLayoutLog, 1, 0);
            generalPanel.Dock = DockStyle.Fill;
            generalPanel.Location = new Point(0, 0);
            generalPanel.Margin = new Padding(0);
            generalPanel.Name = "generalPanel";
            generalPanel.RowCount = 1;
            generalPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            generalPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 533F));
            generalPanel.Size = new Size(900, 500);
            generalPanel.TabIndex = 3;
            // 
            // leftPanel
            // 
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            leftPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(0);
            leftPanel.Name = "leftPanel";
            leftPanel.RowCount = 2;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            leftPanel.Size = new Size(630, 500);
            leftPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanelActvity, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 250);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(630, 250);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 229, 217);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(622, 25);
            label2.TabIndex = 1;
            label2.Text = "Eventos proximos";
            // 
            // flowLayoutPanelActvity
            // 
            flowLayoutPanelActvity.Dock = DockStyle.Fill;
            flowLayoutPanelActvity.Location = new Point(0, 25);
            flowLayoutPanelActvity.Margin = new Padding(0);
            flowLayoutPanelActvity.Name = "flowLayoutPanelActvity";
            flowLayoutPanelActvity.Size = new Size(630, 225);
            flowLayoutPanelActvity.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(eventsCalendar, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(630, 250);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 229, 217);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(622, 25);
            label3.TabIndex = 4;
            label3.Text = "Calendario de ventos";
            // 
            // eventsCalendar
            // 
            eventsCalendar.Location = new Point(4, 29);
            eventsCalendar.Margin = new Padding(4);
            eventsCalendar.Name = "eventsCalendar";
            eventsCalendar.OverrideBolded.Day.Back.Color1 = Color.FromArgb(192, 0, 0);
            eventsCalendar.OverrideBolded.Day.Border.Color1 = Color.Black;
            eventsCalendar.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrange;
            eventsCalendar.Size = new Size(314, 184);
            eventsCalendar.TabIndex = 3;
            // 
            // tablepanelLayoutLog
            // 
            tablepanelLayoutLog.ColumnCount = 1;
            tablepanelLayoutLog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablepanelLayoutLog.Controls.Add(label1, 0, 0);
            tablepanelLayoutLog.Controls.Add(flowLayoutPanelLog, 0, 1);
            tablepanelLayoutLog.Dock = DockStyle.Fill;
            tablepanelLayoutLog.Location = new Point(630, 0);
            tablepanelLayoutLog.Margin = new Padding(0);
            tablepanelLayoutLog.Name = "tablepanelLayoutLog";
            tablepanelLayoutLog.RowCount = 2;
            tablepanelLayoutLog.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablepanelLayoutLog.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tablepanelLayoutLog.Size = new Size(270, 500);
            tablepanelLayoutLog.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 229, 217);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 50);
            label1.TabIndex = 0;
            label1.Text = "Ultimas acciones";
            // 
            // flowLayoutPanelLog
            // 
            flowLayoutPanelLog.Dock = DockStyle.Fill;
            flowLayoutPanelLog.Location = new Point(0, 50);
            flowLayoutPanelLog.Margin = new Padding(0);
            flowLayoutPanelLog.Name = "flowLayoutPanelLog";
            flowLayoutPanelLog.Size = new Size(270, 450);
            flowLayoutPanelLog.TabIndex = 1;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 217);
            ClientSize = new Size(900, 500);
            Controls.Add(generalPanel);
            Font = new Font("Courier New", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Inicio";
            Text = "Inicio";
            generalPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tablepanelLayoutLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel generalPanel;
        private Krypton.Toolkit.KryptonMonthCalendar eventsCalendar;
        private TableLayoutPanel leftPanel;
        private TableLayoutPanel tablepanelLayoutLog;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelLog;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelActvity;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
    }
}