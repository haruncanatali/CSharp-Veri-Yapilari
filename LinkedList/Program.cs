using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> bagli_liste = new LinkedList<int>();

            bagli_liste.AddFirst(3); // Bağlı listenin başına eleman ekler.
            bagli_liste.AddFirst(2);
            bagli_liste.AddFirst(1);
            bagli_liste.AddFirst(0);

            bagli_liste.AddLast(4); // Bağlı listenin sonuna eleman ekler.
            bagli_liste.AddLast(5);
            bagli_liste.AddLast(6);
            bagli_liste.AddLast(7);

            bagli_liste.Find(0); // Bağlı listede girilen değerin indexini verir.

            bagli_liste.AddBefore(bagli_liste.Find(0), -1); // Bağlı listede istenilen elemandan önce girilen değeri ekler.

            bagli_liste.AddAfter(bagli_liste.Find(7), 8); // Bağlı listede istenilen elemandan sonra girilen değeri ekler.

            bagli_liste.RemoveFirst(); // Bağlı listenin ilk elemanını siler.

            bagli_liste.RemoveLast(); // Bağlı listenin son elemanını siler.

            bagli_liste.Remove(5); // Bağlı listeden girilen değeri siler.

            LinkedListNode<int> first_value = bagli_liste.First; // Bağlı listedeki ilk düğümü alır.
            LinkedListNode<int> last_value = bagli_liste.Last; // Bağlı listedeki son düğümü alır.

            Console.WriteLine(first_value.Value); // İlk düğümün değerini döndürür.

            Console.WriteLine(last_value.Value); // Son düğümün değerini döndürür.

            Console.WriteLine(first_value.Next.Value); // İlk elemandan sonraki değeri verir.

            Console.WriteLine(last_value.Previous.Value); // Son elemandan önceki değeri verir.
        }
    }
}
