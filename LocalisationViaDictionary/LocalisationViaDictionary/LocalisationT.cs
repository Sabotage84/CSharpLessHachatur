using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationViaDictionary
{
    public static class LocalisationT
    {
        public static string Translation (string line)
        {
            return russian[line]; //Нужен выбор языка, проверка на отсутствие в словаре итд, но мысль такая.
        }

        public static Dictionary<string, string> russian = new Dictionary<string, string>
        {
            ["Hello"] = "Привет!",
            ["Good Bye"] = "Пока!",
            ["Word"] = "Слово"
        };

        public static Dictionary<string, string> english = new Dictionary<string, string>
        {
            ["Hello"] = "Hi!",
            ["Good Bye"] = "Bye!",
            ["Word"] = "Word"
        };
    }
}
