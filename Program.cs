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

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //乱数発生器の生成
            Random random = new Random(Environment.TickCount);

            //サイコロを3回振る
            //1~6の範囲の乱数を発生させて表示する
            for(int i = 0; i < 3; i++)
            {
                int r = random.Next(1, 6 + 1);
                Console.WriteLine(r);
            }

            //実数の値も発生してみる
            for(int i = 0; i < 3; i++)
            {
                double r = random.NextDouble();
                Console.WriteLine(r);
            }

            //一時停止
            Console.ReadLine();

        }
    }
}
