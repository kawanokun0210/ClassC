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
using GundamTest;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //空飛ぶロボをテストする
            FlyingRobot[] flyingRobots = new FlyingRobot[5];

            //空飛ぶロボ5体分の実体を作る
            for(int i = 0; i < flyingRobots.Length; i++) {
                flyingRobots[i] = new FlyingRobot("空飛ぶロボNo." + i);
                flyingRobots[i].PowerOn();
            }
          
            foreach(FlyingRobot fly in flyingRobots)
            {
                fly.DropBomb();
            }

            Console.WriteLine("---------------------------");

            //タンクロボをテストする
            TankRobot[] tankRobots = new TankRobot[5];

            for(int i = 0; i < tankRobots.Length; i++)
            {
                tankRobots[i] = new TankRobot("タンクNo." + i);
                tankRobots[i].PowerOn();
            }

            foreach(TankRobot tank in tankRobots)
            {
                tank.ShootCannon();
            }

            Console.WriteLine("---------------------------");

            //ニューガンダムをテストする
            Gundam gundam = new Gundam("ニューガンダム");

            Console.WriteLine("名前 : {0}", gundam.GetName());
            Console.WriteLine("電源 : {0}", gundam.GetPowerStatus());

            gundam.FinFunnel();

            gundam.PowerOn();
            gundam.FinFunnel();

            gundam.PowerOff();

            Console.WriteLine("---------------------------");

            //一時停止
            Console.ReadLine();

        }
    }
}
