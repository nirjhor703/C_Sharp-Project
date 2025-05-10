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
    public partial class FormStudent : Form
    {
        public string Id { get; set; }
        public FormStudent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormStudent(string id) : this()
        {
            this.Id = id;

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl31.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Show();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
           userControl81.Hide();
           new FormEnrollment(this.Id).Show();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
            userControl81.Hide();
            //userControl91.Show();
            new FormStudentProfile(this.Id).Show();
            userControl21.Hide();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Show();
            userControl101.Hide();
            userControl111.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Show();
            userControl111.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl31.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl21.Hide();
            userControl101.Hide();
            //userControl111.Show();
            FormStudentMyCourse Fd = new FormStudentMyCourse(this.Id);
            Fd.Show();
        }
    }
}
