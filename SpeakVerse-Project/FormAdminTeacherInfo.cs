using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSpeakVerse
{
    public partial class FormAdminTeacherInfo : Form
    {
        private DataAccess Da {  get; set; } 
        public FormAdminTeacherInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void PopulateGridview()
        {
            var sql = "select * from UserInfo where Role = 'Teacher'";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvshow.AutoGenerateColumns = false;
            this.dgvshow.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            try
            {
                if(System.Convert.ToInt32(this.txtSalary.Text) < 0 )
                {
                    MessageBox.Show("Salary Can't be negative value");
                }
                else
                {
                    var sql = "Insert into UserInfo(UserID,Name,Salary) values('"+this.txtUserId.Text+"','"+this.txtName.Text+"','"+this.txtSalary.Text+"')";
                    int cnt = this.Da.ExecuteDMLQuery(sql);
                    if(cnt == 1)
                    {
                        MessageBox.Show("Data Added");
                        sql = "update UserInfo set Role = 'Teacher' where UserID = '"+this.txtUserId.Text+"';";
                        cnt = this.Da.ExecuteDMLQuery(sql);

                        sql = "update UserInfo set Password= '123' where UserID='"+this.txtUserId.Text+"';";
                        cnt = this.Da.ExecuteDMLQuery(sql);

                        this.PopulateGridview();
                        this.txtUserId.Text = "";
                        this.txtName.Text = "";
                        this.txtSalary.Text = "";

                    }
                    else
                        MessageBox.Show("Something Error");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Something Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridview();
        }

        private void dgvshow_SelectionChanged(object sender, EventArgs e)
        {
           // this.txtUserId.Text = this.dgvshow.CurrentRow.Cells[0].ToString();
        }

        private void dgvshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUserId.Text = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvshow.CurrentRow.Cells[1].Value.ToString();
            this.txtSalary.Text = this.dgvshow.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dgvshow.SelectedRows.Count <= 0 )
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            var sql = "Update UserInfo set Name='"+this.txtName.Text+"',Salary='"+this.txtSalary.Text+"' where UserID='"+this.txtUserId.Text+"';";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if(cnt==1)
            {
                MessageBox.Show("Value Updated");
                this.PopulateGridview();
            }
            else
            {
                MessageBox.Show("Something Error");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvshow.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First");
                return;

            }
            var id = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            var sql = "Delete UserInfo where UserID = '" + id + "';";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show("Value Deleted");
                this.PopulateGridview();
            }
            else
            {
                MessageBox.Show("Something Error");

            }
        }

        private void FormAdminTeacherInfo_Load(object sender, EventArgs e)
        {

        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //enroll
            var id = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            new FormEnrollment(id,7).Visible = true;
        }
    }
}
