using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogTest;
using PlayerTest;
using FlyingRobotTest;
using TankRobotTest;
using System.Xml.Linq;
using RobotTest;
using ItemTest;
using System.ComponentModel;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new Item("こん棒"));

            player.UseItem();

            //一時停止
            Console.ReadLine();

        }
    }
}
