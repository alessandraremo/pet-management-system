namespace appointment
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbTimeSlots = new System.Windows.Forms.ComboBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(549, 197);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 34);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbTimeSlots
            // 
            this.cmbTimeSlots.FormattingEnabled = true;
            this.cmbTimeSlots.Location = new System.Drawing.Point(499, 68);
            this.cmbTimeSlots.Name = "cmbTimeSlots";
            this.cmbTimeSlots.Size = new System.Drawing.Size(188, 21);
            this.cmbTimeSlots.TabIndex = 4;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(28, 69);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(152, 20);
            this.txtPatient.TabIndex = 5;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(28, 345);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(680, 200);
            this.dgvReservations.TabIndex = 6;
            this.dgvReservations.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReservations_CellFormatting);
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(499, 136);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(185, 20);
            this.txtContactEmail.TabIndex = 7;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(224, 69);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Appointment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Appointment Time";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(28, 136);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(152, 20);
            this.txtOwner.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Contact Email";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(28, 306);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(136, 21);
            this.cmbStatusFilter.TabIndex = 15;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 585);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.cmbTimeSlots);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbTimeSlots;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
    }
}

