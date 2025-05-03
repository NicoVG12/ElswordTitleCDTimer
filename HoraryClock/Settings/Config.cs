using Settings;
using System.ComponentModel;
using System.Diagnostics;

namespace HoraryClock
{
    public class Config
    {
        public const int CHECKED = 1;
        public const int UNCHECKED = 0;

        private static Config _instance = null;

        public int LanguageId { get; set; }
        public int WindowOpacity { get; set; }
        public int PvPOffsett { get; set; }
        public int StartClockOnReset { get; set; }
        public int WindowAlwaysOnTop { get; set; }
        
        public KeyBinding KeyBindings { get; set; }

        public TitleScheme TitleScheme { get; set; }

        public UserActionKeys UserActionKeys { get; set; }

        public int TitleSwitchDelayMilliseconds { get; set; }
        public bool AutomaticModeEnabled { get; set; }

        //TODO: Add SettingsReader and settings file
        private Config() 
        {
            LanguageId = LanguageIds.ENGLISH;
            PvPOffsett = 0;
            StartClockOnReset = 0;
            WindowOpacity = 9;
            WindowAlwaysOnTop = 0;
            KeyBindings = new KeyBinding();
            TitleScheme = new TitleScheme();
            UserActionKeys = new UserActionKeys();
            TitleSwitchDelayMilliseconds = 0;
            AutomaticModeEnabled = true;
        }

        public static Config Instance()
        {
            if ( _instance == null )
            {
                _instance = new Config();
            }
            return _instance;
        }

        public void Load()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("./appconfig");
                WindowOpacity = int.Parse(sr.ReadLine().Split(" ")[1]);
                WindowAlwaysOnTop = int.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.Key13_5 = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.Key15_6 = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.Key17_5 = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.KeyOrder = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.KeyPauseAll = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.KeyUnpauseAll = short.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.KeyResetAll = short.Parse(sr.ReadLine().Split(" ")[1]);
                TitleScheme.TopTitle = short.Parse(sr.ReadLine().Split(" ")[1]);
                TitleScheme.BottomTitle = short.Parse(sr.ReadLine().Split(" ")[1]);
                TitleScheme.LeftTitle = short.Parse(sr.ReadLine().Split(" ")[1]);
                TitleScheme.RightTitle = short.Parse(sr.ReadLine().Split(" ")[1]);
                TitleSwitchDelayMilliseconds = int.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.TitleSwitchKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.AwakeningKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.OnionKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.OnionKeyAlt = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.TopTitleKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.BottomTitleKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.LeftTitleKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                UserActionKeys.RightTitleKey = short.Parse(sr.ReadLine().Split(" ")[1]);
                AutomaticModeEnabled = sr.ReadLine().Split(" ")[1] == "ON";
                string[] specialActiveKeys = sr.ReadLine().Split(" ");

                Console.WriteLine(TitleScheme.TopTitle);

                List<short> skillKeys = new List<short>();
                for (int i = 1; i < specialActiveKeys.Length; i++)
                {
                    skillKeys.Add(short.Parse(specialActiveKeys[i]));
                }

                UserActionKeys.SkillKeys = skillKeys;
            }
            catch (Exception ex )
            {
                LanguageId = LanguageIds.ENGLISH;
                PvPOffsett = 0;
                StartClockOnReset = 0;
                WindowOpacity = 9;
                WindowAlwaysOnTop = 0;
                KeyBindings = new KeyBinding();
                Console.WriteLine("Err: " + ex.Message);
                Save();
                //TODO: Handle wrong config file exception
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public void Save()
        {
            try
            {
                StreamWriter sw = new StreamWriter("./appconfig");
                sw.WriteLine("OPACITY " + WindowOpacity);
                sw.WriteLine("ALWAYS_ON_TOP " + WindowAlwaysOnTop);
                sw.WriteLine("KEY_13-5 " + KeyBindings.Key13_5);
                sw.WriteLine("KEY_15-6 " + KeyBindings.Key15_6);
                sw.WriteLine("KEY_17-5 " + KeyBindings.Key17_5);
                sw.WriteLine("KEY_ORDER " + KeyBindings.KeyOrder);
                sw.WriteLine("KEY_PAUSE_ALL " + KeyBindings.KeyPauseAll);
                sw.WriteLine("KEY_UNPAUSE_ALL " + KeyBindings.KeyUnpauseAll);
                sw.WriteLine("KEY_RESET_ALL " + KeyBindings.KeyResetAll);
                sw.WriteLine("TOP_TITLE " + TitleScheme.TopTitle);
                sw.WriteLine("BOTTOM_TITLE " + TitleScheme.BottomTitle);
                sw.WriteLine("LEFT_TITLE " + TitleScheme.LeftTitle);
                sw.WriteLine("RIGHT_TITLE " + TitleScheme.RightTitle);
                sw.WriteLine("TITLE_SWITCH_DELAY_MILLISECONDS " + TitleSwitchDelayMilliseconds);
                sw.WriteLine("TITLE_SWITCH_KEY " + UserActionKeys.TitleSwitchKey);
                sw.WriteLine("AWAKENING_KEY " + UserActionKeys.AwakeningKey);
                sw.WriteLine("ONION_KEY " + UserActionKeys.OnionKey);
                sw.WriteLine("ONION_ALT_KEY " + UserActionKeys.OnionKeyAlt);
                sw.WriteLine("UP_KEY " + UserActionKeys.TopTitleKey);
                sw.WriteLine("DOWN_KEY " + UserActionKeys.BottomTitleKey);
                sw.WriteLine("LEFT_KEY " + UserActionKeys.LeftTitleKey);
                sw.WriteLine("RIGHT_KEY " + UserActionKeys.RightTitleKey);
                sw.WriteLine("AUTOMATIC_MODE_ENABLED " + (AutomaticModeEnabled ? "ON" : "OFF"));
                //TODO: Handle Special Active Skills Keys Presets

                string specialActiveKeys = "SPECIAL_ACTIVE_KEYS";
                foreach(short key in UserActionKeys.SkillKeys)
                {
                    specialActiveKeys += " " + key;
                }
                sw.WriteLine(specialActiveKeys);

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Err: " + ex.Message);
                //TODO: Handle error while writing file
            }
            //TODO: Save config to a file
        }
    }
}