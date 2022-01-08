using System;
using System.Collections.Generic;

namespace English_01_Opposites
{
    class Program
    {
        private static string _word = "";
        private static int _score;
        private static readonly Random Rand = new Random();
        static void Main()
        {
            Console.Title = "OPPOSITES | ENTER \"help\" TO TRANSLATE | SCORE: " + _score;
            Console.Write("ENTER THE NUMBERS OF POINT TO WIN: ");
            int maxScore = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Dictionary<int, string> words1 = new Dictionary<int, string>()
            {
                [0] = "short",
                [1] = "black",
                [2] = "good",
                [3] = "little",
                [4] = "old",
                [5] = "sad",
                [6] = "poor",
                [7] = "slow",
                [8] = "easy",
                [9] = "ugly",
                [10] = "wrong",
                [11] = "dry",
                [12] = "long",
                [13] = "dirty",
                [14] = "boring",
                [15] = "hot",
                [16] = "bright",
                [17] = "lazy",
                [18] = "sour",
                [19] = "dead",
                [20] = "brave",
                [21] = "female",
                [22] = "soft",
                [23] = "far",
                [24] = "shallow",
                [25] = "light",
                [26] = "narrow",
                [27] = "thin",
                [28] = "new",
                [29] = "loud",
                [30] = "clever",
                [31] = "cheap",
                [32] = "rude",
                [33] = "high",
                [34] = "weak",
                [35] = "dangerous",
                [36] = "empty",
            };
            Dictionary<int, string> words2 = new Dictionary<int, string>()
            {
                [0] = "tall",
                [1] = "white",
                [2] = "bad",
                [3] = "big",
                [4] = "young",
                [5] = "happy",
                [6] = "rich",
                [7] = "fast",
                [8] = "difficult",
                [9] = "beautiful",
                [10] = "right",
                [11] = "wet",
                [12] = "short",
                [13] = "clean",
                [14] = "interesting",
                [15] = "cold",
                [16] = "dark",
                [17] = "hardworking",
                [18] = "sweet",
                [19] = "alive",
                [20] = "shy",
                [21] = "male",
                [22] = "hard",
                [23] = "near",
                [24] = "deep",
                [25] = "heavy",
                [26] = "wide",
                [27] = "fat",
                [28] = "old",
                [29] = "silent",
                [30] = "silly",
                [31] = "expensive",
                [32] = "polite",
                [33] = "low",
                [34] = "strong",
                [35] = "safe",
                [36] = "full",
            };
            Dictionary<int, string> words3 = new Dictionary<int, string>()
            {
                [0] = "низкий/высокий",
                [1] = "черный/белый",
                [2] = "хороший/плохой",
                [3] = "маленький/большой",
                [4] = "старый/молодой",
                [5] = "грустный/счастливый",
                [6] = "бедный/богатый",
                [7] = "медленный/быстрый",
                [8] = "легкий/сложный",
                [9] = "уродливый/прекрасный",
                [10] = "неверный/верный",
                [11] = "сухой/мокрый",
                [12] = "длинный/короткий",
                [13] = "грязный/чистый",
                [14] = "скучный/интересный",
                [15] = "горячий/холодный",
                [16] = "светлый/темный",
                [17] = "ленивый/работящий",
                [18] = "кислый/сладкий",
                [19] = "мертвый/живой",
                [20] = "храбрый/робкий",
                [21] = "женский/мужской",
                [22] = "мягкий/жесткий",
                [23] = "дальний/ближний",
                [24] = "мелкий/глубокий",
                [25] = "легкий/тяжелый",
                [26] = "узкий/широкий",
                [27] = "худой/толстый",
                [28] = "новый/старый",
                [29] = "громкий/тихий",
                [30] = "умный/глупый",
                [31] = "дешевый/дорогой",
                [32] = "грубый/вежливый",
                [33] = "высокий/низкий",
                [34] = "слабый/сильный",
                [35] = "опасный/безопасный",
                [36] = "пустой/полный",
            };

            while (_score != maxScore)
            {
                int temp = Rand.Next(0, words1.Count);
                int rand1 = Rand.Next(0, 2);
                if (rand1 == 0)
                {
                    while (_word != words2[temp])
                    {
                        Console.Write(words1[temp] + " : ");
                        _word = Console.ReadLine();
                        if (_word == words2[temp])
                        {
                            Console.Title = "OPPOSITES | ENTER \"help\" TO TRANSLATE | SCORE: " + ++_score;
                            Console.Clear();
                        }
                        if (_word == "help")
                            Console.WriteLine(words3[temp]);
                    }
                }
                if (rand1 == 1)
                {
                    while (_word != words1[temp])
                    {
                        Console.Write(words2[temp] + " : ");
                        _word = Console.ReadLine();
                        if (_word == words1[temp])
                        {
                            Console.Title = "OPPOSITES | ENTER \"help\" TO TRANSLATE | SCORE: " + ++_score;
                            Console.Clear();
                        }
                        if (_word == "help")
                            Console.WriteLine(words3[temp]);
                        
                    }
                }
            }

            Console.WriteLine("YOU WIN. PRESS ANY KEY TO EXIT");

            Console.ReadLine();
        }
    }
}
