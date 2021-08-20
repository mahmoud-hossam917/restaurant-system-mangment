using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace resturant_project
{

    public static class manager
    {
        public static long  id_id = 1;
        public static double tot = 0.0;
        public static string id_temp;
        public static Dictionary<string, User> users_name = new Dictionary<string, User>();
        public static List<Product> products = new List<Product>();
        public static List<Offer> offers = new List<Offer>();
       

        public static void add_in(string name_user, User information)
        {
            users_name.Add(name_user, information);
        }
        public static void register(string name_user, User information)
        {
            information.id = id_id.ToString();
            users_name.Add(name_user, information);
            StreamWriter sw = new StreamWriter("mydata.txt", true);
            string line = information.id + ";"
                       + information.name + ";"
                       + information.password + ";"
                       + information.user_name + ";"
                       + information.phone_number + ";";
            sw.WriteLine(line);
            sw.Close();
        }
        public static void delete_user(string name_user)
        {

            users_name.Remove(name_user);
        }
        public static void Edit_user(string name_user, User newuser)
        {
            
            users_name[name_user] = newuser;
        }
        public static User search_user(string name_user)
        {
            User u = new User();
          if( users_name.TryGetValue(name_user , out u)) return u; 
            
            return null;
        }
        public static void add_prodt(Product proi)
        {
            products.Add(proi);
        }
        public static void add_product(Product proi)
        {
            products.Add(proi);
            StreamWriter swpr = new StreamWriter("products.txt", true);
            string line_pro = proi.id_product + ";"
                           + proi.name + ";"
                           + proi.price_product.ToString() + ";"
                           + proi.num_pro.ToString();
            swpr.WriteLine(line_pro);
            swpr.Close();
        }
        public static bool login(string user, string pass,ref bool ismang)
        {

            foreach (var item in users_name)
            {

                if (item.Value.user_name == user && item.Value.password == pass)
                {
                    if (item.Value.id == "1") ismang = true;
                    return true;
                }

            }
            return false;
        }
        public static void add_offer(Offer off)
        {
            offers.Add(off);
        }
        public static Product search_pro(string name_pro)
        {
            foreach (var item in products)
            {
                if (item.name == name_pro)
                {
                    return item;
                }
            }
            return null;
        }
        public static void price3(double pri )
        {

            tot += pri;
        }
        public static string price3()
        {
            var x = tot;
            tot = 0.0;
            return x.ToString();
        }

    }
}
