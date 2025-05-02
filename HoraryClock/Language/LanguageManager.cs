using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public class LanguageManager
    {
        public const int LANGUAGE_AMOUNT = 11;

        private static LanguageManager _instance;
        private List<LanguageData> Languages { get; set ; } = new List<LanguageData>();
        private LanguageManager() { }

        public static LanguageManager Instance()
        {
            if (_instance == null)
            {
                _instance = new LanguageManager();
            }
            return _instance;
        }

        public void LoadLanguages()
        {
            LanguageLoader languageLoader = new LanguageLoader();

            for(int i = 0; i < LANGUAGE_AMOUNT; i++)
            {
                LanguageData languageData = languageLoader.LoadData("Languages/" + i + ".txt");
                Languages.Add(languageData);
            }
        }

        public LanguageData GetLanguageData(int id)
        {
            return Languages[id];
        }
    }
}
