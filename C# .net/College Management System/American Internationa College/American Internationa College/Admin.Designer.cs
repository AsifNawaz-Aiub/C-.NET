namespace American_Internationa_College
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTeacherStatus = new System.Windows.Forms.Button();
            this.btnStudentStatus = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Principal Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTeacherStatus
            // 
            this.btnTeacherStatus.Location = new System.Drawing.Point(197, 255);
            this.btnTeacherStatus.Name = "btnTeacherStatus";
            this.btnTeacherStatus.Size = new System.Drawing.Size(212, 50);
            this.btnTeacherStatus.TabIndex = 2;
            this.btnTeacherStatus.Text = "Teachers Status";
            this.btnTeacherStatus.UseVisualStyleBackColor = true;
            this.btnTeacherStatus.Click += new System.EventHandler(this.btnTeacherStatus_Click);
            // 
            // btnStudentStatus
            // 
            this.btnStudentStatus.Location = new System.Drawing.Point(514, 178);
            this.btnStudentStatus.Name = "btnStudentStatus";
            this.btnStudentStatus.Size = new System.Drawing.Size(188, 50);
            this.btnStudentStatus.TabIndex = 3;
            this.btnStudentStatus.Text = "Students Status";
            this.btnStudentStatus.UseVisualStyleBackColor = true;
            this.btnStudentStatus.Click += new System.EventHandler(this.btnStudentStatus_Click);
            // 
            // btnAdmission
            // 
            this.btnAdmission.Location = new System.Drawing.Point(514, 255);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(188, 50);
            this.btnAdmission.TabIndex = 4;
            this.btnAdmission.Text = "Admission";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(416, 342);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 52);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 499);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.btnStudentStatus);
            this.Controls.Add(this.btnTeacherStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTeacherStatus;
        private System.Windows.Forms.Button btnStudentStatus;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnLogOut;
    }
}