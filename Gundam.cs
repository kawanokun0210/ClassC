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
        public Gundam(string name) : base(name)
        {
            this.name = name;
        }

        //フィンファンネルを撃つ
        public override void Attack()
        {
            Console.WriteLine("{0}は、フィンファンネルを発動した！", name);
        }

    }
}
