using MySql.Data.MySqlClient;
using Renci.SshNet.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WoerterbuchData
{
    public class WoerterbuchRepositiory
    {
        Dictionary<Word, List<Word>> dict = new Dictionary<Word, List<Word>>();
        Dictionary<Word, Word> newDict = new Dictionary<Word, Word>();


        public void SaveData(Dictionary<Word, List<Word>> exportDictionary, Dictionary<Word, Word> updateDictionary)
        {
            string connstring = "Server=localhost; database=woerterbuch; UID=root";
            var connection = new MySqlConnection(connstring);
            connection.Open();
            var command = connection.CreateCommand();
            var german = "DE";
            var english = "EN";
            var schwedish = "SW";

            foreach (var word in exportDictionary)
            {
                List<Word> translations = word.Value;
                //var englishWord = translations[0];
                //var schwedishWord = translations[1];
                //var germanWord = word.Key;               

                //command.CommandText = $"Insert into word (name, language) Values" +
                //    $" ('{germanWord}', '{german}'), ('{englishWord}', '{english}'), ('{schwedishWord}', '{schwedish}')";
                command.CommandText = $"Insert into word (name, language) Values ('{word.Key.Name}', '{german}')";
                command.ExecuteNonQuery();
                var deId = command.LastInsertedId;
                command.CommandText = $"Insert into word (name, language) Values ('{translations[0].Name}', '{english}')";
                command.ExecuteNonQuery();
                var enId = command.LastInsertedId;
                command.CommandText = $"Insert into word (name, language) Values ('{translations[1].Name}', '{schwedish}')";
                command.ExecuteNonQuery();
                var swId = command.LastInsertedId;

                //command.CommandText = $"SELECT * FROM `word` WHERE (name='{germanWord}' And language='{german}') Or" +
                //    $" (name='{englishWord}' And language={english}) Or (name='{schwedishWord}' And language='{schwedish}')";

                //MySqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    var id = reader.GetValue(0);
                //    var name = reader.GetValue(1);
                //    var language = reader.GetValue(2);

                //    words.Add(new Word() { Id = Convert.ToInt32(id), Name = Convert.ToString(name), Language = Convert.ToString(language) });
                //}

                command.CommandText = $"INSERT into languagelinking (word1_id, word2_id) Values " +
                    $"({deId}, {enId}), ({deId}, {swId}), ({enId}, {swId})";
                command.ExecuteNonQuery();
            }
            foreach (var word in updateDictionary)
            {
                command.CommandText = $"Insert into word (name, language) Values ('{word.Key.Name}', '{word.Key.Language}')";
                command.ExecuteNonQuery();
                var id1 = command.LastInsertedId;
                command.CommandText = $"Insert into word (name, language) Values ('{word.Value.Name}', '{word.Value.Language}')";
                command.ExecuteNonQuery();
                var id2 = command.LastInsertedId;

                command.CommandText = $"INSERT into languagelinking (word1_id, word2_id) Values ({id1}, {id2})";
                command.ExecuteNonQuery();
            }
                connection.Close();
        }

        public Dictionary<Word, List<Word>> GetDictionary()
        {
            string connstring = "Server=localhost; database=woerterbuch; UID=root";
            var connection = new MySqlConnection(connstring);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "Select word1.id, word1.name, word1.language, word2.id, word2.name, word2.language from languagelinking" +
                " inner join word as word1 on languagelinking.word1_id = word1.id" +
                " inner join word as word2 on languagelinking.word2_id = word2.id" +
                $" WHERE(word1.language = 'DE' AND(word2.language = 'EN' OR word2.language = 'SW'))" +
                $" OR(word2.language = 'DE' AND(word1.language = 'EN' OR word1.language = 'SW'));";
                //" WHERE word1.language = 'DE' OR word2.language = 'DE'";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Word keyWord = null;
                Word word = null;
                var id1 = reader.GetValue(0);
                var name1 = reader.GetValue(1);
                var language1 = reader.GetValue(2);

                var id2 = reader.GetValue(3);
                var name2 = reader.GetValue(4);
                var language2 = reader.GetValue(5);

                if (Convert.ToString(language1) == "DE")
                {
                    if (dict.Any(x => x.Key.Name == Convert.ToString(name1)))
                    {
                        keyWord = dict.Keys.FirstOrDefault(x => x.Name == Convert.ToString(name1));
                    }
                    else
                    {
                        keyWord = new Word()
                        {
                            Id = Convert.ToInt32(id1),
                            Name = Convert.ToString(name1),
                            Language = Convert.ToString(language1)
                        };
                    }

                   
                    word = new Word()
                    {
                        Id = Convert.ToInt32(id2),
                        Name = Convert.ToString(name2),
                        Language = Convert.ToString(language2)
                    };
                } else
                {
                    if (dict.Any(x => x.Key.Name == Convert.ToString(name2)))
                    {
                        keyWord = dict.Keys.FirstOrDefault(x => x.Name == Convert.ToString(name2));
                    }
                    else
                    {
                        keyWord = new Word()
                        {
                            Id = Convert.ToInt32(id2),
                            Name = Convert.ToString(name2),
                            Language = Convert.ToString(language2)
                        };
                    }


                    word = new Word()
                    {
                        Id = Convert.ToInt32(id1),
                        Name = Convert.ToString(name1),
                        Language = Convert.ToString(language1)
                    };
                }

                if (!dict.Any(x => x.Key.Name == keyWord.Name))
                {
                    dict.Add(keyWord,
                        new List<Word>()
                        {
                            word
                        });
                }
                else
                {
                    dict[keyWord].Add(word);
                }


            }

            return dict;
        }

        public Dictionary<Word, Word> ReadData(string keyLanguage, string valueLanguage)
        {
            string connstring = "Server=localhost; database=woerterbuch; UID=root";
            var connection = new MySqlConnection(connstring);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "Select word1.id, word1.name, word1.language, word2.id, word2.name, word2.language from languagelinking" +
                " inner join word as word1 on languagelinking.word1_id = word1.id" +
                " inner join word as word2 on languagelinking.word2_id = word2.id" +
                $" WHERE(word1.language = '{keyLanguage}' AND word2.language = '{valueLanguage}')" +
                $" OR (word2.language = '{keyLanguage}' AND word1.language = '{valueLanguage}');";
               
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id1 = reader.GetValue(0);
                var name1 = reader.GetValue(1);
                var language1 = reader.GetValue(2);

                var id2 = reader.GetValue(3);
                var name2 = reader.GetValue(4);
                var language2 = reader.GetValue(5);



                var word1 = new Word()
                {
                    Id = Convert.ToInt32(id1),
                    Name = Convert.ToString(name1),
                    Language = Convert.ToString(language1)
                };


                var word2 = new Word()
                {
                    Id = Convert.ToInt32(id2),
                    Name = Convert.ToString(name2),
                    Language = Convert.ToString(language2)
                };

                if (word1.Language == keyLanguage)
                {
                    newDict.Add(word1, word2);
                } else
                {
                    newDict.Add(word2, word1);
                }                
            }

            return newDict;
        }

        //public Dictionary<string, List<string>> findAll()
        //{
        //    //deliveryTowns.clear();
        //    string connstring = "Server=localhost; database=woerterbuch; UID=root";
        //    var connection = new MySqlConnection(connstring);
        //    connection.Open();
        //    var command = connection.CreateCommand();
        //    command.CommandText = "Select * from delivery where company_book_number_restaurant = '" + restaurant.getCompanyBookNumber() + "';";

        //    MySqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        int postcode = reader.GetInt32 ("post_code");
        //        String town = reader.GetString("town");
        //        int minimumOrderValue = resultSet.getInt("minimum_order_value");
        //        int price = resultSet.getInt("price");
        //        int discountOrderValue = resultSet.getInt("discount_order_value");
        //        int discountPrice = resultSet.getInt("discount_price");
        //        String companyBookNumberRestaurant = resultSet.getString("company_book_number_restaurant");

        //        deliveryTowns.add(new DeliveryService(postcode, town, minimumOrderValue, price, discountOrderValue, discountPrice, companyBookNumberRestaurant));
        //    }

        //    return deliveryTowns;
        //}
    }
}
