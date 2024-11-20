﻿namespace ShowTime_DatabseProject
{
    partial class Eventos
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
            btnRegisterReservation = new Button();
            label10 = new Label();
            label11 = new Label();
            txtClientEmail = new TextBox();
            label12 = new Label();
            txtClientNumber = new TextBox();
            label13 = new Label();
            txtClientLastName = new TextBox();
            label14 = new Label();
            txtClientName = new TextBox();
            gbClienteInfo = new GroupBox();
            txtEventAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumberAttenddes = new TextBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label7 = new Label();
            dtpStartTime = new DateTimePicker();
            label6 = new Label();
            dtpEndTime = new DateTimePicker();
            label8 = new Label();
            cmbPackage = new ComboBox();
            label9 = new Label();
            txtAdditionalDetails = new TextBox();
            cmbEventLoaction = new ComboBox();
            cmbServices = new ComboBox();
            label5 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            gbEventDetails = new GroupBox();
            label16 = new Label();
            gbClienteInfo.SuspendLayout();
            gbEventDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterReservation
            // 
            btnRegisterReservation.Font = new Font("Forte", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterReservation.Location = new Point(260, 457);
            btnRegisterReservation.Name = "btnRegisterReservation";
            btnRegisterReservation.Size = new Size(154, 31);
            btnRegisterReservation.TabIndex = 58;
            btnRegisterReservation.Text = "Registar Evento";
            btnRegisterReservation.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Forte", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(181, 5);
            label10.Name = "label10";
            label10.Size = new Size(285, 32);
            label10.TabIndex = 76;
            label10.Text = "Reservacion de Evento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(290, 75);
            label11.Name = "label11";
            label11.Size = new Size(106, 14);
            label11.TabIndex = 75;
            label11.Text = "Correo electronico";
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(398, 68);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(256, 25);
            txtClientEmail.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 74);
            label12.Name = "label12";
            label12.Size = new Size(51, 14);
            label12.TabIndex = 73;
            label12.Text = "Numero";
            // 
            // txtClientNumber
            // 
            txtClientNumber.Location = new Point(65, 69);
            txtClientNumber.Name = "txtClientNumber";
            txtClientNumber.Size = new Size(219, 25);
            txtClientNumber.TabIndex = 72;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(331, 39);
            label13.Name = "label13";
            label13.Size = new Size(64, 14);
            label13.TabIndex = 71;
            label13.Text = "Apellidos";
            // 
            // txtClientLastName
            // 
            txtClientLastName.Location = new Point(398, 34);
            txtClientLastName.Name = "txtClientLastName";
            txtClientLastName.Size = new Size(256, 25);
            txtClientLastName.TabIndex = 70;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 40);
            label14.Name = "label14";
            label14.Size = new Size(56, 14);
            label14.TabIndex = 69;
            label14.Text = "Nombres";
            label14.Click += label14_Click;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(65, 35);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(219, 25);
            txtClientName.TabIndex = 68;
            // 
            // gbClienteInfo
            // 
            gbClienteInfo.BackColor = Color.FromArgb(242, 121, 131);
            gbClienteInfo.Controls.Add(label11);
            gbClienteInfo.Controls.Add(txtClientEmail);
            gbClienteInfo.Controls.Add(label14);
            gbClienteInfo.Controls.Add(label12);
            gbClienteInfo.Controls.Add(txtClientNumber);
            gbClienteInfo.Controls.Add(label13);
            gbClienteInfo.Controls.Add(txtClientLastName);
            gbClienteInfo.Controls.Add(txtClientName);
            gbClienteInfo.Font = new Font("Forte", 9.75F);
            gbClienteInfo.Location = new Point(12, 40);
            gbClienteInfo.Name = "gbClienteInfo";
            gbClienteInfo.Size = new Size(660, 102);
            gbClienteInfo.TabIndex = 77;
            gbClienteInfo.TabStop = false;
            gbClienteInfo.Text = "Informacion del Cliente";
            gbClienteInfo.Enter += gbClienteInfo_Enter;
            // 
            // txtEventAddress
            // 
            txtEventAddress.Location = new Point(74, 56);
            txtEventAddress.Name = "txtEventAddress";
            txtEventAddress.Size = new Size(579, 25);
            txtEventAddress.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 14);
            label1.TabIndex = 51;
            label1.Text = "Ubicacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 14);
            label2.TabIndex = 53;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 107);
            label3.Name = "label3";
            label3.Size = new Size(39, 14);
            label3.TabIndex = 54;
            label3.Text = "Fecha";
            // 
            // txtNumberAttenddes
            // 
            txtNumberAttenddes.Location = new Point(139, 139);
            txtNumberAttenddes.Name = "txtNumberAttenddes";
            txtNumberAttenddes.Size = new Size(56, 25);
            txtNumberAttenddes.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 142);
            label4.Name = "label4";
            label4.Size = new Size(133, 14);
            label4.TabIndex = 56;
            label4.Text = "Cantidad de Asistentes";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(53, 101);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(236, 25);
            dtpDate.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label7.Location = new Point(295, 107);
            label7.Name = "label7";
            label7.Size = new Size(71, 14);
            label7.TabIndex = 60;
            label7.Text = "Hora Inicio";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(366, 101);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(102, 25);
            dtpStartTime.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label6.Location = new Point(474, 107);
            label6.Name = "label6";
            label6.Size = new Size(68, 14);
            label6.TabIndex = 62;
            label6.Text = "Hora Final";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(541, 101);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(113, 25);
            dtpEndTime.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 147);
            label8.Name = "label8";
            label8.Size = new Size(128, 14);
            label8.TabIndex = 64;
            label8.Text = "Paquete Seleccionado";
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(355, 142);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(298, 22);
            cmbPackage.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 198);
            label9.Name = "label9";
            label9.Size = new Size(126, 14);
            label9.TabIndex = 66;
            label9.Text = "Detalles Adicionales";
            // 
            // txtAdditionalDetails
            // 
            txtAdditionalDetails.Location = new Point(11, 215);
            txtAdditionalDetails.Multiline = true;
            txtAdditionalDetails.Name = "txtAdditionalDetails";
            txtAdditionalDetails.Size = new Size(643, 69);
            txtAdditionalDetails.TabIndex = 67;
            txtAdditionalDetails.TextChanged += textBox3_TextChanged;
            // 
            // cmbEventLoaction
            // 
            cmbEventLoaction.FormattingEnabled = true;
            cmbEventLoaction.Location = new Point(74, 28);
            cmbEventLoaction.Name = "cmbEventLoaction";
            cmbEventLoaction.Size = new Size(579, 22);
            cmbEventLoaction.TabIndex = 68;
            // 
            // cmbServices
            // 
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(355, 170);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(298, 22);
            cmbServices.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 184);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(220, 170);
            label15.Name = "label15";
            label15.Size = new Size(124, 14);
            label15.TabIndex = 72;
            label15.Text = "Servicio Seleccionado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 167);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 73;
            // 
            // gbEventDetails
            // 
            gbEventDetails.BackColor = Color.FromArgb(242, 121, 131);
            gbEventDetails.Controls.Add(label16);
            gbEventDetails.Controls.Add(textBox1);
            gbEventDetails.Controls.Add(label15);
            gbEventDetails.Controls.Add(label5);
            gbEventDetails.Controls.Add(cmbServices);
            gbEventDetails.Controls.Add(cmbEventLoaction);
            gbEventDetails.Controls.Add(txtAdditionalDetails);
            gbEventDetails.Controls.Add(label9);
            gbEventDetails.Controls.Add(cmbPackage);
            gbEventDetails.Controls.Add(label8);
            gbEventDetails.Controls.Add(dtpEndTime);
            gbEventDetails.Controls.Add(label6);
            gbEventDetails.Controls.Add(dtpStartTime);
            gbEventDetails.Controls.Add(label7);
            gbEventDetails.Controls.Add(dtpDate);
            gbEventDetails.Controls.Add(label4);
            gbEventDetails.Controls.Add(txtNumberAttenddes);
            gbEventDetails.Controls.Add(label3);
            gbEventDetails.Controls.Add(label2);
            gbEventDetails.Controls.Add(label1);
            gbEventDetails.Controls.Add(txtEventAddress);
            gbEventDetails.Font = new Font("Forte", 9.75F);
            gbEventDetails.Location = new Point(12, 153);
            gbEventDetails.Name = "gbEventDetails";
            gbEventDetails.Size = new Size(660, 298);
            gbEventDetails.TabIndex = 78;
            gbEventDetails.TabStop = false;
            gbEventDetails.Text = "Detalles de Evento";
            gbEventDetails.Enter += gbEventDetails_Enter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(93, 172);
            label16.Name = "label16";
            label16.Size = new Size(39, 14);
            label16.TabIndex = 74;
            label16.Text = "Costo";
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(690, 500);
            Controls.Add(gbEventDetails);
            Controls.Add(gbClienteInfo);
            Controls.Add(label10);
            Controls.Add(btnRegisterReservation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Eventos";
            Text = "Eventos";
            gbClienteInfo.ResumeLayout(false);
            gbClienteInfo.PerformLayout();
            gbEventDetails.ResumeLayout(false);
            gbEventDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegisterReservation;
        private Label label10;
        private Label label11;
        private TextBox txtClientEmail;
        private Label label12;
        private TextBox txtClientNumber;
        private Label label13;
        private TextBox txtClientLastName;
        private Label label14;
        private TextBox txtClientName;
        private GroupBox gbClienteInfo;
        private TextBox txtEventAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumberAttenddes;
        private Label label4;
        private DateTimePicker dtpDate;
        private Label label7;
        private DateTimePicker dtpStartTime;
        private Label label6;
        private DateTimePicker dtpEndTime;
        private Label label8;
        private ComboBox cmbPackage;
        private Label label9;
        private TextBox txtAdditionalDetails;
        private ComboBox cmbEventLoaction;
        private ComboBox cmbServices;
        private Label label5;
        private Label label15;
        private TextBox textBox1;
        private GroupBox gbEventDetails;
        private Label label16;
    }
}