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
    public partial class AddWord : Form
    {
        HangmanController controller = new HangmanController();

        public AddWord()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            updateWords();
        }

        private void updateWords()
        {
            lbWords.DataSource = controller.GetWords();
            lbAlphabeth.DataSource = controller.GetAlphabeth();
        }

        private void tbSearchfield_TextChanged(object sender, EventArgs e)
        {
            lbWords.DataSource = controller.FindResults(tbSearchfield.Text, false);
        }

        private void lbAlphabeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchfield.Text = null;
            var selectedIndexList = controller.FindResults(lbAlphabeth.SelectedItem as string, true);
            if (selectedIndexList != null)
            {
                lbWords.DataSource = selectedIndexList;
            }
            else
            {
                updateWords();
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            controller.AddWords(rtbAddWord.Text.Split('\n'));
            rtbAddWord.Text = null;
            updateWords();
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            controller.DeleteWord((HangmanData.Word)lbWords.SelectedItem);
            updateWords();
        }
    }
}
