using RobotTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingRobotTest
{
    internal class FlyingRobot : Robot
    {

        //フィールド

        //メソッド
        //コンストラクタ
        public FlyingRobot(string name) : base(name)
        {
            this.name = name;
        }

        //爆弾を落とす
        public override void Attack()
        {
            Console.WriteLine("{0}は、爆弾を落とした！！", name);
        }

    }
}
