using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesignPattern
{
    public class Mp4Player : PlayerHandler
    {
        public override void Play(string FilePath)
        {
            if (FilePath.EndsWith(".mp4"))
            {
                Console.WriteLine("mp4 oynatildi.");
            }
            else
            {
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(FilePath);
            }
        }
    }
}
