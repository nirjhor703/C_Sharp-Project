namespace ProjectSpeakVerse
{
    partial class FormEnrollment
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
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvshow
            // 
            this.dgvshow.AllowUserToAddRows = false;
            this.dgvshow.AllowUserToDeleteRows = false;
            this.dgvshow.BackgroundColor = System.Drawing.Color.White;
            this.dgvshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvshow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C,
            this.Course,
            this.CF});
            this.dgvshow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvshow.Location = new System.Drawing.Point(0, 0);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.ReadOnly = true;
            this.dgvshow.RowHeadersWidth = 51;
            this.dgvshow.RowTemplate.Height = 24;
            this.dgvshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvshow.Size = new System.Drawing.Size(1267, 481);
            this.dgvshow.TabIndex = 4;
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C.DataPropertyName = "Course ID";
            this.C.HeaderText = "COURSE ID";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course.DataPropertyName = "Course Name";
            this.Course.HeaderText = "Name";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // CF
            // 
            this.CF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CF.DataPropertyName = "Course Fee";
            this.CF.HeaderText = "Course Fee";
            this.CF.MinimumWidth = 6;
            this.CF.Name = "CF";
            this.CF.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(551, 497);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(155, 62);
            this.btnEnroll.TabIndex = 6;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(586, 497);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 62);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Enroll";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FormEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 703);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvshow);
            this.Name = "FormEnrollment";
            this.Text = "FormEnrollment";
            this.Load += new System.EventHandler(this.FormEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn CF;
        private System.Windows.Forms.Button btnsave;
    }
}