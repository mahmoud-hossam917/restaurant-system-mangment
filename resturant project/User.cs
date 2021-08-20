using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.MemoryMappedFiles;
namespace resturant_project
{
    
    public class User
    {
        public List<Order> ord_customer ;
        public User()
        {
            ord_customer = new List<Order>();
        }

       public User(string id,string name ,string user_name,string password,string phone_number)
        {
            this.id = id;
            this.user_name = user_name;
            this.password = password;
            this.name = name;
            this.phone_number = phone_number;
            ord_customer = new List<Order>();
        }

        public string id { get; set; }
        public string name { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
      
     

    }
}
