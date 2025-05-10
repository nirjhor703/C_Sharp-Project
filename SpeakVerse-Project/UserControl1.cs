using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectSpeakVerse
{
    public partial class UserControl1 : UserControl
    {
        DataAccess Da { get; set; }

        private FormStartPosition StartPosition;

        public UserControl1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             var sql = "select * from UserInfo where UserID = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
            DataSet ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {

                MessageBox.Show("Ready to Verse", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql = "select * from UserInfo where UserID = '"+this.txtUserId.Text+"' and Role = 'Admin';";
                ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    FormAdmin fa  = new FormAdmin(this.txtUserId.Text);
                    fa.Show();
                    this.Hide();
                }
                else
                {
                    sql = "select * from UserInfo where UserID = '" + this.txtUserId.Text + "' and Role = 'Teacher';";
                    ds = this.Da.ExecuteQuery(sql);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        new FormTeacher(this.txtUserId.Text).Visible = true;
                        // fa.Show();
                        this.Hide();
                    }
                    else
                    {
                        new FormStudent(this.txtUserId.Text).Visible = true; 
                        this.Hide();
                    }
                }
               

            }
            else
            {
                MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            txtPassword.UseSystemPasswordChar = !status;
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                txtUserId.Focus();
                errorProvider1.SetError(this.txtUserId, "Enter Username");
            }
            else
            {
                errorProvider1.SetError(this.txtUserId, "");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorProvider2.SetError(this.txtPassword, "Enter Password");
            }
            else
            {
                errorProvider2.SetError(this.txtPassword, "");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
