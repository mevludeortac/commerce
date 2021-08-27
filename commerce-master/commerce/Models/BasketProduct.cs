using System;
namespace commerce.Models
{
    public class BasketProduct
    {
        public int BasketProductId { get; set; }
        public int BasketId { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
    }
}
