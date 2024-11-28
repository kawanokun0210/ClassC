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
            List<Robot> robots = new List<Robot>();
            //ランダムの数字を格納
            int randomNum = 0;

            //サイコロを15回振る
            for(int i = 0; i < 15; i++)
            {
                //ランダムの数字を抽選する
                randomNum = random.Next(0, 1 + 1);

                //数字が0ならタンクロボを出す
                if(randomNum == 0)
                {
                    robots.Add(new TankRobot("タンクロボ"));
                }
                else//0じゃなければ空飛ぶロボを出す
                {
                    robots.Add(new FlyingRobot("空飛ぶロボ"));
                }

            }

            //全ての中身を確認
            foreach(Robot robot in robots)
            {
                robot.Attack();
            }

            //一時停止
            Console.ReadLine();

        }
    }
}
