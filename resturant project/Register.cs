using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant_project
{
    public partial class Register : Form
    {  
        public Register()
        {
            InitializeComponent();
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            
            newuser.user_name = txt_user.Text;
            newuser.name = txt_name.Text;
            newuser.password = txt_pass.Text;
            newuser.phone_number = txt_phone.Text;
            
            manager.register(newuser.name, newuser);
            this.Close();
        }
    }
}
