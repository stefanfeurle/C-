using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Transactions;
using WoerterbuchData;

namespace WoerterbuchLogic
{
    public class WoerterbuchController
    {
        public string Path { get; set; }       
        private List<string> alphabeth = new List<string> {string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q","R","S","T","U","V","W","X","Y","Z"};
        WoerterbuchRepositiory woerterbuchRepositiory = new WoerterbuchRepositiory();
        string keyLanguage = null;
        string valueLanguage = null;

        public WoerterbuchController(string path)
        {
            Path = path;           
        }


        /// <summary>
        /// words in dictionary
        /// words in list to export
        /// </summary>
        private Dictionary<Word, List<Word>> myGermanToEnglishDictionary = new Dictionary<Word, List<Word>>();
        private Dictionary<Word, List<Word>> exportDictionary = new Dictionary<Word, List<Word>>();
        private Dictionary<Word, Word> myDictionary = new Dictionary<Word, Word>();
        private Dictionary<Word, Word> updateDictionary = new Dictionary<Word, Word>();

        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public void ReadDictionary()
        {
            myGermanToEnglishDictionary = woerterbuchRepositiory.GetDictionary();
            //string[] myFileContent =  System.IO.File.ReadAllLines(Path);
            //foreach (var myFileContentLine in myFileContent)
            //{
            //    string[] splitValue = myFileContentLine.Split(';');
            //    var germanWord = splitValue[0];
            //    List<string> translations = new List<string>();
            //    translations.Add(splitValue[1]);
            //    translations.Add(splitValue[2]);
            //    myGermanToEnglishDictionary.Add(germanWord, translations);
            //}
        }

        /// <summary>
        /// writes the dictionary to file
        /// </summary>
        public void WriteToFileAndSaveData()
        {
            
            if (exportDictionary.Count > 0 || updateDictionary.Count > 0)
            {
                List<string> addFile = new List<string>();
                foreach (var word in exportDictionary)
                {
                    List<Word> translations = word.Value;
                    var englishWord = translations[0].Name;
                    var schwedishWord = translations[1].Name;
                    addFile.Add($"{word.Key.Name};{englishWord};{schwedishWord}");
                }
                File.AppendAllLines(Path, addFile);
                woerterbuchRepositiory.SaveData(exportDictionary, updateDictionary);
                exportDictionary.Clear();
                updateDictionary.Clear();
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
            if (!string.IsNullOrEmpty(translation.GermanWord.Name) && !string.IsNullOrEmpty(translation.EnglishWord.Name) &&
                !string.IsNullOrEmpty(translation.SchwedishWord.Name)) {
                correctInput = true;
                if(!myGermanToEnglishDictionary.Any(x => x.Key.Name == translation.GermanWord.Name)) {
                    List<Word> translations = new List<Word>();
                    translations.Add(translation.EnglishWord);
                    translations.Add(translation.SchwedishWord);
                    myGermanToEnglishDictionary.Add(translation.GermanWord, translations);
                    exportDictionary.Add(translation.GermanWord, translations);
                }
            }               
            return correctInput;
        }

        public string getTranslation(string word)
        {
            var translation = myDictionary
                .FirstOrDefault(x => x.Key.Name == word).Value.Name;
            return translation;
        }

        /// <summary>
        /// returns translations of a selected word
        /// </summary>
        /// <param name="germanWord"></param>
        /// <returns></returns>
        /// 
        public List<Word> getTranslations(string germanWord)
        {
            var list = myGermanToEnglishDictionary
                 .Where(x => x.Key.Name == germanWord)
                 .SelectMany(x => x.Value).ToList();
            //List<Word> translations = new List<Word>();
            //foreach (var item in myGermanToEnglishDictionary)
            //{
            //    if (item.Key.Name == germanWord)
            //    {
            //        translations = item.Value;
            //    }
            //}
            return list;
            //var stringy = GetMyIEnumerable().Where(x => x.Contains("l")).ToList();
        }



        //public IEnumerable<string> GetMyIEnumerable()
        //{
        //    var stringList = new List<string>() { "lala", "lulu", "lili" };

        //    return stringList.Where(x => x.StartsWith("la"));
        //    //GetGenericList<string>(c => c.StartsWith("lala"));
        //    //GetGenericList<string>(c => c.Contains("lala"));
        //    //var transList = GetGenericList<Translation>(c => c.EnglishWord == "hello");
        //    //GetGenericList<string>(c => c.Contains("lala"));
        //}

        //public IEnumerable<T> GetGenericList<T>(Func<T, bool> func)
        //{
        //    var stringList = new List<string>() { "lala", "lulu", "lili" };
        //    return stringList.Where(func);
        //}
        /// <summary>
        /// filters the dictionary and returns a list
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="hasToStartsWith"></param>
        /// <returns></returns>
        public List<string> FindValue(string filterString, bool hasToStartsWith)
        {
            if (hasToStartsWith)
            {
                if (!string.IsNullOrEmpty(filterString))
                {
                    var list = myDictionary
                        .Where(x => x.Key.Name.ToUpper().StartsWith(filterString))
                        .Select(y => y.Key.Name);
                    return list.OrderBy(x => x).ToList();
                }                
            } else
            {
                var list = myDictionary
                .Where(x => x.Key.Name.Contains(filterString))
                .Select(y => y.Key.Name).ToList();
                return list.OrderBy(x => x).ToList();
            }

            if (string.IsNullOrEmpty(filterString))
            {
                var list = myDictionary
                       .Select(x => x.Key.Name);
                return list.OrderBy(x => x).ToList();
            }
            return null;
        }
        public List<string> FindResults(string filterString, bool hasToStartsWith)
        {
            if (hasToStartsWith)
            {
                if (!string.IsNullOrEmpty(filterString))
                {
                    //var stefan = "null";
                    //var stefanNew = stefan ?? "null1";
                    var list = myGermanToEnglishDictionary
                        //.Where(x => x.Key.Substring(0, 1).ToUpper().Contains(filterString))
                        .Where(x => x.Key.Name.ToUpper().StartsWith(filterString))
                        .Select(y => y.Key.Name);
                    //var myStringArray = new string[10];
                    //var myStringArray1 = new string[] { "stefan", "marting", "AG" };
                    return list.ToList();
                }
            } else
            {
                var list = myGermanToEnglishDictionary
                .Where(x => x.Key.Name.Contains(filterString))
                .Select(y => y.Key.Name).ToList();
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
            var list = new List<string>();
            list.AddRange(alphabeth);
            return list;
        }

        /// <summary>
        /// returns the words of the key language in a list
        /// </summary>
        /// <returns></returns>
        public List<string> getKeys()
        {
            var list = myGermanToEnglishDictionary
                       .Select(x => x.Key.Name);
            return list.OrderBy(x => x).ToList();
        }

        public void UpdateDictionary(string language1, string language2)
        {            
            if (language1 != keyLanguage || language2 != valueLanguage) {
                myDictionary.Clear();
                myDictionary = woerterbuchRepositiory.ReadData(language1, language2);
            }
        }

        public bool AddNewWord(Word word1, Word word2)
        {
            bool correctInput = false;
            if (!string.IsNullOrEmpty(word1.Name) && !string.IsNullOrEmpty(word2.Name) && word1.Language != word2.Language)
            {
                correctInput = true;
                if ((!myDictionary.Any(x => x.Key.Name == word1.Name)) && (!myDictionary.Any(x => x.Value.Name == word2.Name)))
                {
                    myDictionary.Add(word1, word2);
                    updateDictionary.Add(word1, word2);
                }              
                //if (!myGermanToEnglishDictionary.Any(x => x.Key.Name == translation.GermanWord.Name))
                //{
                //    List<Word> translations = new List<Word>();
                //    translations.Add(translation.EnglishWord);
                //    translations.Add(translation.SchwedishWord);
                //    myGermanToEnglishDictionary.Add(translation.GermanWord, translations);
                //    exportDictionary.Add(translation.GermanWord, translations);
                //}
            }
            return correctInput;
        }
    }   
}