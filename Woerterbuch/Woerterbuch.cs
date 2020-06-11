using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoerterbuchLogic;

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        WoerterbuchController woerterbuchController = new WoerterbuchController("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\MeinWoerterbuch.txt");

        public Woerterbuch()
        {
            InitializeComponent();
            woerterbuchController.ReadDictionary();
            updateTranslations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var correctInput = woerterbuchController.addWord(tbGermanWord.Text, tbEnglishWord.Text, tbSchwedishWord.Text);
            var correctInput = woerterbuchController.addWord(new Translation() { GermanWord = tbGermanWord.Text,
                EnglishWord = tbEnglishWord.Text, SchwedishWord = tbSchwedishWord.Text});
            if(correctInput == true)
            {
                updateTranslations();
                tbGermanWord.Text = null;
                tbEnglishWord.Text = null;
                tbSchwedishWord.Text = null;
            }           
        }

        private void updateTranslations()
        {
            lBoxGermanWords.DataSource = woerterbuchController.getKeys();
            lBoxAlphabeth.DataSource = woerterbuchController.GetAlphabet();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var translations = woerterbuchController.getTranslations(lBoxGermanWords.SelectedItem as string);
            tbTranslationE.Text = translations[0];
            tbTranslationS.Text = translations[1];
        }

        private void lBoxAlphabeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndexList = woerterbuchController.FindResults(lBoxAlphabeth.SelectedItem as string, true);

            if(selectedIndexList != null)
            {
                lBoxGermanWords.DataSource = selectedIndexList;
            } else
            {
                updateTranslations();
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            woerterbuchController.WriteToFile();
        }

        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            lBoxGermanWords.DataSource = woerterbuchController.FindResults(tbSearchField.Text, false);
        }

      

        //        private void tbGermanWord_MouseMove(object sender, MouseEventArgs e)
        //        {
        //            //tbGermanWord.Hide();
        //            tbGermanWord.Text = "Du depp!";
        //        }

        //        private void tbGermanWord_MouseLeave(object sender, EventArgs e)
        //        {
        //            tbGermanWord.Show();
        //        }

        //private void Woerterbuch_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //            Process.Start("shutdown", "/s /t 0");
        //e.Cancel = true;
        //this.Hide();
        //Thread.Sleep(1000);
        //this.Show();
        //}

        //private void tbGermanWord_Click(object sender, EventArgs e)
        //{
        //tbTranslationE.Select();
        //tbGermanWord.Hide();
        //Process.Start("calc");
        //SendKeys.Send("aaa");
        //}
    }
}
