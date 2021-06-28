using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> kuyruk = new Queue<int>();

            for (int i = 0; i < 100; i++)
            {
                kuyruk.Enqueue((new Random()).Next(1, 100)); // Kuyruğun sonuna bir eleman ekler.
            }

            Console.WriteLine(kuyruk.Dequeue()); // Kuyruğun başındaki ögeyi döndürür ve öge kuyruktan çıkarılır.

            Console.WriteLine(kuyruk.Peek()); // Kuyruğun başındaki ögeyi döndürür.

            kuyruk.Clear(); // Kuruk içeriğini temizler.

            Console.Read();
        }
    }
}
