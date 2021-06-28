using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> urunler = new List<Product>();

            for (int i = 0; i < 100; i++)
            {
                urunler.Add(new Product // Listeye değer ekler.
                {
                    Id = (i + 1),
                    ProductName = "Product_" + (i+1).ToString()
                });
            }

            Console.WriteLine(urunler.Count()); // Liste boyutunu döndürür.

            urunler.Remove(new Product // Belirtilen parametredeki ilk bulduğu değeri siler.
            {
                Id = 1,
                ProductName = "Product_1"
            });

            urunler.RemoveAt(5); // 5. indisteki elemanı siler.

            Console.WriteLine(urunler.Contains(new Product { // Liste içindeki girilen değeri arar.(true/false)
                Id = 1,
                ProductName = "Product_1"
            }));

            Console.WriteLine(urunler.BinarySearch(new Product { // Liste içindeki girilen değerin listede kaçıncı sırada oldğunu arar.
                Id = 1,
                ProductName = "Product_1"
            }));

            urunler.ForEach(urun => Console.WriteLine(urun.Id + " " + urun.ProductName + "\n"));

            urunler.Clear(); // Liste içindeki ögeleri temizler.

        }

        class Product
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
        }
    }
}
