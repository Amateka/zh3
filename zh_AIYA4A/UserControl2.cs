using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_AIYA4A.Models;

namespace zh_AIYA4A
{
    public partial class UserControl2 : UserControl
    {
        Models.SoftengContext softengContext = new Models.SoftengContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Termekszures();
        }

        private void Termekszures()
        {
            var tmp = from x in softengContext.Products
                      where x.Terméknév.Contains(textBox1.Text)
                      select x;
            listBox1.DataSource = tmp.ToList();
            listBox1.DisplayMember = "Terméknév";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termeklistazas();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Termekszures();
        }
        private void Termeklistazas()
        {
            var kivalasztotttermek = (Product)listBox1.SelectedItem;
            var tmp = from x in softengContext.Products
                      where x.Terméknév == kivalasztotttermek.Terméknév
                      select x;
            productBindingSource.DataSource = tmp.ToList();
        }

    }
}
