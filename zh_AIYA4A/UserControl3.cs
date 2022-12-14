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
    public partial class UserControl3 : UserControl
    {
        Models.SoftengContext softengContext = new Models.SoftengContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            Szemelyszures();
            Termekszures();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szemelyszures();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rendeleslistazas();
        }

        private void Rendeleslistazas()
        {
            var kivalasztottszemely = (Person)listBox1.SelectedItem;
            var tmp = from x in softengContext.Orders
                      where x.SzemélyNév == kivalasztottszemely.Name
                      select new Order
                      {
                          ProductId = x.ProductId,
                          PeopleId = x.PeopleId,
                          SzemélyNév = x.SzemélyNév,
                          Terméknév = x.Terméknév,
                          Mennyiség = x.Mennyiség,
                          Egységár = x.Egységár
                      };
            orderBindingSource.DataSource = tmp.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Termekszures();
        }

        private void buttonHozzáadás_Click(object sender, EventArgs e)
        {
            var kivalasztottszemely = (Person)listBox1.SelectedItem;
            var kivalasztotttermek = (Product)listBox2.SelectedItem;

            Form5 form5 = new Form5();
            if (form5.ShowDialog() == DialogResult.OK)
            {
                Order tmp = new Order();
                tmp.PeopleId = kivalasztottszemely.Id;
                tmp.ProductId = kivalasztotttermek.TermékId;
                tmp.SzemélyNév = kivalasztottszemely.Name;
                tmp.Terméknév = kivalasztotttermek.Terméknév;
                tmp.Mennyiség = Convert.ToInt32(form5.textBox1.Text);
                tmp.Egységár = (int)kivalasztotttermek.Egységár * tmp.Mennyiség;


                if (MessageBox.Show("Biztosan el akarja menteni?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                else
                {
                    softengContext.Orders.Add(tmp);
                    try
                    {
                        softengContext.SaveChanges();
                        MessageBox.Show("Sikeres mentés");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sikertelen mentés:(");
                    }
                    Rendeleslistazas();
                }
            }
        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            var kivalasztottrendeles = (Order)orderBindingSource.Current;

            var tmp = (from x in softengContext.Orders
                       where x.Egységár == kivalasztottrendeles.Egységár
                       select x).FirstOrDefault();
            if (MessageBox.Show("Biztosan ki akarja törölni?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;
            else
            {
                softengContext.Orders.Remove(tmp);
                try
                {
                    softengContext.SaveChanges();
                    MessageBox.Show("Sikeres mentés");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sikertelen mentés:(");
                }
                Rendeleslistazas();
            }
        }
        private void Szemelyszures()
        {
            var tmp = from x in softengContext.People
                      where x.Name.Contains(textBox1.Text)
                      select x;
            listBox1.DataSource = tmp.ToList();
            listBox1.DisplayMember = "Name";
        }
        private void Termekszures()
        {
            var tmp = from x in softengContext.Products
                      where x.Terméknév.Contains(textBox2.Text)
                      select x;
            listBox2.DataSource = tmp.ToList();
            listBox2.DisplayMember = "Terméknév";
        }
    }
}
