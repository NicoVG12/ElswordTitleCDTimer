using System.ComponentModel;

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

        //TODO: Add SettingsReader and settings file
        private Config() 
        {
            LanguageId = LanguageIds.ENGLISH;
            PvPOffsett = 0;
            StartClockOnReset = 0;
            WindowOpacity = 9;
            WindowAlwaysOnTop = 0;
            KeyBindings = new KeyBinding();
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