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
    public partial class FormTeacherMyCourse : Form
    {
        private DataAccess Da { get; set; }

        private string Id { get; set; }

        public FormTeacherMyCourse()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormTeacherMyCourse(string id) : this()
        {
            this.Id = id;
            this.showInfo();

        }

        public void showInfo()
        {
            var sql = "select * from Courses where [Course Teacher] = 'U-002';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvshow.AutoGenerateColumns = false;
            this.dgvshow.DataSource = ds.Tables[0];
        }

        private void FormTeacherMyCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
