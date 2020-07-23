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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {           
            var form = new Login();
            form.ShowDialog();                       
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {           
            var form = new AddWord();
            form.ShowDialog();           
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {            
            var form = new HighScore();
            form.ShowDialog();           
        }
    }
}
