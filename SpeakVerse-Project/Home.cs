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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl11.Hide();
            userControl21.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl11.Hide();
            userControl31.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
