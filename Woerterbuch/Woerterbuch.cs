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

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        Dictionary<string, List<string>> myGermanToEnglishDictionary = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> exportDictionary = new Dictionary<string, List<string>>();

        public Woerterbuch()
        {
            InitializeComponent();
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\MeinWoerterbuch.txt");
            foreach (var myFileContentLine in myFileContent)
            {
                string[] splitValue = myFileContentLine.Split(';');
                var germanWord = splitValue[0];
                List<string> translations = new List<string>();
                translations.Add(splitValue[1]);
                translations.Add(splitValue[2]);
                myGermanToEnglishDictionary.Add(germanWord, translations);
                
            }
            updateTranslations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGermanWord.Text;
            List<string> translations = new List<string>();
            translations.Add(tbEnglishWord.Text);
            translations.Add(tbSchwedishWord.Text);

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(tbEnglishWord.Text) &&
                !string.IsNullOrEmpty(tbSchwedishWord.Text) && !myGermanToEnglishDictionary.ContainsKey(germanWord))
            {
                myGermanToEnglishDictionary.Add(germanWord, translations);
                exportDictionary.Add(germanWord, translations);
                updateTranslations();
            }
            tbGermanWord.Text = null;
            tbEnglishWord.Text = null;
            tbSchwedishWord.Text = null;
        }

        private void updateTranslations()
        {
            lBoxGermanWords.DataSource = myGermanToEnglishDictionary.Keys.ToList();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && myGermanToEnglishDictionary.ContainsKey(selectedWord))
            {
                tbTranslationE.Text = myGermanToEnglishDictionary[selectedWord][0];
                tbTranslationS.Text = myGermanToEnglishDictionary[selectedWord][1];

            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            List<string> addFile = new List<string>();
            foreach (var word in exportDictionary)
            {
                List<string> translations = word.Value;
                var englishWord = translations[0];
                var schwedishWord = translations[1];
                addFile.Add($"{word.Key};{englishWord};{schwedishWord}");  
            }
            System.IO.File.AppendAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\MeinWoerterbuch.txt", addFile);
            exportDictionary.Clear();
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
