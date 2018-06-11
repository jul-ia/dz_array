using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    class Store
    {
        Article[] article;

        public Store()
        {
            article = new Article[] { new Article(), new Article(), new Article() };
        }
        public Store(int s)
        {
            article = new Article[s];
        }
        public Store(Article[] a)
        {
            article = a;
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < article.Length)
                    return article[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < article.Length)
                    article[index] = value;
                else
                    article[index] = new Article();
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                {
                    if (index == article[i].Name)
                        return article[i].toString();

                }
                return "No such article.";
            }
        }

        public void findArticle(string s)
        {
            bool f = false;
            foreach (Article a in article)
            {
                if (a.Name == s)
                {
                    f = true;
                    Console.WriteLine(a.toString());
                }
            }
            if (!f)
                Console.WriteLine("Article not found.");
        }
    }
}
