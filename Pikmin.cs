using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardTest;

namespace PikminTest
{
    internal class Pikmin : GameCard
    {
        public override void Play()
        {
            Console.WriteLine("ピクミンで遊んだ");
        }
    }
}
