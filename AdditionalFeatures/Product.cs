using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalFeatures
{
    class Product
    {
        int ID { get; set; }
        int Quantity { get; set; }
        string ProductName { get; set; }
        
        string Description { get; set; }
      

        public Product(int _id, string _ProductName)
            : this(_id, 0, _ProductName,"")
        {

        }

        public Product(int _id, int _Quantity, string _ProductName)
            :this(_id, _Quantity, _ProductName,"")
        {
            
        }

        public Product(int _id, int _Quantity, string _ProductName, string _Description)
        {
            ID = _id;
            Quantity=_Quantity;
            ProductName = _ProductName;
            Description = _Description;
         
        }

    }
}
