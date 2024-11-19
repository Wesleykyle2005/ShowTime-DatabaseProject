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
            txtAdditionalDetails = new TextBox();
            label9 = new Label();
            cmbPackage = new ComboBox();
            label8 = new Label();
            dtpEndTime = new DateTimePicker();
            label6 = new Label();
            dtpStartTime = new DateTimePicker();
            label7 = new Label();
            dtpDate = new DateTimePicker();
            btnRegisterReservation = new Button();
            label4 = new Label();
            txtNumberAttenddes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtEventAddress = new TextBox();
            label1 = new Label();
            txtEventLocation = new TextBox();
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
            gbEventDetails = new GroupBox();
            gbClienteInfo.SuspendLayout();
            gbEventDetails.SuspendLayout();
            SuspendLayout();
            // 
            // txtAdditionalDetails
            // 
            txtAdditionalDetails.Location = new Point(11, 184);
            txtAdditionalDetails.Multiline = true;
            txtAdditionalDetails.Name = "txtAdditionalDetails";
            txtAdditionalDetails.Size = new Size(643, 104);
            txtAdditionalDetails.TabIndex = 67;
            txtAdditionalDetails.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 166);
            label9.Name = "label9";
            label9.Size = new Size(112, 15);
            label9.TabIndex = 66;
            label9.Text = "Detalles Adicionales";
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(366, 139);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(288, 23);
            cmbPackage.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 143);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 64;
            label8.Text = "Paquete Seleccionado";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(541, 101);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(113, 23);
            dtpEndTime.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label6.Location = new Point(474, 107);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 62;
            label6.Text = "Hora Final";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(366, 101);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(102, 23);
            dtpStartTime.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label7.Location = new Point(295, 107);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 60;
            label7.Text = "Hora Inicio";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(53, 101);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(236, 23);
            dtpDate.TabIndex = 59;
            // 
            // btnRegisterReservation
            // 
            btnRegisterReservation.Location = new Point(259, 469);
            btnRegisterReservation.Name = "btnRegisterReservation";
            btnRegisterReservation.Size = new Size(145, 31);
            btnRegisterReservation.TabIndex = 58;
            btnRegisterReservation.Text = "Registar Reservacion";
            btnRegisterReservation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 142);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 56;
            label4.Text = "Cantidad de Asistentes";
            // 
            // txtNumberAttenddes
            // 
            txtNumberAttenddes.Location = new Point(139, 139);
            txtNumberAttenddes.Name = "txtNumberAttenddes";
            txtNumberAttenddes.Size = new Size(98, 23);
            txtNumberAttenddes.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 107);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 54;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 53;
            label2.Text = "Direccion";
            // 
            // txtEventAddress
            // 
            txtEventAddress.Location = new Point(68, 65);
            txtEventAddress.Name = "txtEventAddress";
            txtEventAddress.Size = new Size(586, 23);
            txtEventAddress.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 51;
            label1.Text = "Ubicacion";
            // 
            // txtEventLocation
            // 
            txtEventLocation.Location = new Point(68, 25);
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.Size = new Size(586, 23);
            txtEventLocation.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.Location = new Point(223, 9);
            label10.Name = "label10";
            label10.Size = new Size(227, 28);
            label10.TabIndex = 76;
            label10.Text = "Reservacion de Evento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(287, 71);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 75;
            label11.Text = "Correo electronico";
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(398, 68);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(256, 23);
            txtClientEmail.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 74);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 73;
            label12.Text = "Numero";
            // 
            // txtClientNumber
            // 
            txtClientNumber.Location = new Point(67, 71);
            txtClientNumber.Name = "txtClientNumber";
            txtClientNumber.Size = new Size(219, 23);
            txtClientNumber.TabIndex = 72;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(336, 39);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 71;
            label13.Text = "Apellidos";
            // 
            // txtClientLastName
            // 
            txtClientLastName.Location = new Point(398, 34);
            txtClientLastName.Name = "txtClientLastName";
            txtClientLastName.Size = new Size(256, 23);
            txtClientLastName.TabIndex = 70;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 39);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 69;
            label14.Text = "Nombres";
            label14.Click += label14_Click;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(67, 34);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(219, 23);
            txtClientName.TabIndex = 68;
            // 
            // gbClienteInfo
            // 
            gbClienteInfo.Controls.Add(label11);
            gbClienteInfo.Controls.Add(txtClientEmail);
            gbClienteInfo.Controls.Add(label14);
            gbClienteInfo.Controls.Add(label12);
            gbClienteInfo.Controls.Add(txtClientNumber);
            gbClienteInfo.Controls.Add(label13);
            gbClienteInfo.Controls.Add(txtClientLastName);
            gbClienteInfo.Controls.Add(txtClientName);
            gbClienteInfo.Location = new Point(12, 40);
            gbClienteInfo.Name = "gbClienteInfo";
            gbClienteInfo.Size = new Size(660, 114);
            gbClienteInfo.TabIndex = 77;
            gbClienteInfo.TabStop = false;
            gbClienteInfo.Text = "Informacion del Cliente";
            // 
            // gbEventDetails
            // 
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
            gbEventDetails.Controls.Add(txtEventAddress);
            gbEventDetails.Controls.Add(label1);
            gbEventDetails.Controls.Add(txtEventLocation);
            gbEventDetails.Location = new Point(12, 165);
            gbEventDetails.Name = "gbEventDetails";
            gbEventDetails.Size = new Size(660, 298);
            gbEventDetails.TabIndex = 78;
            gbEventDetails.TabStop = false;
            gbEventDetails.Text = "Detalles de Evento";
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 508);
            Controls.Add(gbEventDetails);
            Controls.Add(gbClienteInfo);
            Controls.Add(label10);
            Controls.Add(btnRegisterReservation);
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

        private TextBox txtAdditionalDetails;
        private Label label9;
        private ComboBox cmbPackage;
        private Label label8;
        private DateTimePicker dtpEndTime;
        private Label label6;
        private DateTimePicker dtpStartTime;
        private Label label7;
        private DateTimePicker dtpDate;
        private Button btnRegisterReservation;
        private Label label4;
        private TextBox txtNumberAttenddes;
        private Label label3;
        private Label label2;
        private TextBox txtEventAddress;
        private Label label1;
        private TextBox txtEventLocation;
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
        private GroupBox gbEventDetails;
    }
}