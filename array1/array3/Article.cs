using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    class Article
    {
        string name;
        string store;
        double price;

        public Article()
        {
            name = "name";
            store = "store";
            price = 0.0;
        }

        public Article(string name, string store, double price)
        {
            this.name = name;
            this.store = store;
            this.price = price;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Store
        {
            set { store = value; }
            get { return store; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public string toString()
        {
            return string.Format(name + "\nStore: {0}, price: {1}", store, price);
        }
    }
}
