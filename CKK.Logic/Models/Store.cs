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
        private Product product1;
        private Product product2;
        private Product product3;

        public int GetId()
        { return _id; }
        public void SetId(int id)
        {  _id = id; }
        public string GetName()
        { return _name; }
        public void SetName(string name)
        { _name = name; }
        public Product AddStoreItem(Product prod)//Method that adds item to the store.
        {
            if(product1 == null) { prod = product1; }
                else if (product1 != null) { prod = product2; }
                    else if (product2 != null) { prod = product3; }
            
            if(prod == null) { prod = null; }
            
            return prod;
        }
        public int RemoveStoreItem(int productNumber)//Method that removes a product from the store.
        {
            while(productNumber >= 1)//States value must be greater than or equal to 1 to execute next line.
            { productNumber -= 1; }//Change this.
            if(productNumber <= 0)//States value must be less than or equal to 0 to execute next line.
            { productNumber = 0; }//Sets value at 0 based on statement.
            
            return productNumber;//Returns value based on if statement results.
        }
        public int GetStoreItem(int productNumber)//Method that gets the product by its position.
        {
            

            return prod;
        }
        public int FindStoreItemByld(int id)
        {


            return prod;
        }
    }
}
