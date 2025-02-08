using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz_pratice
{
    public partial class QuizForm2 : Form
    {
        private List<Question2> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizForm2()
        {
            InitializeComponent();

            // Initialize medium-level questions
            questions = new List<Question2>
            {
                 new Question2
                {
                    QuestionText = "What is the speed of light in a vacuum?",
                    Options = new[] { "3 × 10^8 m/s", "3 × 10^7 m/s", "3 × 10^6 m/s", "3 × 10^9 m/s" },
                    CorrectAnswerIndex = 0 // 3 × 10^8 m/s is the correct answer
                },
                new Question2
                {
                    QuestionText = "Who developed the uncertainty principle?",
                    Options = new[] { "Werner Heisenberg", "Albert Einstein", "Niels Bohr", "Max Planck" },
                    CorrectAnswerIndex = 0 // Werner Heisenberg is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the largest prime number known?",
                    Options = new[] { "Mersenne Prime", "Germain Prime", "Fermat Prime", "Wilson Prime" },
                    CorrectAnswerIndex = 0 // Mersenne Prime is the correct answer
                },
                new Question2
                {
                    QuestionText = "Which mathematician is known for his work on the four color theorem?",
                    Options = new[] { "Andrew Wiles", "Kurt Gödel", "Sir Michael Atiyah", "Alfred Kempe" },
                    CorrectAnswerIndex = 3 // Alfred Kempe is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the Heisenberg Uncertainty Principle related to?",
                    Options = new[] { "Position and momentum", "Energy and mass", "Time and space", "Force and mass" },
                    CorrectAnswerIndex = 0 // Position and momentum is the correct answer
                },
                new Question2
                {
                    QuestionText = "Who formulated the laws of motion and universal gravitation?",
                    Options = new[] { "Albert Einstein", "Isaac Newton", "Nikola Tesla", "Galileo Galilei" },
                    CorrectAnswerIndex = 1 // Isaac Newton is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the second law of thermodynamics?",
                    Options = new[] { "Energy cannot be created or destroyed", "Entropy always increases", "Heat flows from cold to hot", "Mass and energy are equivalent" },
                    CorrectAnswerIndex = 1 // Entropy always increases is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the purpose of the Large Hadron Collider?",
                    Options = new[] { "Study the Higgs boson", "Study dark matter", "Study quantum mechanics", "Study general relativity" },
                    CorrectAnswerIndex = 0 // Study the Higgs boson is the correct answer
                },
                new Question2
                {
                    QuestionText = "Who proposed the theory of general relativity?",
                    Options = new[] { "Isaac Newton", "Nikola Tesla", "Albert Einstein", "Galileo Galilei" },
                    CorrectAnswerIndex = 2 // Albert Einstein is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the second law of motion according to Newton?",
                    Options = new[] { "Force equals mass times acceleration", "Force equals mass times velocity", "Force equals mass times speed", "Force equals velocity times acceleration" },
                    CorrectAnswerIndex = 0 // Force equals mass times acceleration is the correct answer
                },
                // Biology Questions
                new Question2
                {
                    QuestionText = "Which subatomic particle has a negative charge?",
                    Options = new[] { "Electron", "Proton", "Neutron", "Positron" },
                    CorrectAnswerIndex = 0 // Electron is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the principle behind quantum entanglement?",
                    Options = new[] { "Particles remain linked across distance", "Energy is released when particles collide", "Particles split into two when observed", "Particles travel faster than light" },
                    CorrectAnswerIndex = 0 // Particles remain linked across distance is the correct answer
                },
                new Question2
                {
                    QuestionText = "Who discovered the electron?",
                    Options = new[] { "Isaac Newton", "Marie Curie", "J.J. Thomson", "Albert Einstein" },
                    CorrectAnswerIndex = 2 // J.J. Thomson is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the Schrödinger equation used for?",
                    Options = new[] { "Describing quantum systems", "Describing chemical reactions", "Describing electrical circuits", "Describing fluid dynamics" },
                    CorrectAnswerIndex = 0 // Describing quantum systems is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the wave-particle duality?",
                    Options = new[] { "Light behaves both as a wave and a particle", "Electrons behave only as waves", "Protons behave only as particles", "Light behaves only as a wave" },
                    CorrectAnswerIndex = 0 // Light behaves both as a wave and a particle is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the main function of mitochondria?",
                    Options = new[] { "Protein synthesis", "Energy production", "Cell division", "Gene expression" },
                    CorrectAnswerIndex = 1 // Energy production is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the process by which plants convert light energy into chemical energy?",
                    Options = new[] { "Photosynthesis", "Respiration", "Fermentation", "Transpiration" },
                    CorrectAnswerIndex = 0 // Photosynthesis is the correct answer
                },
                new Question2
                {
                    QuestionText = "Which of the following is a major organ in the human body responsible for detoxification?",
                    Options = new[] { "Liver", "Lungs", "Kidneys", "Pancreas" },
                    CorrectAnswerIndex = 0 // Liver is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the largest structure in the human body?",
                    Options = new[] { "Lungs", "Brain", "Skin", "Heart" },
                    CorrectAnswerIndex = 2 // Skin is the correct answer
                },
                // Additional advanced scientific questions
                new Question2
                {
                    QuestionText = "What is the principle of relativity?",
                    Options = new[] { "The laws of physics are the same in all inertial frames of reference", "Time is absolute and constant", "The speed of light is variable", "Objects at rest experience no force" },
                    CorrectAnswerIndex = 0 // The laws of physics are the same in all inertial frames of reference is the correct answer
                },
                new Question2
                {
                    QuestionText = "Which particle is responsible for carrying the strong nuclear force?",
                    Options = new[] { "Photon", "Gluon", "Graviton", "W-boson" },
                    CorrectAnswerIndex = 1 // Gluon is the correct answer
                },
                new Question2
                {
                    QuestionText = "Which element has the highest atomic number that occurs naturally?",
                    Options = new[] { "Uranium", "Plutonium", "Thorium", "Neptunium" },
                    CorrectAnswerIndex = 0 // Uranium is the correct answer
                },
                new Question2
                {
                    QuestionText = "What is the Heisenberg uncertainty principle a consequence of?",
                    Options = new[] { "Wave-particle duality", "Quantum superposition", "Quantum tunneling", "Relativistic speed limits" },
                    CorrectAnswerIndex = 0 // Wave-particle duality is the correct answer
                },
            };

            // Attach event handlers to buttons
            btnNext.Click += btnNext_Click;
            btnExit.Click += btnExit_Click;
            btnBack.Click += btnBack_Click;

            // Initialize the form load event
            this.Load += new EventHandler(QuizForm2_Load);

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

        private void QuizForm2_Load(object sender, EventArgs e)
        {
            // Any initialization code if needed on form load
        }
    }

    // The Question2 class definition
    public class Question2
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}
