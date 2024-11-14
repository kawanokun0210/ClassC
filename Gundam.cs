using RobotTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamTest
{
    internal class Gundam : Robot
    {
        //フィールド

        //メソッド
        //コンストラクタ
        public Gundam(string name)
        {
            this.name = name;
        }

        //フィンファンネルを撃つ
        public void FinFunnel()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、フィンファンネルを発動した！", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源OFFなので親父にぶたれた...", name);
            }
        }

    }
}
