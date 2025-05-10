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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 599)
            {
                timer1.Stop();
                Home fm2 = new Home();
                fm2.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
