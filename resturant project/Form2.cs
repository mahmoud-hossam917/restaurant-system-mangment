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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
          

            
        }

        private void login_button_Click(object sender, EventArgs e)
        {


            bool ismang = false;
            if (manager.login(user_na.Text, ps.Text,ref ismang)==true)
            {
                Form1 frm = new Form1();
                frm.lbl_name.Text = user_na.Text;
                frm.Show();
                this.Hide();

            }
            else MessageBox.Show("No");
            user_na.Text = "";
            ps.Text = "";
            user_na.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("mydata.txt");
                string line = "abc";
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] str = line.Split(';');
                        User us = new User();
                        us.id = str[0];
                        us.name = str[1];
                        us.password = str[2];
                        us.user_name = str[3];
                        us.phone_number = str[4];
                        manager.add_in(us.name, us);
                    }

                }
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
