using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplicationTest
{
    internal abstract class GameApplication
    {
        //メソッド

        //初期化処理
        protected abstract void Initialize();

        //更新処理
        protected abstract void Update();

        //描画
        protected abstract void Draw();

        //終了
        protected abstract void Terminate();

        //ゲームオーバーチェック
        protected abstract bool IsGameOver();

        //実行
        public void Run()
        {
            Initialize();//初期化

            while(IsGameOver() == false)
            {
                Update();//更新
                Draw();//描画
            }
            Terminate();//ゲーム終了
        }

    }
}
