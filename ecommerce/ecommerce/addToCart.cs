using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    internal class addToCart
    {
        List<Dictionary<string,dynamic>> addItems=new List<Dictionary<string,dynamic>>();
        public void additem(Dictionary<string,dynamic> addItem)
        {
            addItems.Add(addItem);
        }
        public void display()
        {
            foreach (var item in addItems)
            {
                Console.WriteLine($" item: {item["item"]} , price : {item["price"]} ,brand: {item["brand"]}");
            }
        }
    }
}
