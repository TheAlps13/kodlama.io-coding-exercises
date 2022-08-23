using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("Hey");
            list.Add("Hello");
            list.Add("Stop");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

          
                
        }
    }
}
