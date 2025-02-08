using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_pratice
{
    public partial class quizselection : Form
    {
        public quizselection()
        {
            InitializeComponent();
        }

        private void quizselection_Load(object sender, EventArgs e)
        {
            // Code to initialize the form, if needed.
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the Low level!");
            // Add logic to navigate to the quiz or load questions for Low level.
            var newform = new QuizForm();
            newform.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the Medium level!");
            // Add logic to navigate to the quiz or load questions for Medium level.
            var newform = new QuizForm1();
            newform.Show();

           
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the Hard level!");
            // Add logic to navigate to the quiz or load questions for Hard level.
            var newform = new QuizForm2();
            newform.Show();
        }
        // Create and show the QuizSelection Form
        

    }
}
