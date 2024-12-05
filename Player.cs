using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemTest;

namespace PlayerTest
{
    internal class Player
    {
        //フィールド
        private string name;
        private int level;

        private string item;
        List<Item> items;

        //メソッド
        //コンストラクタ
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public Player() 
        {
            items = new List<Item>();
        }

        //攻撃する
        public void Attack()
        {
            Console.WriteLine("攻撃!!");
        }
        //防御する
        public void Defense()
        {
            Console.WriteLine("防御した!!");
        }
        //レベルアップする
        public void LevelUP()
        {
            level++;
        }
        //名前を聞く
        public string GetName()
        {
            return name;
        }
        //レベルを聞く
        public int GetLevel()
        {
            return level;
        }

        //アイテムを使う
        public void UseItem()
        {
            Console.WriteLine("{0}を使った", item);
        }

        //アイテムを受け取る
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        //アイテムを使う
        public void UseItems()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }

    }
}
