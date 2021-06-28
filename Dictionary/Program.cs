using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kisiler = new Dictionary<int, string>();

            kisiler.Add(1, "Haruncan"); // Sözlüğe key,value olarak veri eklenir.
            kisiler.Add(2, "Bilal");
            kisiler.Add(3, "Fatih");

            kisiler.Remove(3); // Girilen key değerine göre sözlükten silme yapar.

            kisiler.ContainsKey(3); // Girilen key değerine göre sözlükte arama yapar ve true/false döndürür.

            kisiler.ContainsValue("Haruncan"); // Girilen value değerine göre sözlükte arama yapar ve true/false döndürür.

            kisiler.Count(); // Sözlükteki key,value çiflerinin sayısını verir.

            foreach (KeyValuePair<int,string> item in kisiler)
            {
                Console.WriteLine(item.Key+"->"+item.Value);
            }

            kisiler.Clear(); // Sözlükteki ögeleri temizler.
        }
    }
}
