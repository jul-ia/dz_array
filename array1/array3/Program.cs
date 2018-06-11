using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new Article[] { new Article("Mars", "Silpo", 11.5), new Article("Coca Cola", "Silpo", 20), new Article("Lays", "Silpo", 23.6) });

            Console.WriteLine(store[0].toString());
            Console.WriteLine(store[1].toString());
            Console.WriteLine(store[2].toString());

            string article;
            Console.Write("\nEnter the name of article: ");
            article = Console.ReadLine();

            store.findArticle(article);

            Console.ReadLine();
        }
    }
}
