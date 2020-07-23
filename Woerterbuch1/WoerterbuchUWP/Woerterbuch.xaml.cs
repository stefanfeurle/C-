using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WoerterbuchLogic;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace WoerterbuchUWP
{
    public sealed partial class MainPage : Page
    {
        WoerterbuchController woerterbuchController = new WoerterbuchController(@"C:\Users\DCV\stefan\IdeaProjects\CodingCampus\6. C#\WoerterbuchUWP\bin\x86\Debug\MeinWoerterbuch.txt");

        public MainPage()
        {
            this.InitializeComponent();
            //var txtFile = OpenLocalFile(@"C: \Users\DCV\stefan\IdeaProjects\CodingCampus\6.C#\WoerterbuchUWP\bin\x86\Debug\*.txt");
            //if (txtFile != null)
            //{
            //    var lines = FileIO.ReadLinesAsync((IStorageFile)txtFile);
            //    // ... Other code
            //}
            //
            //woerterbuchController.ReadDictionary();
            updateTranslations();
        }

        public async Task<StorageFile> OpenLocalFile(params string[] types)
        {
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            Regex typeReg = new Regex(@"^\.[a-zA-Z0-9]+$");
            foreach (var type in types)
            {
                if (type == "*" || typeReg.IsMatch(type))
                    picker.FileTypeFilter.Add(type);
                else
                    throw new InvalidCastException("Invalid extension");
            }
            var file = await picker.PickSingleFileAsync();
            if (file != null)
                return file;
            else
                return null;
        }

        private void updateTranslations()
        {
            woerterbuchController.getKeys().ForEach(x => tbGermanWords.Items.Add(x));
            woerterbuchController.GetAlphabet().ForEach(x => tbAlphabeth.Items.Add(x));
        }

        private void btnAddWord_Click(object sender, RoutedEventArgs e)
        {
            var correctInput = woerterbuchController.addWord(new Translation()
            {
                GermanWord =  tbGermanWord.Text,
                EnglishWord = tbEnglishWord.Text,
                SchwedishWord = tbSchwedishWord.Text
            }); 
            if (correctInput == true)
            {
                updateTranslations();
                //tbGermanWord.Text = null;
                //tbEnglishWord.Text = null;
                //tbSchwedishWord.Text = null;
            }
        }
    

        private void tbSearchField_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbGermanWords.DataContext = woerterbuchController.FindResults(tbSearchField.Text, false);
        }

        private void tbAlphabeth_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //var selectedIndexList = woerterbuchController.FindResults(tbAlphabeth.SelectedText, true);

            //if (selectedIndexList != null)
            //{
            //    tbGermanWords.DataContext = selectedIndexList;
            //}
            //else
            //{
            //    updateTranslations();
            //}
        }

        private void tbGermanWords_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var translations = woerterbuchController.getTranslations((string)tbGermanWords.SelectedValue);
            tbTranslationE.Text = translations[0];
            tbTranslationS.Text = translations[1];
        }

        private void BtnExportToCSV(object sender, RoutedEventArgs e)
        {
            woerterbuchController.WriteToFile();
        }
    }
}
