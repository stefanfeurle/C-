using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WoerterbuchLogic
{
    public class WoerterbuchController
    {
        public string Path { get; set; }       
        private List<string> alphabeth = new List<string> {string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q","R","S","T","U","V","W","X","Y","Z"};

        public WoerterbuchController(string path)
        {
            Path = path;
        }

        /// <summary>
        /// words in dictionary
        /// </summary>
        private Dictionary<string, List<string>> myGermanToEnglishDictionary = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> exportDictionary = new Dictionary<string, List<string>>();

        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public void ReadDictionary()
        {
            string[] myFileContent = File.ReadAllLines(Path);
            foreach (var myFileContentLine in myFileContent)
            {
                string[] splitValue = myFileContentLine.Split(';');
                var germanWord = splitValue[0];
                List<string> translations = new List<string>();
                translations.Add(splitValue[1]);
                translations.Add(splitValue[2]);
                myGermanToEnglishDictionary.Add(germanWord, translations);
            }
        }

        /// <summary>
        /// writes the dictionary to file
        /// </summary>
        public void WriteToFile()
        {
            if (exportDictionary.Count > 0)
            {
                List<string> addFile = new List<string>();
                foreach (var word in exportDictionary)
                {
                    List<string> translations = word.Value;
                    var englishWord = translations[0];
                    var schwedishWord = translations[1];
                    addFile.Add($"{word.Key};{englishWord};{schwedishWord}");
                }
                File.AppendAllLines(Path, addFile);
                exportDictionary.Clear();
            }
        }

        /// <summary>
        /// writes a new word to the dictionary
        /// </summary>
        /// <param name="translation"></param>
        /// <returns></returns>
        public bool addWord(Translation translation)
        {
            bool correctInput = false;
            if (!string.IsNullOrEmpty(translation.GermanWord) && !string.IsNullOrEmpty(translation.EnglishWord) &&
                !string.IsNullOrEmpty(translation.SchwedishWord)) {
                correctInput = true;
                if(!myGermanToEnglishDictionary.ContainsKey(translation.GermanWord)) {
                    List<string> translations = new List<string>();
                    translations.Add(translation.EnglishWord);
                    translations.Add(translation.SchwedishWord);
                    myGermanToEnglishDictionary.Add(translation.GermanWord, translations);
                    exportDictionary.Add(translation.GermanWord, translations);
                }
            }               
            return correctInput;
        }

        /// <summary>
        /// returns translations of a selected word
        /// </summary>
        /// <param name="germanWord"></param>
        /// <returns></returns>
        public List<string> getTranslations(string germanWord)
        {
            return myGermanToEnglishDictionary[germanWord];
        }


        /// <summary>
        /// filters the dictionary and returns a list
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="hasToStartsWith"></param>
        /// <returns></returns>
        public List<string> FindResults(string filterString, bool hasToStartsWith)
        {
            if (hasToStartsWith == true)
            {
                if (!string.IsNullOrEmpty(filterString))
                {
                    var list = myGermanToEnglishDictionary
                        //.Where(x => x.Key.Substring(0, 1).ToUpper().Contains(selectedChar))
                        .Where(x => x.Key.ToUpper().StartsWith(filterString))
                        .Select(y => y.Key).ToList();
                    return list;
                }
            } else
            {
                var list = myGermanToEnglishDictionary
                .Where(x => x.Key.Contains(filterString))
                .Select(y => y.Key).ToList();
                return list;
            }
            return null;
        }


        /// <summary>
        /// returns the alphabet for the filtering
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlphabet()
        {
            return alphabeth;
        }

        /// <summary>
        /// returns the words of the key language in a list
        /// </summary>
        /// <returns></returns>
        public List<string> getKeys()
        {
            return myGermanToEnglishDictionary.Keys.OrderBy(x => x).ToList();
        }
    }
}