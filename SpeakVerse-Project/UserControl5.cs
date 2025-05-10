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
    public partial class UserControl5 : UserControl
    {
        private DataAccess Da {  get; set; }
        private string Id {  get; set; }
        public UserControl5()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public UserControl5(string id) : this()
        {
            this.Id = id;
            
           
        }
        public void showInfo()
        {
            var sql = "select * from UserInfo where UserID = '"+this.Id+"';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.txtname.Text = "sAWON";
            MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
            this.txtname.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
