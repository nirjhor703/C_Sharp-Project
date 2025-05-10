using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectSpeakVerse
{
    
    public partial class FormUpdate : Form
    {
        private DataAccess Da { get; set; }

        private string Id { get; set; }
        public FormUpdate()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormUpdate(string id) : this() 
        { 
            this.Id = id;
            this.show();
        }
        private void show()
        {
            var sql = "select * from UserInfo where UserID='"+this.Id+"';";
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.txtMail.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtContact.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtPass.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var sql = "Update UserInfo set Password = '"+this.txtPass.Text+"',Email = '"+this.txtMail.Text+"',Number = '"+this.txtContact.Text+"' where UserID = '"+this.Id+"';";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if(cnt ==1) MessageBox.Show("Information saved");
            else MessageBox.Show("Somethign Error");

        }
    }
}
