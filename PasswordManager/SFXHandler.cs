using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class SFXHandler
    {
        public static void play(UnmanagedMemoryStream sound)
        {
            Stream str = sound;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
    }
}
