namespace DMC_Generation_System
{
    partial class Add_Courses
    {
        // <summary>
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_no_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creditHrs_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.semester_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marks_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(242, 100);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(179, 25);
            this.name_box.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // reg_no_box
            // 
            this.reg_no_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_no_box.Location = new System.Drawing.Point(242, 133);
            this.reg_no_box.Name = "reg_no_box";
            this.reg_no_box.Size = new System.Drawing.Size(179, 25);
            this.reg_no_box.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Credit Hours";
            // 
            // creditHrs_box
            // 
            this.creditHrs_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditHrs_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.creditHrs_box.FormattingEnabled = true;
            this.creditHrs_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.creditHrs_box.Location = new System.Drawing.Point(242, 164);
            this.creditHrs_box.Name = "creditHrs_box";
            this.creditHrs_box.Size = new System.Drawing.Size(179, 25);
            this.creditHrs_box.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add Course";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(242, 269);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(83, 29);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(338, 269);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(83, 29);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // semester_box
            // 
            this.semester_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semester_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.semester_box.FormattingEnabled = true;
            this.semester_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.semester_box.Location = new System.Drawing.Point(242, 195);
            this.semester_box.Name = "semester_box";
            this.semester_box.Size = new System.Drawing.Size(179, 25);
            this.semester_box.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Marks";
            // 
            // marks_box
            // 
            this.marks_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks_box.Location = new System.Drawing.Point(242, 226);
            this.marks_box.Name = "marks_box";
            this.marks_box.Size = new System.Drawing.Size(179, 25);
            this.marks_box.TabIndex = 25;
            // 
            // Add_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(621, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.marks_box);
            this.Controls.Add(this.semester_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditHrs_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg_no_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.MaximizeBox = false;
            this.Name = "Add_Courses";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_no_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox creditHrs_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox semester_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marks_box;
    }
}