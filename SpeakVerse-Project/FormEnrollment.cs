using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSpeakVerse
{
    public partial class FormEnrollment : Form
    {
        private DataAccess Da { get; set; }

        private string Id { get; set; }
        public FormEnrollment()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FormEnrollment(string id) : this() 
        {
            this.Id = id;
            this.PopulateGridview();
            this.btnsave.Visible = false;
        }
        public FormEnrollment(string id,int x) : this()
        {
            this.Id = id;
            this.PopulateGridview();
            this.btnEnroll.Visible = false;
        }
        private void PopulateGridview()
        {
            var sql = "select * from Courses";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvshow.AutoGenerateColumns = false;
            this.dgvshow.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (this.dgvshow.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            var cId = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            var cname = this.dgvshow.CurrentRow.Cells[1].Value.ToString();
            var cFee = this.dgvshow.CurrentRow.Cells[2].Value.ToString();
            var sql = "insert into EnrollCourses values('" + cId + "','" + cname + "','" + cFee + "','" + this.Id + "');";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show("Course Enrollment Successful");
            }
            else MessageBox.Show("Course Enrollment Unuccessful");
        }

        private void FormEnrollment_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.dgvshow.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            var cId = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            var cname = this.dgvshow.CurrentRow.Cells[1].Value.ToString();
            var cFee = this.dgvshow.CurrentRow.Cells[2].Value.ToString();
            var sql = "insert into Courses values('" + cId + "','" + cname + "','" + cFee + "','" + this.Id + "');";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show("Course Enrollment Successful");
            }
            else MessageBox.Show("Course Enrollment Unuccessful");


        }
    }
}
