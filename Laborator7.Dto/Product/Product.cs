using System;

namespace Dto{
    public class Products{
        public Guid Id{get;private set;}
        public string Name{get;private set;}
        public decimal Price{ get ; private set;}
        public decimal Prices{get; private set;}

        private Products()
        {
            //Ef
        }
        public Products(string name, decimal price, decimal prices)
        {
            Id=new Guid();
            Name=name;
            Price=price;
            Prices=prices;
        }
        public decimal Total()
        {
            return Price*Prices;
        }
    }
}