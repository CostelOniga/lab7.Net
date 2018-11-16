using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Domain.Product
{
    class Product
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Pieces { get; set; }
        public double Total { get; set; }
    }
}