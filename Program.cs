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
            //Listコレクションnumbersを作成する
            List<int> numbers = new List<int>();

            //サイコロを10回振る
            //-5~5の範囲の乱数を発生させて表示する
            for(int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(-5, 5 + 1));
            }

            //全ての中身を確認
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //一時停止
            Console.ReadLine();

        }
    }
}
