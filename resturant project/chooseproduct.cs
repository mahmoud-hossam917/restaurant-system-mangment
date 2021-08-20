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
  
    public partial class chooseproduct : Form
    {

        Form1 frm;
        public chooseproduct(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btn_chpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                picproduct.Image = Image.FromFile(of.FileName);
            }
        }

        private void btnaddpro_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            
            pr.id_product = txtid_prod.Text;
            pr.name = txtname_prod.Text;
            pr.price_product =Convert.ToDouble(txtprice.Text);
            pr.num_pro = int.Parse(numpage.Text);
            manager.add_product(pr);
            picproduct.Image.Save("imges/" + txtid_prod.Text +".jpg");
            allproducts alp = new allproducts(picproduct.Image,pr.name, txtprice.Text,frm);
            FlowLayoutPanel flow = (FlowLayoutPanel)this.frm.tabControl1.TabPages[pr.num_pro].Controls[0];
            flow.Controls.Add(alp);
                
            this.Close();
        }
    }
}
