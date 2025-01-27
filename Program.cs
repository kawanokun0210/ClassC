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
using SwitchTest;
using GameCardTest;
using ShirenTest;
using PikminTest;
using SplatoonTest;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch sw = new Switch();
          
            //ゲームをセットせずにプレイしてみる
            sw.PlayGame();

            //風来の試練をセットしてプレイしてみる
            sw.SetGameCard(new Shiren());
            sw.PlayGame();

            //ピクミンをセットしてプレイしてみる
            sw.SetGameCard(new Pikmin());
            sw.PlayGame();

            //スプラトゥーンをセットしてプレイしてみる
            sw.SetGameCard(new Splatoon());
            sw.PlayGame();

            //一時停止
            Console.ReadLine();

        }
    }
}
