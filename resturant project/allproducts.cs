using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant_project
{
    public partial class allproducts : UserControl
    {
        Form1 frm;
        double totle=0.0;
        public Order or = new Order();
        public allproducts()
        {
            InitializeComponent();
        }
        public allproducts(Image img,string name, string price,Form1 frm)
        {

            InitializeComponent();
            this.apic.Image = img;
            this.name_pro.Text = name;
            this.price_pro.Text = price;
            this.frm = frm;
           

        }
     
        private void allproducts_Load(object sender, EventArgs e)
        {

        }
    

        private void apic_Click(object sender, EventArgs e)
        {
          
            this.frm.txt_products.Text +=this.name_pro.Text + "   " +this.price_pro.Text+" $"+'\n';
            totle = double.Parse(price_pro.Text);
            manager.price3(totle);
            Product prodf = new Product();
            prodf = manager.search_pro(name_pro.Text);
            or.add_pro_ord(prodf);
        

        }
    }
}
