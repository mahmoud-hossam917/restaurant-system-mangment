using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace resturant_project
{
    public partial class Form1 : Form
    {
        public double totle = 0;
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
                StreamReader srpr = new StreamReader("products.txt");
                string line = "avc";
                while (line != null)
                {
                    line = srpr.ReadLine();
                   
                    if (line != null)
                    {
                        string[] line2 = line.Split(';');
                         
                        Product prod_u = new Product();
                        prod_u.id_product = line2[0];
                        prod_u.name = line2[1];
                        prod_u.price_product = Convert.ToDouble(line2[2]);
                        prod_u.num_pro = int.Parse(line2[3]);
                        manager.add_prodt(prod_u);
                        PictureBox pic = new PictureBox();
                        string mypath = "imges/" + line2[0] + ".jpg";
                        if (File.Exists(mypath))
                            pic.Image = Image.FromFile(mypath);
                        allproducts allp = new allproducts(pic.Image, line2[1], line2[2],this);
                        FlowLayoutPanel floww = (FlowLayoutPanel)this.tabControl1.TabPages[prod_u.num_pro].Controls[0];
                        floww.Controls.Add(allp);
                    }
                }
                srpr.Close();
         
        

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            chooseproduct cp = new chooseproduct(this);
            cp.Show();
         
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Product pros = new Product();
           if ( manager.search_pro(txtsearch.Text)!=null)
            {
                pros = manager.search_pro(txtsearch.Text);
                this.txt_products.Text += pros.name + "  " + pros.price_product.ToString() + " $ \n";
                double tot = pros.price_product;
                manager.price3(tot);
                txtsearch.Text = "";
            }
           else
            {
                MessageBox.Show("this product is not found");
                txtsearch.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            this.txt_products.Text += "_________________ \n" +manager.price3()+"\n";
           
        }

        private void btn_sruser_Click(object sender, EventArgs e)
        {
            if (manager.search_user(txt_sruser.Text) != null)
            {
               
                User su = new User();
                Form frm = new Form();
                frm.StartPosition = FormStartPosition.CenterScreen;
                su = manager.search_user(txt_sruser.Text);
                Label ll = new Label();
                ll.AutoSize = true;
                frm.BackColor = Color.White;
                ll.Text = "id = " + su.id + "\n" + "Name = " + su.name+"\n"
                         + "Username = " + su.user_name + "\n"
                         + "Password = " + su.password + "\n"
                         + "Phone number = " + su.phone_number;
              
                frm.Controls.Add(ll);
               
                frm.Show();
                txt_sruser.Text ="";
            }
            else
                MessageBox.Show("this user is not found !!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_products.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            allproducts a = new allproducts();
            Customer cs = new Customer();

            cs.add_order(lbl_name.Text, a.or);
          
            a.or.prod_ord.Clear();
            MessageBox.Show("The Order is Add");
            

        }
    }
}
