using RobotTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankRobotTest
{
    internal class TankRobot : Robot
    {

        //フィールド

        //メソッド
        //コンストラクタ
        public TankRobot(string name)
        {
            this.name = name;
        }

        //キャノン砲を撃つ
        public void ShootCannon()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、キャノン砲を撃った！！", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源OFFなのでキャノン砲は使えません...", name);
            }
        }

    }
}
