using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardTest;

namespace ShirenTest
{
    internal class Shiren : GameCard
    {
        public override void Play()
        {
            Console.WriteLine("風来のシレンで遊んだ");
        }
    }
}
