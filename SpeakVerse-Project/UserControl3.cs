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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("English");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("French");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("Arabic");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("Korean");
        }

        private void DisplayLanguageDetails(string language)
        {
            Dictionary<string, string> languageDetails = new Dictionary<string, string>
    {
        { "English", "English is an Indo-European language." },
        { "French", "French is a Romance language spoken in France." },
        { "Arabic", "Arabic is a Semitic language spoken in the Arab world." },
        { "Korean", "Korean is the official language of South Korea and North Korea."  },

        { "IELTS", "IELTS is a globally recognized English language proficiency test for non-native English speakers." },
        { "Business Writing", "Business Writing is a course designed to enhance participants' written communication skills in a professional context. " },
        { "Arabic Calligraphy", "Arabic Calligraphy is an artistic course that explores the traditional art of writing in Arabic script. " },
        { "Korean Pop Culture (K-Pop)", "K-Pop Culture is a course that delves into the global phenomenon of Korean popular culture, particularly focusing on K-Pop music and entertainment. "  }
    };

            if (languageDetails.ContainsKey(language))
            {
                string details = languageDetails[language];
                DESCRIPTON.Items.Clear();
                DESCRIPTON.Items.Add(details);
            }
            else
            {
                DESCRIPTON.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("IELTS");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("Business Writing");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("Arabic Calligraphy");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayLanguageDetails("Korean Pop Culture (K-Pop)");
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
