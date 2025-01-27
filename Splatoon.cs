using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardTest;

namespace SplatoonTest
{
    internal class Splatoon : GameCard
    {
        public override void Play()
        {
            Console.WriteLine("スプラトゥーンで遊んだ");
        }
    }
}
