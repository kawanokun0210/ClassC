using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemTest
{
    internal class Item
    {
        //フィールド
        private string name;

        //メソッド
        //コンストラクタ
        public Item (string name)
        {
            this.name = name;
        }

        //何かを使う
        public void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }

        public string GetName()
        {
            return name;
        }

    }
}
