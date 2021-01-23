using System;

namespace Calismalar
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dict = new MyDictionary<int, string>();
            dict.add(5, "ufuk");
            dict.add(10, "yusuf");
            dict.add(15, "ahmet");
            dict.add(20, "muhammed");

            Console.WriteLine(dict.Length);

        }
    }
}
