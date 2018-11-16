using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Domain.ShoppingCart
{
    class ShoppingCart
    {
        public Guid id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Total { get; set; }
    }
}
