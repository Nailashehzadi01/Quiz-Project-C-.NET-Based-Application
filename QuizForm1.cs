using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz_pratice
{
    public partial class QuizForm1 : Form
    {
        private List<Question1> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizForm1()
        {
            InitializeComponent();

            // Initialize medium-level questions
            questions = new List<Question1>
            {
                new Question1
                {
                    QuestionText = "What is the capital of Australia?",
                    Options = new[] { "Sydney", "Melbourne", "Canberra", "Perth" },
                    CorrectAnswerIndex = 2 // Canberra is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the chemical symbol for gold?",
                    Options = new[] { "Au", "Ag", "Fe", "O" },
                    CorrectAnswerIndex = 0 // Au is the correct answer
                },
                new Question1
                {
                    QuestionText = "Which planet is known as the Red Planet?",
                    Options = new[] { "Earth", "Mars", "Jupiter", "Saturn" },
                    CorrectAnswerIndex = 1 // Mars is the correct answer
                },
                new Question1
                {
                    QuestionText = "Who developed the theory of relativity?",
                    Options = new[] { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla" },
                    CorrectAnswerIndex = 1 // Albert Einstein is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the largest ocean on Earth?",
                    Options = new[] { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" },
                    CorrectAnswerIndex = 3 // Pacific Ocean is the correct answer
                },
                new Question1
                {
                    QuestionText = "In which year did World War II end?",
                    Options = new[] { "1939", "1941", "1945", "1950" },
                    CorrectAnswerIndex = 2 // 1945 is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the tallest mountain in the world?",
                    Options = new[] { "K2", "Mount Kilimanjaro", "Mount Everest", "Mount Fuji" },
                    CorrectAnswerIndex = 2 // Mount Everest is the correct answer
                },
                new Question1
                {
                    QuestionText = "Who was the first President of the United States?",
                    Options = new[] { "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams" },
                    CorrectAnswerIndex = 1 // George Washington is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the smallest prime number?",
                    Options = new[] { "1", "2", "3", "5" },
                    CorrectAnswerIndex = 1 // 2 is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the largest planet in our solar system?",
                    Options = new[] { "Earth", "Jupiter", "Saturn", "Neptune" },
                    CorrectAnswerIndex = 1 // Jupiter is the correct answer
                },
                new Question1
                {
                    QuestionText = "Who painted the Mona Lisa?",
                    Options = new[] { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" },
                    CorrectAnswerIndex = 1 // Leonardo da Vinci is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the boiling point of water?",
                    Options = new[] { "100°C", "90°C", "110°C", "120°C" },
                    CorrectAnswerIndex = 0 // 100°C is the correct answer
                },
                new Question1
                {
                    QuestionText = "Which country is the largest by land area?",
                    Options = new[] { "Canada", "United States", "Russia", "China" },
                    CorrectAnswerIndex = 2 // Russia is the correct answer
                },
                new Question1
                {
                    QuestionText = "What is the main ingredient in guacamole?",
                    Options = new[] { "Tomato", "Onion", "Avocado", "Pepper" },
                    CorrectAnswerIndex = 2 // Avocado is the correct answer
                },
                new Question1
                {
                    QuestionText = "Which animal is known as the King of the Jungle?",
                    Options = new[] { "Elephant", "Lion", "Tiger", "Bear" },
                    CorrectAnswerIndex = 1 // Lion is the correct answer
                }
            };

            // Attach event handlers to buttons
            btnNext.Click += btnNext_Click;
            btnExit.Click += btnExit_Click;
            btnBack.Click += btnBack_Click;

            // Initialize the form load event
            this.Load += new EventHandler(QuizForm1_Load);

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

        private void QuizForm1_Load(object sender, EventArgs e)
        {
            // Any initialization code if needed on form load
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }

    // The Question1 class definition
    public class Question1
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}
