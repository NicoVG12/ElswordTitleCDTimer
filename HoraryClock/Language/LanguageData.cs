using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public class LanguageData
    {
        public string Name { get; set; }
        public string SampleMessage { get; set; }
        public ClockWindowData ClockWindow { get; set; } = new ClockWindowData();
        public HoraryEffectsData HoraryEffects { get; set; } = new HoraryEffectsData();
        public SettingsData Settings { get; set; } = new SettingsData();
        public ClockSettingsData ClockSettings { get; set; } = new ClockSettingsData();
        public KeySettingsData KeySettings { get; set; } = new KeySettingsData();

        public class ClockWindowData
        {
            public string NotStartedYet { get; set; }
            public string NoEffectsApplied { get; set; }
            public string RemainingTime { get; set; }
            public string Start { get; set; }
            public string Pause { get; set; }
            public string Reset { get; set; }
        }

        public class HoraryEffectsData
        {
            public CollectionOfLightData CollectionOfLight { get; set; } = new CollectionOfLightData();
            public VoidOfCurseData VoidOfCurse { get; set; } = new VoidOfCurseData();
            public JudgementData Judgement { get; set; } = new JudgementData();
            public CulminationData Culmination { get; set; } = new CulminationData();

            public class CollectionOfLightData
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
            }

            public class VoidOfCurseData
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
                public string Description2 { get; set; }
                public string Description3 { get; set; }
            }

            public class JudgementData
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
            }

            public class CulminationData
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
                public string Description2 { get; set; }
                public string Description3 { get; set; }
            }
        }

        public class SettingsData
        {
            public string Language { get; set; }
            public string Clock { get; set; }
            public string KeyBindings { get; set; }
            public string Other { get; set; }
            public string Return { get; set; }
            public string Save { get; set; }
        }

        public class ClockSettingsData
        {
            public PvPOffsetData PvPOffset { get; set; } = new PvPOffsetData();
            public StartClockOnResetData StartOnClockReset { get; set; } = new StartClockOnResetData();
            public WindowOpacityData WindowOpacity { get; set; } = new WindowOpacityData(); 
            public WindowAlwaysOnTopData WindowAlwaysOnTop { get; set; } = new WindowAlwaysOnTopData();

            public class PvPOffsetData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            };

            public class StartClockOnResetData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public class WindowOpacityData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public class WindowAlwaysOnTopData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }
        }

        public class KeySettingsData
        {
            public StartKeyData StartKey { get; set; } = new StartKeyData();
            public PauseKeyData PauseKey { get; set; } = new PauseKeyData();
            public ResetKeyData ResetKey { get; set; } = new ResetKeyData();


            public class StartKeyData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public class PauseKeyData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public class ResetKeyData
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public string KeysAllowed { get; set; }
            public string CannotBoundSameKeyToMultipleActions { get; set; }
        }
    }
}
