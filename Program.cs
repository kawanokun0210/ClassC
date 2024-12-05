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
            Player player = new Player();

            player.AddItem(new Item("つるはし"));
            player.AddItem(new Item("巻き物"));
            player.AddItem(new Item("ポーション"));

            player.UseItems();

            //一時停止
            Console.ReadLine();

        }
    }
}
