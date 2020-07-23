using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoerterbuchData;
using WoerterbuchLogic;

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        WoerterbuchController woerterbuchController;

        public Woerterbuch()
        {
            InitializeComponent();
            var filePath = ConfigurationManager.AppSettings.Get("FilePath");
            woerterbuchController = new WoerterbuchController(filePath);
            woerterbuchController.ReadDictionary();
            updateTranslations();
            ConfigurationManager.AppSettings.Get("Languages").Split(';').ToList().ForEach(x => cbLanguage2.Items.Add(x));
            var languages = ConfigurationManager.AppSettings.Get("Languages");
            var languagesArray = languages.Split(';');
            foreach (var item in languagesArray)
            {
                cbLanguage1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var correctInput = woerterbuchController.addWord(tbGermanWord.Text, tbEnglishWord.Text, tbSchwedishWord.Text);
            var germanWord = new Word()
            {
                Name = tbGermanWord.Text,
                Language = "DE"
            };

            var englishWord = new Word()
            {
                Name = tbEnglishWord.Text,
                Language = "EN"
            };

            var schwedishWord = new Word()
            {
                Name = tbSchwedishWord.Text,
                Language = "SW"
            };

            var correctInput = woerterbuchController.addWord(new Translation()
            {
                GermanWord = germanWord,
                EnglishWord = englishWord ,
                SchwedishWord = schwedishWord
            });

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
            lbAlphabeth1.DataSource = woerterbuchController.GetAlphabet();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var translations = woerterbuchController.getTranslations(lBoxGermanWords.SelectedItem as string);
            if (translations.Count == 2)
            {
                if (translations[0].Language == "EN")
                {
                    tbTranslationE.Text = translations[0].Name;
                    tbTranslationS.Text = translations[1].Name;
                }
                else
                {
                    tbTranslationE.Text = translations[1].Name;
                    tbTranslationS.Text = translations[0].Name;
                }
            } else
            { 
                if (translations[0].Language == "EN")
                {
                    tbTranslationE.Text = translations[0].Name;
                    tbTranslationS.Text = null;
                }
                else
                {
                    tbTranslationE.Text = null;
                    tbTranslationS.Text = translations[0].Name;
                }
            }            
        }



        private void btnExportToCSVAndSaveData_Click(object sender, EventArgs e)
        {
            woerterbuchController.WriteToFileAndSaveData();
        }

        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            lBoxGermanWords.DataSource = woerterbuchController.FindResults(tbSearchField.Text, false);
        }

        private void btnAddWord2_Click(object sender, EventArgs e)
        {
            woerterbuchController.UpdateDictionary((string)cbLanguage1.SelectedItem, (string)cbLanguage2.SelectedItem);
            var word1 = new Word()
            {
                Name = tbWord1.Text,
                Language = (string)cbLanguage1.SelectedItem
            };

            var word2 = new Word()
            {
                Name = tbWord2.Text,
                Language = (string)cbLanguage2.SelectedItem
            };
            var correctInput = woerterbuchController.AddNewWord(word1,word2);
            if (correctInput)
            {
                tbWord1.Text = null;
                tbWord2.Text = null;
            }
        }
        
        private void lBoxAlphabeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchField.Text = null;            
            var selectedIndexList = woerterbuchController.FindResults(lBoxAlphabeth.SelectedItem as string, true);

            if(selectedIndexList != null)
            {
                lBoxGermanWords.DataSource = selectedIndexList;
            } else
            {
                updateTranslations();
            }
        }

        private void lbAlphabeth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)cbLanguage1.SelectedItem != null) && ((string)cbLanguage2.SelectedItem != null))
            {
                woerterbuchController.UpdateDictionary((string)cbLanguage1.SelectedItem, (string)cbLanguage2.SelectedItem);
                tbSearchfield1.Text = null;
                var selectedList = woerterbuchController.FindValue(lbAlphabeth1.SelectedItem as string, true);

                if (selectedList != null)
                {
                    lBoxWords.DataSource = selectedList;
                }
                else
                {
                    updateTranslations();
                }
            }
        }

        private void tbSearchfield1_TextChanged(object sender, EventArgs e)
        {
            if (((string)cbLanguage1.SelectedItem != null) && ((string)cbLanguage2.SelectedItem != null))
            {
                woerterbuchController.UpdateDictionary((string)cbLanguage1.SelectedItem, (string)cbLanguage2.SelectedItem);
                lBoxWords.DataSource = woerterbuchController.FindValue(tbSearchfield1.Text, false);
            }
        }

        private void lBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)cbLanguage1.SelectedItem != null) && ((string)cbLanguage2.SelectedItem != null))
            {
                woerterbuchController.UpdateDictionary((string)cbLanguage1.SelectedItem, (string)cbLanguage2.SelectedItem);
                var translation = woerterbuchController.getTranslation(lBoxWords.SelectedItem as string);
                tbTranslation.Text = translation;
            }
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
