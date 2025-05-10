namespace ProjectSpeakVerse
{
    partial class FormStudentMyCourse
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
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Courses";
            // 
            // dgvshow
            // 
            this.dgvshow.AllowUserToAddRows = false;
            this.dgvshow.AllowUserToDeleteRows = false;
            this.dgvshow.BackgroundColor = System.Drawing.Color.White;
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C,
            this.Course,
            this.Cf});
            this.dgvshow.Location = new System.Drawing.Point(3, 102);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.ReadOnly = true;
            this.dgvshow.RowHeadersWidth = 51;
            this.dgvshow.RowTemplate.Height = 24;
            this.dgvshow.Size = new System.Drawing.Size(1261, 449);
            this.dgvshow.TabIndex = 3;
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C.DataPropertyName = "CourseId";
            this.C.HeaderText = "COURSE ID";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course.DataPropertyName = "CourseName";
            this.Course.HeaderText = "Name";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Cf
            // 
            this.Cf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cf.DataPropertyName = "CourseFee";
            this.Cf.HeaderText = "Course Fee";
            this.Cf.MinimumWidth = 6;
            this.Cf.Name = "Cf";
            this.Cf.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStudentMyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormStudentMyCourse";
            this.Text = "FormStudentMyCourse";
            this.Load += new System.EventHandler(this.FormStudentMyCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cf;
    }
}