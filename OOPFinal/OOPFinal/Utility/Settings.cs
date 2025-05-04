using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace OOPFinal.Utility
{
    public class Settings
    {
        private static bool sound;
        private static int theme;
        private static Level level;
        public static void SetSound(bool sound)
        {
            Settings.sound = sound;
        }
        public static void SetLevel(int level)
        {
            if (level == 1)
            {
                Settings.level = Level.Easy;
            }
            else if (level == 2)
            {
                Settings.level = Level.Medium;
            }
            else if (level == 3)
            {
                Settings.level = Level.Hard;
            }
        }
        public static void SetTheme(int theme)
        {
            Settings.theme = theme;
        }
        public static int getTheme()
        {
            return theme;
        }
        public static bool getSound()
        {
            return sound;
        }
    }
    public enum Level
    {
        Easy,
        Medium,
        Hard
    }
}
