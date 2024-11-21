using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogTest;
using PlayerTest;
using FlyingRobotTest;
using TankRobotTest;
using System.Xml.Linq;
using RobotTest;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listコレクションnumbersを作成する
            List<int> numbers = new List<int>();

            //numbersに3を追加して、中身を表示する
            numbers.Add(3);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---");

            //一時停止
            Console.ReadLine();

            //続いて7,2,1,5を追加して、中身を表示する
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(5);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---");

            //一時停止
            Console.ReadLine();

            //配列のように。添字を使って参照できる
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("---");

            //一時停止
            Console.ReadLine();
        }
    }
}
