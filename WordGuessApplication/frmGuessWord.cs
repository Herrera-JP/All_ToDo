using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

       
        private string[] words = new string[]
        {
            "polymorphism",
            "encapsulation",
            "inheritance",
            "asynchronous",
            "multithreading",
            "serialization",
            "abstraction",
            "recursion",
            "compilation",
            "dependency"
        };

        private string wordToGuess = "";
        private Random rng = new Random();

        private string PickRandomWord()
        {
            int index = rng.Next(0, words.Length);
            return words[index];
        }

        
        private void DisplayGuessWord()
        {
            StringBuilder maskedWord = new StringBuilder(wordToGuess);

            for (int i = 0; i < maskedWord.Length; i++)
            {
                if (rng.Next(0, 2) == 0) 
                    maskedWord[i] = '?';
            }

            lblWord.Text = maskedWord.ToString();
        }

        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            wordToGuess = PickRandomWord();
            DisplayGuessWord();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();

            if (string.IsNullOrWhiteSpace(guess))
            {
                MessageBox.Show("Please enter a word.\nInput Required");
                return;
            }

            
            if (lblWord.Text == wordToGuess)
            {
                MessageBox.Show("Start a new game!");
                return;
            }

            if (guess == wordToGuess)
            {
                lblWord.Text = wordToGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {
               
                if (lstWrong.Items.Contains(guess))
                {
                    MessageBox.Show("You already guessed that word!");
                    return;
                }

                MessageBox.Show("Wrong guess! Try again.");
                lstWrong.Items.Add(guess);
            }

            txtGuess.Clear();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            wordToGuess = PickRandomWord();
            DisplayGuessWord();
            lstWrong.Items.Clear();
            txtGuess.Clear();
        }

       
    }
}