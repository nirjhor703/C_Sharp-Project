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
    public partial class FormAdminProfile : Form
    {
        private DataAccess Da { get; set; }

        private string Id { get; set; }
        public FormAdminProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FormAdminProfile(string id) : this()
        {
            this.Id = id;
            this.showInfo();

        }
    public void showInfo()
        {
            var sql = "select * from UserInfo where UserID = '" + this.Id + "';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.txtname.Text = ds.Tables[0].Rows[0][5].ToString();
            this.txtId.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtEmail.Text =  ds.Tables[0].Rows[0][3].ToString();
            this.txtNum.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new FormUpdate(this.Id).Visible = true;
        }
    }
}
