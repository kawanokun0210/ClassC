using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel;
using GameApplicationTest;
using FinalFantasyTest;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameApplication ff = new FinalFantasy();
            ff.Run();

            //一時停止
            Console.ReadLine();

        }
    }
}
