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
            if(product1 == null)//Checks if P1 is empty.
            { prod = product1; }//If P1 is empty, assigns a product to P1.
            if (product1 != null)//Checks if P1 is has product.
            { prod = product2; }//If P1 is has product, assigns a product to P2.
            if (product2 != null)//Checks if P2 is has product.
            { prod = product3; }//If P2 is has product, assigns a product to P3.
            if(prod == null)//If there is no product.
            { prod = null; }//Product remains empty.
            return prod;
        }
        public int RemoveStoreItem(int productNumber)//Method that removes a product from the store.
        {
            if(productNumber >= 1)//States value must be greater than or equal to 1 to execute next line.
            { productNumber -= 1; }//Change this.
            if(productNumber <= 0)//States value must be less than or equal to 0 to execute next line.
            { productNumber = 0; }//Sets value at 0 based on statement.
            return productNumber;//Returns value based on if statement results.
        }
        public int GetStoreItem(int productNumber, Product prod)//Method that gets the product by its position.
        {
            if (productNumber == 1)
            { prod = product1; }
            if (productNumber == 2)
            { prod = product2; }
            if (productNumber == 3)
            { prod = product3; }
            else
            { prod = null; }
            return productNumber;
        }
        public int FindStoreItemByld(int id, Product prod)
        {
            if (id == 1)
            { prod = product1; }
            if (id == 2)
            { prod = product1; }
            if (id == 3)
            { prod = product1; }
            if (id <= 0)//If no product has matching id.
            { prod = null; }
            if (id >= 1)
            { prod = product1; }
            return id;
        }
    }
}
