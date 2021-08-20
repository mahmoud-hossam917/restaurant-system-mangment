using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_project
{
    public class Order 
    {
       public string id_or { get; set; }
       public  List<Product> prod_ord;
        public Order()
        {
            prod_ord = new List<Product>();
        }
       public void add_pro_ord(Product pro)
        {
            prod_ord.Add(pro);
        }
       public void delete_pro(Product pro)
        {
            prod_ord.Remove(pro);
        }
       public bool edit_pro(Product pro , string id_pro)
        {
            int i = 0;
            foreach(var item in prod_ord)
            {
                if(item.id_product==id_pro)
                {
                    prod_ord[i].id_product=pro.id_product;
                    prod_ord[i].name = pro.name;
                    prod_ord[i].price_product = pro.price_product;
                    return true;
                }
                i++;
            }
            return false; 
        }
      
        public double Bill (List<Product> lispro)
        {
            double PRICE = 0.0;
            foreach(var item in lispro)
            {
                PRICE += item.price_product;
            }
            return PRICE;
        }
       
    }
}
