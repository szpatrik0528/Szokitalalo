using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szo_kitalalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words = new[] { "fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska",
                                "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly",
                                "ecetes", "angyal", "boglya" };

        int index = 0, score = 0;
        Random random = new Random();

        private void button_next_Click(object sender, EventArgs e)
        {
            checkWord();
            if (index < words.Length - 1)
            {
                index++;
                displayWord();
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label_result.Text = "Result";
            label_result.BackColor = Color.Peru;
            label_score.Text = "00";
            displayWord();
            button_next.Enabled = true;
            button_start.Enabled = false;
        }
        public void displayWord()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);

            string word = words[index];

            word = word.Remove(pos1, 1).Insert(pos1, ".");
            word = word.Remove(pos2, 1).Insert(pos2, ".");
            word = word.Remove(pos3, 1).Insert(pos3, ".");

            label_word.Text = word;

        }

         public void checkWord()
        {
            if(textBox_guess.Text.ToLower().Equals(words[index]))
            {
                label_result.Text = "Correct";
                label_result.BackColor = Color.Green;
                score++;
            }
            else
            {
                label_result.Text = "Wrong";
                label_result.BackColor = Color.Red;
            }
            if(index == words.Length - 1)
            {
                button_start.Enabled = true;
                button_next.Enabled = false;
            }
            textBox_guess.Text = "";
            label_score.Text = score.ToString() + " / " + words.Length.ToString();
        }
    }
}
