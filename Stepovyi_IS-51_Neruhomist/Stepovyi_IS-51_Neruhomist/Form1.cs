using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepovyi_IS_51_Neruhomist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'neruhomistDbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.neruhomistDbDataSet.Clients);
            // TODO: This line of code loads data into the 'candyFactoryDataSet.Таблица1' table. You can move, or remove it, as needed.
            //this.таблица1TableAdapter.Fill(this.candyFactoryDataSet.Таблица1);

        }
    }
}
