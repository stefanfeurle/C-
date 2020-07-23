using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Game : Form
    {
        HangmanController controller = new HangmanController();
        int attempt = 0;

        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            UpdateGame();
        }

        private void UpdateGame()
        {
            var attemptString = Convert.ToString(attempt);
            tbAttempt.Text = attemptString;
            var failedAttempts = controller.GetFailedAttempts();
            var failedAttemptsString = Convert.ToString(failedAttempts);
            string file = $"C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\hangman4\\hangman{failedAttemptsString}.jpg";
            pictureBoxHangman.Image = Image.FromFile(file);
            var isCorrectWord = controller.GetBoolCorrectWord();
            if (isCorrectWord)
            {
                MessageBox.Show("Gratuliere");
                StartGame();
            }
            if (failedAttempts == 10)
            {
                MessageBox.Show("GAME OVER");
                StartGame();
            }
        }

        private void getGameAlphabeth()
        {
            var alphabeth = controller.GetGameAlphabeth();
            cboxAlphabeth.Items.Clear();
            cboxAlphabeth.SelectedItem = "";
            foreach (var item in alphabeth)
            {
                if (item != string.Empty)
                    cboxAlphabeth.Items.Add(item);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            attempt = 0;
            controller.GetNewWord();
            getGameAlphabeth();
            tbCryptedWord.Text = controller.GetCryptedWord(attempt);
            UpdateGame();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if((string)cboxAlphabeth.SelectedItem != null)
            {
                controller.checkAlphabeth((string)cboxAlphabeth.SelectedItem);
                getGameAlphabeth();
                attempt++;
                tbCryptedWord.Text = controller.GetCryptedWord(attempt);
                UpdateGame();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new HighScore();
            form.ShowDialog();
        }
    }
}
