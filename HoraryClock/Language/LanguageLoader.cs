using static Language.LanguageData;

namespace Language
{
    public class LanguageLoader
    {
        public LanguageData LoadData(string path)
        {
            LanguageData languageData = new LanguageData();

            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();

                languageData.Name = sr.ReadLine();
                languageData.SampleMessage = sr.ReadLine();

                sr.ReadLine();
                sr.ReadLine();

                languageData.ClockWindow.NotStartedYet = sr.ReadLine();
                languageData.ClockWindow.NoEffectsApplied = sr.ReadLine();
                languageData.ClockWindow.RemainingTime = sr.ReadLine();
                languageData.ClockWindow.Start = sr.ReadLine();
                languageData.ClockWindow.Pause = sr.ReadLine();
                languageData.ClockWindow.Reset = sr.ReadLine();

                sr.ReadLine();
                sr.ReadLine();

                languageData.HoraryEffects.CollectionOfLight.Name = sr.ReadLine();
                languageData.HoraryEffects.CollectionOfLight.Description0 = sr.ReadLine();
                languageData.HoraryEffects.CollectionOfLight.Description1 = sr.ReadLine();

                languageData.HoraryEffects.VoidOfCurse.Name = sr.ReadLine();
                languageData.HoraryEffects.VoidOfCurse.Description0 = sr.ReadLine();
                languageData.HoraryEffects.VoidOfCurse.Description1 = sr.ReadLine();
                languageData.HoraryEffects.VoidOfCurse.Description2 = sr.ReadLine();
                languageData.HoraryEffects.VoidOfCurse.Description3 = sr.ReadLine();

                languageData.HoraryEffects.Judgement.Name = sr.ReadLine();
                languageData.HoraryEffects.Judgement.Description0 = sr.ReadLine();
                languageData.HoraryEffects.Judgement.Description1 = sr.ReadLine();

                languageData.HoraryEffects.Culmination.Name = sr.ReadLine();
                languageData.HoraryEffects.Culmination.Description0 = sr.ReadLine();
                languageData.HoraryEffects.Culmination.Description1 = sr.ReadLine();
                languageData.HoraryEffects.Culmination.Description2 = sr.ReadLine();
                languageData.HoraryEffects.Culmination.Description3 = sr.ReadLine();

                sr.ReadLine();
                sr.ReadLine();

                languageData.Settings.Language = sr.ReadLine();
                languageData.Settings.Clock = sr.ReadLine();
                languageData.Settings.KeyBindings = sr.ReadLine();
                languageData.Settings.Other = sr.ReadLine();
                languageData.Settings.Return = sr.ReadLine();
                languageData.Settings.Save = sr.ReadLine();

                sr.ReadLine();
                sr.ReadLine();

                languageData.ClockSettings.PvPOffset.Name = sr.ReadLine();
                languageData.ClockSettings.PvPOffset.Description = sr.ReadLine();
                languageData.ClockSettings.StartOnClockReset.Name = sr.ReadLine();
                languageData.ClockSettings.StartOnClockReset.Description = sr.ReadLine();
                languageData.ClockSettings.WindowOpacity.Name = sr.ReadLine();
                languageData.ClockSettings.WindowOpacity.Description = sr.ReadLine();
                languageData.ClockSettings.WindowAlwaysOnTop.Name = sr.ReadLine();
                languageData.ClockSettings.WindowAlwaysOnTop.Description = sr.ReadLine();

                sr.ReadLine();
                sr.ReadLine();

                languageData.KeySettings.StartKey.Name = sr.ReadLine();
                languageData.KeySettings.StartKey.Description = sr.ReadLine();
                languageData.KeySettings.PauseKey.Name = sr.ReadLine();
                languageData.KeySettings.PauseKey.Description = sr.ReadLine();
                languageData.KeySettings.ResetKey.Name = sr.ReadLine();
                languageData.KeySettings.ResetKey.Description = sr.ReadLine();
                languageData.KeySettings.KeysAllowed = sr.ReadLine();
                languageData.KeySettings.CannotBoundSameKeyToMultipleActions = sr.ReadLine();
            }
            catch (Exception ex)
            {
                //TODO: Handle wrong language file exception
            }

            return languageData;
        }
    }
}