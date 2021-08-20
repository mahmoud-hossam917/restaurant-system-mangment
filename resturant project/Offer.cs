using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_project
{
    public class Offer:Product
    {
       public string id_off { get; set; }
       public string name_offer { get; set; }
       public double price_pro { get; set; }
       public string start_date { get; set; }
       public string end_date { get; set; }
        List<Product> prod_offer = new List<Product>();
        void add_prod_off(Product namepr_off)
        {
            prod_offer.Add(namepr_off);
        }
        bool  Edit_offer(string id_pro,Product thenew)
        {
            int i = 0;
            foreach(var item in prod_offer)
            {    
                if(item.id_product==id_pro)
                {
                    prod_offer[i] = thenew;
                    return true;
                }
                i++;
            }
            return false;
        }
        bool delete_prod(string id_pro)
        {
            foreach (var item in prod_offer)
            {
                if (item.id_product == id_pro)
                {
                    prod_offer.Remove(item);
                }
            }
            return false;

        }
    }

}
