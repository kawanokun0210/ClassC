using GameCardTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    internal class Switch
    {
        //フィールド
        private GameCard gamecard;

        //メソッド
        public Switch()
        {
            gamecard = null;
        }

        public void SetGameCard(GameCard gc)
        {
            gamecard = gc;
        }

        public void PlayGame()
        {
            if(gamecard == null)
            {
                Console.WriteLine("ゲームカードが差さっていません");
            }
            else
            {
                gamecard.Play();
            }
        }

    }
}
