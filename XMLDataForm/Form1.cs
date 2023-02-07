using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLDataForm
{
    public partial class Form1 : Form
    {
        static string currentDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Shipper.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(currentDocPath);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
