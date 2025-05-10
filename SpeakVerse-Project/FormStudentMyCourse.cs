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
    
    public partial class FormStudentMyCourse : Form
    {

        private DataAccess Da { get; set; }

        private string Id { get; set; }
        public FormStudentMyCourse()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormStudentMyCourse(string id) : this()
        {
            this.Id = id;
            this.PopulateGridview();

        }

        private void PopulateGridview()
        {
            var sql = "select * from EnrollCourses";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvshow.AutoGenerateColumns = false;
            this.dgvshow.DataSource = ds.Tables[0];
        }

        private void FormStudentMyCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete
            var id = this.dgvshow.CurrentRow.Cells[0].Value.ToString();
            var sql = "Delete UserInfo where UserID = '" + id + "';";
        }
    }
}
