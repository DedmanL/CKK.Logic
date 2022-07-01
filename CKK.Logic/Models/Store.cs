using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        { return _id; }
        public void SetId(int id)
        {  _id = id; }
        public string GetName()
        { return _name; }
        public void SetName(string name)
        { _name = name; }
        public void AddStoreItem(Product prod)//Method that adds item to the store.
        {
            if(_product1 == null) { _product1 = prod; }
                else if (_product2 == null) {_product2 = prod; }
                    else if (_product3 == null) {_product3 = prod; }
            
            else if(prod == null) { Console.WriteLine("No available product."); }

        }
        public void RemoveStoreItem(int productNumber)//Method that removes a product from the store.
        {
            if (_product1 != null && productNumber == 1) { _product1 = null; }
            if (_product2 != null && productNumber == 2) { _product2 = null; }
            if (_product3 != null && productNumber == 3) { _product3 = null; }
        }
        public Product GetStoreItem(int productNumber)//Method that gets the product by its position.
        {
            if (productNumber == 1) { return _product1; }//method for finding product based on position
            if (productNumber == 2) { return _product2; }
            if (productNumber == 3) { return _product3; }
            else { return null; }//if productNumber is invalid return null.

        }
        public Product FindStoreItemById(int id)
        {
            if (_product1.GetId() == id) { return _product1; }//return product with same id.
            if (_product2.GetId() == id) { return _product2; }
            if (_product3.GetId() == id) { return _product3; }
            else { return null; }
        }
    }
}
