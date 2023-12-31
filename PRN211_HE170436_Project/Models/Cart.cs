﻿namespace PRN211_HE170436_Project.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        private static Dictionary<int, int> cart;

        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
            .Where(p => p.Product.ProductId == product.ProductId)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine() 
                {   Product = product, 
                    Quantity = quantity 
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveItem(Product product)
        {
            Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);
        }

        public decimal ComputeTotalValue()
        {
            return (decimal)Lines.Sum(e => e.Product?.ProductPrice *(1 - e.Product?.ProductDiscount) * e.Quantity);
        }
        public void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
