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
    public partial class FormTeacher : Form
    {

        public string Id { get; set; }
        public FormTeacher()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormTeacher(string id) : this()
        {
            this.Id = id;

        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl111.Hide();
            userControl131.Hide();
            userControl121.Hide();
            userControl31.Hide();
            userControl21.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl111.Hide();
            //userControl131.Show();
            FormTeacherStuLIst Fb = new FormTeacherStuLIst();
            Fb.Show();
            userControl121.Hide();
            userControl31.Hide();
            userControl21.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl111.Hide();
            userControl131.Hide();
            userControl121.Hide();
            userControl31.Hide();
            userControl21.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            //userControl111.Show();
            FormTeacherMyCourse Fc = new FormTeacherMyCourse(this.Id);
            Fc.Show();
            userControl131.Hide();
            userControl121.Hide();
            userControl31.Hide();
            userControl21.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Profile
            userControl41.Hide();
            userControl111.Hide();
            userControl131.Hide();
            //userControl121.Show();
            FormTeacherProfile Fp = new FormTeacherProfile(this.Id);
            Fp.Show();
            userControl31.Hide();
            userControl21.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl111.Hide();
            userControl131.Hide();
            userControl121.Hide();
            userControl31.Show();
            userControl21.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl111.Hide();
            userControl131.Hide();
            userControl121.Hide();
            userControl31.Hide();
            userControl21.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
