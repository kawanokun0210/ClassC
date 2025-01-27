using GameApplicationTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasyTest
{
    internal class FinalFantasy : GameApplication
    {
        //ゲーム終了フラグ
        private bool isGameOver;

        //初期化処理
        protected override void Initialize()
        {
            Console.WriteLine("ファイナルファンタジー初期化処理");
            isGameOver = false;
        }

        //更新処理
        protected override void Update()
        {
            Console.WriteLine("ファイナルファンタジー更新処理");
            Console.WriteLine("ゲームを続ける？y/n");
            if (Console.ReadLine() == "n")
            {
                isGameOver = true;
            }
        }

        //描画処理
        protected override void Draw()
        {
            Console.WriteLine("ファイナルファンタジー描画処理");
        }

        //終了処理
        protected override void Terminate()
        {
            Console.WriteLine("ファイナルファンタジー終了処理");
        }

        //ゲーム終了か？
        protected override bool IsGameOver()
        {
            return isGameOver;
        }

    }
}
