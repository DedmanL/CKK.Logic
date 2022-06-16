using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;


        public ShoppingCartItem(Product prod, int quantity)
        {
            _product = prod;
            _quantity = quantity;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product prod)
        {
            _product = prod;
        }
        public decimal GetTotal(decimal total, decimal _price)//Method that multiplies the price and quantity to get a total cost.
        {
            return total = _price * _quantity;
        }
    }
}
