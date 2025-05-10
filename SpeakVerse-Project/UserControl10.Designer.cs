namespace ProjectSpeakVerse
{
    partial class UserControl10
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFeedback = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(463, 571);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(112, 37);
            this.btnFeedback.TabIndex = 5;
            this.btnFeedback.Text = "Submit";
            this.btnFeedback.UseVisualStyleBackColor = true;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(263, 132);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(523, 407);
            this.txtFeedback.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feedback";
            // 
            // UserControl10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label1);
            this.Name = "UserControl10";
            this.Size = new System.Drawing.Size(1048, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label1;
    }
}
