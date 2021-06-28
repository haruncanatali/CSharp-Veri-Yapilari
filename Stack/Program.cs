using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> yigin = new Stack<int>();

            for (int i = 0; i < 100; i++)
            {
                yigin.Push((new Random()).Next(1, 100)); // Stack'in tepe noktasına öge ekleniyor. 
            }

            Console.WriteLine(yigin.Pop()); // Stack'in tepe noktasındaki ögeyi döndürür ve sonrasında siler.

            Console.WriteLine(yigin.Peek()); // Stack'in tepe noktasındaki ögeyi döndürür.

            Console.WriteLine(yigin.Count()); // Stack'in eleman sayısını döndürür.

            Console.WriteLine(yigin.Contains(44)); // Stack'in içinde 44 sayısını arar ve true/false döndürür.

            yigin.Clear(); // Stack'in içeriğini temizler.


            Console.Read();


        }
    }
}
