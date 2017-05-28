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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ListObjects_Click(object sender, EventArgs e)
        {
            ObjectList ol = new ObjectList();
            ol.ShowDialog();
        }

        private void ListClient_Click(object sender, EventArgs e)
        {
            ClientList cl = new ClientList();
            cl.ShowDialog();
        }

        private void ProgInfo_Click(object sender, EventArgs e)
        {
            ProProgram pp = new ProProgram();
            pp.ShowDialog();
        }

        private void AuthorInfo_Click(object sender, EventArgs e)
        {
            Author ai = new Author();
            ai.ShowDialog();
        }
    }
}
