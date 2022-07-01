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
        private void AddStoreItem(Product prod)//Method that adds item to the store.
        {
            if(_product1 == null) { prod = _product1; }
                else if (_product1 != null) { prod = _product2; }
                    else if (_product2 != null) { prod = _product3; }
            
            if(prod == null) { prod = null; }

        }
        private void RemoveStoreItem(int productNumber)//Method that removes a product from the store.
        {
            while(productNumber >= 1)//States value must be greater than or equal to 1 to execute next line.
            { productNumber -= 1; }//Change this.

        }
        private Product GetStoreItem(int productNumber)//Method that gets the product by its position.
        {
            if (productNumber == 1) { return _product1; }//method for finding product based on position
            if (productNumber == 2) { return _product2; }
            if (productNumber == 3) { return _product3; }
            else { return null; }//if productNumber is invalid return null.

        }
        private Product FindStoreItemByld(int id)
        {
            if (id == 1) { return _product1; }//return product with same id.
            if (id == 2) { return _product2; }
            if (id == 3) { return _product3; }
            else { return null; }
        }
    }
}
