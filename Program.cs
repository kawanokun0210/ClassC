﻿using System;
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
            Robot robot = new Robot("ロボット");
            Console.WriteLine("名前:{0}", robot.GetName());
            robot.Attack();

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");
            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            flyingRobot.Attack();

            TankRobot tankRobot = new TankRobot("タンクロボ");
            Console.WriteLine("名前:{0}", tankRobot.GetName());
            tankRobot.Attack();

            //一時停止
            Console.ReadLine();

        }
    }
}
