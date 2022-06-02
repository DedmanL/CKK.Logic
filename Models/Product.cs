using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;
        
        public int GetID()
        {
            return _id;
        }
        public void SetID(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public void SetPrice(decimal price)
        {
            _price = price;
        }
    }
}
