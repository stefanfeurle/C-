using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Login : Form
    {
        HangmanController controller = new HangmanController();

        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Bitte korrekten Namen eintragen!");
            }
            else
            {
                if (tbUserName.Text.Length < 5 || tbPassword.Text.Length < 5)
                {
                    MessageBox.Show("Der Username und das Passwort müssen eine Mindestlänge von 5 Buchstaben haben!");
                }
                else
                {
                    var output = (controller.CreateAccount(new User() 
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        Email = tbEmail.Text,
                        UserName = tbUserName.Text,
                        PassWord = tbPassword.Text
                    }));
                    MessageBox.Show(output);
                    if (output == "Account erfolgreich erstellt!")
                    {
                        tbFirstName.Text = null;
                        tbLastName.Text = null;
                        tbEmail.Text = null;
                        tbUserName.Text = null;
                        tbPassword.Text = null;
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLogin =controller.Login(new User()
            {
                UserName = tbLoginUserName.Text,
                PassWord = tbLoginPassword.Text
            });
            if (!isLogin)
            {
                MessageBox.Show("Username oder Passwort ist falsch!");
            }
            else
            {
                tbLoginUserName.Text = null;
                tbLoginPassword.Text = null;
                var form = new Game();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
