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
    public partial class UserControl1 : UserControl
    {
        Models.SoftengContext softengContext = new Models.SoftengContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szemelyszures();
        }

        private void Szemelyszures()
        {
            var tmp = from x in softengContext.People
                      where x.Name.Contains(textBox1.Text)
                      select new Person
                      {
                          Name = x.Name
                      };
            listBox1.DataSource = tmp.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szemelylistazas();
        }

        private void Szemelylistazas()
        {
            var kivalasztottszemely = (Person)listBox1.SelectedItem;
            var tmp = from x in softengContext.People
                      where x.Name == kivalasztottszemely.Name
                      select new Person
                      {
                          Id = x.Id,
                          Name = x.Name,
                          Email = x.Email,
                          Gender = x.Gender
                      };
            personBindingSource.DataSource = tmp.ToList();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Szemelyszures();
        }
    }
}
