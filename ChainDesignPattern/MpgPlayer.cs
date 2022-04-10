using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesignPattern
{
    public class MpgPlayer : PlayerHandler
    {
        public override void Play(string FilePath)
        {
            if (FilePath.EndsWith(".mpg"))
            {
                Console.WriteLine("mpg oynatildi.");
            }
            else
            {
                Console.WriteLine("gecersiz");
               
            }
        }
    }
}
