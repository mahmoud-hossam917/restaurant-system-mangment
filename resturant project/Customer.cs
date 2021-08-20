using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_project
{
    public class Customer
    {
        Dictionary< string , List<Order>> cus_ord = new Dictionary<string , List<Order>>();
       public void add_order(string user_namee,Order ord_user)
        {
            cus_ord.Add(user_namee,ord_user);
        }
       public bool delete_order(string id_user, Order ord_user)
        {
            for(int i=0;i<cus_ord[id_user].Count;i++)
            {
                if(cus_ord[id_user][i]==ord_user)
                {
                    cus_ord[id_user].Remove(ord_user);
                    return true;
                }
            }
            return false;
        }
       public Order  search_order(string id_orde , string id_use)
        {
            for(int i=0;i<cus_ord[id_use].Count;i++)
            {
                if(cus_ord[id_use][i].id_or==id_orde)
                {
                    return cus_ord[id_use][i];
                }
            }
            return null;

        }
        public void add_product(Product pro,string id_user,int indix)
        {
            cus_ord[id_user][indix].add_pro_ord(pro);
        }
        public void delete_produ(Product pro, string id_user, int indix)
        {
            cus_ord[id_user][indix].add_pro_ord(pro);
        }
        public bool edit_produ(Product pro, string id_user, int indix , string id_pro)
        {
            if (cus_ord[id_user][indix].edit_pro(pro, id_pro)) return true;
            return false;
        }
       
    }
}
