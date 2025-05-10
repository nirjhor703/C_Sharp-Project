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
    public partial class FormAdmin : Form
    {
        public string Id { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FormAdmin(string id) : this()
        {
            this.Id = id;
           
            
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl31.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl21.Hide();
            userControl51.Hide();
            userControl31.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Show();
            userControl51.Hide();
            userControl31.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Hide();
            FormAdminProfile Fa = new FormAdminProfile(this.Id); 
            Fa.Show();
            //userControl51.Show();
            userControl31.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl31.Show();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl31.Hide();
            //userControl61.Show();
            FormAdminTeacherInfo fs = new FormAdminTeacherInfo();
            fs.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl31.Hide();
            new FormTeacherStuLIst("77").Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userControl71_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl61_Load(object sender, EventArgs e)
        {

        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }
    }
}
