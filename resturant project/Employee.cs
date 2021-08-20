using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_project
{
   public class Employee:Order
    {
        List<Order> ord = new List<Order>();
       public bool status { get; set; }
       void add_order(Order ord_emp)
        {
            ord.Add(ord_emp);
        }
        void delete_order(Order ord_emp)
        {
            ord.Remove(ord_emp);
        }
        bool edit_order(Product pro ,string id_pro )
        {
          
            return false;
        }

    }
}
