using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace OOPFinal
{
    public class Settings
    {
        private static bool sound;
        private static int theme;
        public static void SetSound(bool sound)
        {
            Settings.sound = sound;
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
}
