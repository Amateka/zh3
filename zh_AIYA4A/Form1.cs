using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace zh_AIYA4A
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
        void CreateTable()
        {
            string[] fejl�c = new string[]
            {
                 "Id","Name","Email","Gender"
            };
            for (int i = 0; i < fejl�c.Count(); i++)
            {
                ws.Cells[1, i + 1] = fejl�c[i];
            }
            Models.SoftengContext softengContext = new Models.SoftengContext();
            var tmp = softengContext.People.ToList();
            object[,] t�mb = new object[tmp.Count(), fejl�c.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                t�mb[i, 0] = tmp[i].Id;
                t�mb[i, 1] = tmp[i].Name;
                t�mb[i, 2] = tmp[i].Email;
                t�mb[i, 3] = tmp[i].Gender;
            }
            int sorokszama = t�mb.GetLength(0);
            int oszlopokszama = t�mb.GetLength(1);
            Excel.Range adatrange = ws.get_Range("A2", Type.Missing).get_Resize(sorokszama, oszlopokszama);
            adatrange.Value2 = t�mb;
            Excel.Range fejl�crange = ws.get_Range("A1", Type.Missing).get_Resize(1, 4);
            fejl�crange.Font.Bold = true;
            fejl�crange.Interior.Color = Color.Fuchsia;
        }
        void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                wb = xlApp.Workbooks.Add(Missing.Value);
                ws = wb.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                wb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlApp = null;
                wb = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan be akarja z�rni az alkalmaz�st?", "", MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}