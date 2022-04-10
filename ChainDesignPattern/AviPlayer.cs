using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesignPattern
{
    public class AviPlayer : PlayerHandler
    {
        public override void Play(string FilePath)
        {
            if (FilePath.EndsWith(".avi"))
            {
                Console.WriteLine("avi oynatildi.");
            }
            else
            {
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(FilePath);
            }
        }
    }
}
