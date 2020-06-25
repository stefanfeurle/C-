using HangmanData;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic
{
    public class HangmanController
    {
        HangmanEntities1 entities = new HangmanEntities1();
        Random random = new Random();

        int failedAttempts = 0;
        string key = string.Empty;
        bool isCorrectWord = false;


        //public Dictionary<string,bool> gameAlphabeth { get; set; }
        public Dictionary<string, bool> gameAlphabeth = new Dictionary<string, bool>();
        private List<string> alphabeth = new List<string> {string.Empty, "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q","R","S","T","U","V","W","X","Y","Z"};
        private string hangmanWord;

        public List<Word> GetWords()
        {
            return entities.Word.OrderBy(x => x.Name).ToList();
           
        }

        public List<string> GetAlphabeth()
        {
            return alphabeth;
        }

        public List<Word> FindResults(string filterString, bool hasToStartWith)
        {
            if (!string.IsNullOrEmpty(filterString))
            {
                if (hasToStartWith)
                {
                    return entities.Word
                        .Where(x => x.Name.ToUpper().StartsWith(filterString))
                        .OrderBy(x => x.Name).ToList();
                }
                else
                {
                    return entities.Word
                        .Where(x => x.Name.ToUpper().Contains(filterString.ToUpper()))
                        .OrderBy(x => x.Name).ToList();
                }
            }
            return null;
        }

        public void AddWords(string[] addWords)
        {
            foreach (var item in addWords)
            {                
                if (!entities.Word.Any(x => x.Name.ToUpper() == item.ToUpper()))
                {
                    if (item.Length > 2 && !string.IsNullOrEmpty(item.Trim()))
                    {
                        bool correctWord = true;
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (!alphabeth.Any(x => x == item.ToUpper().Substring(i,1)))
                            {
                                correctWord = false;
                            }
                        }
                        if (correctWord)
                        {
                            entities.Word.Add(new Word() { Name = item.Trim() });
                            entities.SaveChanges();
                        }                        
                    }
                }
            };
        }

        public void DeleteWord(Word selectedItem)
        {
            entities.Word.Remove(selectedItem);
            entities.SaveChanges();
        }

        public string CreateAccount(User user)
        {
            string output = "Der Username existiert schon!";
            if (!entities.User.Any(x => x.UserName == user.UserName))
            {
                entities.User.Add(user);
                entities.SaveChanges();
                output = "Account erfolgreich erstellt!";
            }
            return output;
        }

        public bool Login(User user)
        {
            bool isLogin = false;
            if(entities.User.Any(x => x.UserName == user.UserName && x.PassWord == user.PassWord))
            {
                isLogin = true;
            }
            return isLogin;
        }

        public void GetNewWord()
        {
            failedAttempts = 0;
            key = string.Empty;
            isCorrectWord = false;
            getNewGameAlphabeth();
            var wordsCount = entities.Word.Count();
            int randomNumber = random.Next(wordsCount-1);            
            var list = entities.Word.OrderBy(x => x.Name).ToList();
            int counter = 0;
            foreach (var item in list)
            {
                if (counter == randomNumber)
                {
                    hangmanWord = item.Name;
                }
                counter++;
            }
            
            //list = list.Skip(randomNumber).ToList();
            //var word = (Word)list.Take(1);
            //hangmanWord = word.Name;
            //hangmanWord = list.Skip(randomNumber).Single()  Take(1).ToString();
            //var hangman = entities.Word.OrderBy(x => x.Name).Skip(randomNumber).Take(1);
            //hangmanWord = hangman.ToString();
        }

        private void getNewGameAlphabeth()
        {
            gameAlphabeth.Clear();
            foreach (var item in alphabeth)
            {
                if (item != string.Empty)
                gameAlphabeth.Add(item, false);
            }
        }

        public List<string> GetGameAlphabeth()
        {
            return gameAlphabeth.Where(x => x.Value == false)
                .Select(x => x.Key).ToList();
        }

        public string GetCryptedWord(int attempt)
        {
            string cryptedWord = string.Empty;
            bool isCorrectKey = false;
            int wrongKeys = 0;
            for (int i = 0; i < hangmanWord.Length; i++)
            {
                foreach (var item in gameAlphabeth)
                {
                    
                    if(hangmanWord.ToUpper().Substring(i,1) == item.Key)
                    {
                        if (item.Key == key)
                        {
                            isCorrectKey = true;
                        }
                        if (item.Value)
                        {
                            cryptedWord += item.Key;
                        }
                        else
                        {
                            cryptedWord += "*";
                            wrongKeys++;
                        }
                    }                   
                }
            }
            if (wrongKeys == 0)
            {
                isCorrectWord = true;
            }
            if (!isCorrectKey && attempt > 0 )
            {
                failedAttempts++;
            }
            return cryptedWord;
        }

        public void checkAlphabeth(string selectedItem)
        {
            key = string.Empty;
            foreach (var item in gameAlphabeth)
            {
                if (item.Key == selectedItem)
                {
                    key = item.Key;                   
                }
            }
            gameAlphabeth.Remove(key);
            gameAlphabeth.Add(key, true);
        }

        public int GetFailedAttempts()
        {
            return failedAttempts;           
        }

        public bool GetBoolCorrectWord()
        {
            return isCorrectWord;
        }
    }
}
