using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace game_tictactoe
{
        public class SoundManager
        {
            WindowsMediaPlayer sound;

            public SoundManager(string _filePath)
            {
                sound = new WindowsMediaPlayer();
                sound.URL = _filePath;
            }

            public void Play()
            {
                sound.controls.play();
            }

            public void Stop()
            {
                sound.controls.stop();
            }

            public void Pause()
            {
                sound.controls.pause();
            }

            public void Resume()
            {
                if (sound.status == "Paused")
                    sound.controls.play();
            }
        }
    }
