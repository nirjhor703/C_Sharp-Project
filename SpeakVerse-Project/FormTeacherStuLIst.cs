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
    public partial class FormTeacherStuLIst : Form
    {
        private DataAccess Da { get; set; }

        private string Id { get; set; }

        public FormTeacherStuLIst()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Da = new DataAccess();
            this.dgvshow.AutoGenerateColumns = false;
   
        }

        public FormTeacherStuLIst(string id) : this()
        {
            this.Id = id;
            this.btnAdd.Visible = false;
            this.btnUpdate.Visible = false;
            this.btnDelete.Visible = false;
            this.txtUserId.Visible = false;
            this.txtName.Visible = false;
            this.lblName.Visible = false;
            this.lblUserId.Visible = false;

        }

        private void PopulateGridview()
        {
            var sql = "select * from UserInfo where Role = 'Student'";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvshow.AutoGenerateColumns = false;
            this.dgvshow.DataSource = ds.Tables[0];
        }

        private void FormTeacherStuLIst_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                    var sql = "Insert into UserInfo(UserID,Name) values('" + this.txtUserId.Text + "','" + this.txtName.Text + "')";
                    int cnt = this.Da.ExecuteDMLQuery(sql);
                    if (cnt == 1)
                    {
                        MessageBox.Show("Data Added");
                        sql = "update UserInfo set Role = 'Student' where UserID = '" + this.txtUserId.Text + "';";
                        cnt = this.Da.ExecuteDMLQuery(sql);
                        this.PopulateGridview();
                        this.txtUserId.Text = "";
                        this.txtName.Text = "";
                        

                    }
                    else
                        MessageBox.Show("Something Error");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Error");
            }
        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUserId.Text = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvshow.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dgvshow.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            var sql = "Update UserInfo set Name='" + this.txtName.Text + "' where UserID='" + this.txtUserId.Text + "';";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show("Value Updated");
                this.PopulateGridview();
            }
            else
            {
                MessageBox.Show("Something Error");

            }
        }

        private void dgvshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUserId.Text = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvshow.CurrentRow.Cells[1].Value.ToString();
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
                this.txtName.Text = "";
                this.txtUserId.Text = "";
                this.PopulateGridview();
            }
            else
            {
                MessageBox.Show("Something Error");

            }
        }
    }
}
