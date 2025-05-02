using HoraryClock;
using Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryEffects
{
    public class EffectManager
    {
        private static EffectManager _instance = null;

        public List<EffectType> Effects { get; set; }
        public int CurrentEffectId { get; set; }

        private EffectManager()
        {
            Effects = new List<EffectType>();
            CurrentEffectId = 0;
            EffectInitializer.InitializeEffects(Effects, LanguageManager.Instance().GetLanguageData(Config.Instance().LanguageId));
        }

        public void SetLanguage(LanguageData language)
        {
            Effects = new List<EffectType>();
            EffectInitializer.InitializeEffects(Effects, language);
        }

        public static EffectManager Instance()
        {
            if (_instance == null)
            {
                _instance = new EffectManager();
            }
            return _instance;
        }

        public int NextEffectId()
        {
            return (CurrentEffectId + 1) % Effects.Count;
        }

        public void AdvanceEffect()
        {
            CurrentEffectId = NextEffectId();
        }

        public EffectType CurrentEffect()
        {
            return Effects[CurrentEffectId];
        }

        public void Reset()
        {
            CurrentEffectId = 0;
        }
    }
}
