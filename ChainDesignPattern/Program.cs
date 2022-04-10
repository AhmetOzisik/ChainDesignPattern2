using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler mp4Player = new Mp4Player();
            PlayerHandler aviPlayer = new AviPlayer();
            PlayerHandler mpgPlayer = new MpgPlayer();
            mp4Player.SonrakiHnadler = aviPlayer;
            aviPlayer.SonrakiHnadler = mpgPlayer;
            mp4Player.Play("video.mpg");
            mp4Player.Play("video.mp4");
            mp4Player.Play("video.avi");
            mp4Player.Play("video.mpgfgf");
            Console.ReadLine();
        }
    }
}
