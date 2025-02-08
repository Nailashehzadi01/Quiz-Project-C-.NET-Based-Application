using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz_pratice
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizForm()
        {
            InitializeComponent();

            // Initialize questions
            questions = new List<Question>
            {
                new Question
                {
                    QuestionText = "What is 2 + 2?",
                    Options = new[] { "3", "4", "5", "6" },
                    CorrectAnswerIndex = 1 // 4 is the correct answer
                },
                new Question
                {
                    QuestionText = "What is the capital of France?",
                    Options = new[] { "Berlin", "Madrid", "Paris", "Rome" },
                    CorrectAnswerIndex = 2 // Paris is the correct answer
                },
                new Question
                {
                    QuestionText = "What color is the sky?",
                    Options = new[] { "Green", "Blue", "Red", "Yellow" },
                    CorrectAnswerIndex = 1 // Blue is the correct answer
                }
            };

            // Attach event handlers to buttons
            btnNext.Click += btnNext_Click;
            btnExit.Click += btnExit_Click;
            btnBack.Click += btnBack_Click;

            // Load the first question
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.QuestionText;
                rbtnOption1.Text = question.Options[0];
                rbtnOption2.Text = question.Options[1];
                rbtnOption3.Text = question.Options[2];
                rbtnOption4.Text = question.Options[3];

                // Reset radio button selection
                rbtnOption1.Checked = false;
                rbtnOption2.Checked = false;
                rbtnOption3.Checked = false;
                rbtnOption4.Checked = false;
            }
            else
            {
                ShowResults();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnOption1.Checked || rbtnOption2.Checked || rbtnOption3.Checked || rbtnOption4.Checked)
            {
                var question = questions[currentQuestionIndex];
                int selectedOptionIndex = -1;

                if (rbtnOption1.Checked) selectedOptionIndex = 0;
                else if (rbtnOption2.Checked) selectedOptionIndex = 1;
                else if (rbtnOption3.Checked) selectedOptionIndex = 2;
                else if (rbtnOption4.Checked) selectedOptionIndex = 3;

                if (selectedOptionIndex == question.CorrectAnswerIndex)
                {
                    score++;
                }

                currentQuestionIndex++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer before proceeding.");
            }
        }

        private void ShowResults()
        {
            MessageBox.Show($"Quiz completed! Your score: {score}/{questions.Count}");
            btnNext.Enabled = false;
            btnExit.Visible = true;
            btnBack.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(); // Go back to the welcome page
        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
            // Add any code here that should run when the form loads
            // For example, initialize controls, load data, etc.
        }

    }

    // The Question class definition (should be in a separate file or same file if small)
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}
