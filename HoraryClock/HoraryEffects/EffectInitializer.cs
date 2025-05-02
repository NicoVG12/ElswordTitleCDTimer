using Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryEffects
{
    public class EffectInitializer
    {
        public static void InitializeEffects(List<EffectType> effects, LanguageData languageData)
        {
            string[] lightDescription = { languageData.HoraryEffects.CollectionOfLight.Description0 + EffectData.LIGHT_DAMAGE + languageData.HoraryEffects.CollectionOfLight.Description1, "" };
            string[] curseDescription = { languageData.HoraryEffects.VoidOfCurse.Description0 + EffectData.CURSE_DEFENCE_IGNORE + languageData.HoraryEffects.VoidOfCurse.Description1, languageData.HoraryEffects.VoidOfCurse.Description2 + EffectData.CURSE_HITS + languageData.HoraryEffects.VoidOfCurse.Description3 };
            string[] judgementDescription = { languageData.HoraryEffects.Judgement.Description0 + EffectData.JUDGEMENT_COST + languageData.HoraryEffects.Judgement.Description1, "" };
            string[] culminationDescription = { languageData.HoraryEffects.Culmination.Description0 + EffectData.CULMINATION_DAMAGE + languageData.HoraryEffects.Culmination.Description1, languageData.HoraryEffects.Culmination.Description2 + EffectData.CULMINATION_COST + languageData.HoraryEffects.Culmination.Description3 };

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = languageData.HoraryEffects.CollectionOfLight.Name,
                Description = lightDescription,
                Duration = EffectData.LIGHT_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = languageData.HoraryEffects.VoidOfCurse.Name,
                Description = curseDescription,
                Duration = EffectData.CURSE_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = languageData.HoraryEffects.Judgement.Name,
                Description = judgementDescription,
                Duration = EffectData.JUDGEMENT_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = languageData.HoraryEffects.Culmination.Name,
                Description = culminationDescription,
                Duration = EffectData.CULMINATION_DURATION
            });
        }
    }
}
