using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_pratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


                // Check if both Name and ID are entered
                if (string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(txtStudentID.Text))
                {
                    MessageBox.Show("Please enter both Name and ID.");
                }
                else
                {
                    // Store the student information (optional)
                    string studentName = txtStudentName.Text;
                    string studentID = txtStudentID.Text;

                    // Proceed to the Quiz Selection form
                    MessageBox.Show($"Welcome, {studentName}! Your ID: {studentID}");

                    // Hide Form1 (Login Form)
                    this.Hide();

                    // Create and show the QuizSelection Form
                    quizselection quizSelectionForm = new quizselection();
                    quizSelectionForm.Show();
                }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

