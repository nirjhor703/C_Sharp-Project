namespace ProjectSpeakVerse
{
    partial class FormTeacherStuLIst
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
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student List";
            // 
            // dgvshow
            // 
            this.dgvshow.AllowUserToAddRows = false;
            this.dgvshow.AllowUserToDeleteRows = false;
            this.dgvshow.BackgroundColor = System.Drawing.Color.White;
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.TName,
            this.Temail,
            this.Phone});
            this.dgvshow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvshow.Location = new System.Drawing.Point(0, 336);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.ReadOnly = true;
            this.dgvshow.RowHeadersWidth = 51;
            this.dgvshow.RowTemplate.Height = 24;
            this.dgvshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvshow.Size = new System.Drawing.Size(1267, 367);
            this.dgvshow.TabIndex = 5;
            this.dgvshow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshow_CellClick);
            this.dgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshow_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserID";
            this.UserId.HeaderText = "User Id";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 180;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "Name";
            this.TName.HeaderText = "Name";
            this.TName.MinimumWidth = 6;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 200;
            // 
            // Temail
            // 
            this.Temail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temail.DataPropertyName = "Email";
            this.Temail.HeaderText = "Email";
            this.Temail.MinimumWidth = 6;
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Number";
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(878, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 49);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(724, 251);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 49);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(409, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(567, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 49);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(256, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 49);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(521, 185);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 35);
            this.txtName.TabIndex = 16;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(521, 126);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(290, 35);
            this.txtUserId.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(430, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 28);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(430, 126);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 28);
            this.lblUserId.TabIndex = 12;
            this.lblUserId.Text = "User Id";
            // 
            // FormTeacherStuLIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 703);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.label1);
            this.Name = "FormTeacherStuLIst";
            this.Text = "FormTeacherStuLIst";
            this.Load += new System.EventHandler(this.FormTeacherStuLIst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserId;
    }
}