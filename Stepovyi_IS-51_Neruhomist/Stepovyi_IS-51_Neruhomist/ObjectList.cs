using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stepovyi_IS_51_Neruhomist
{
    public partial class ObjectList : Form
    {
        OleDbDataAdapter adap = null;
        DataSet ds = new DataSet();
        DataView dv;
        public ObjectList()
        {
            InitializeComponent();
        }

        private void ObjectList_Load(object sender, EventArgs e)
        {
            adap = new OleDbDataAdapter(@"SELECT * FROM Objects",
               new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\NeruhomistDb.mdb;Persist Security Info=True"));
            OleDbCommandBuilder bulder = new OleDbCommandBuilder(adap);
            adap.UpdateCommand = bulder.GetUpdateCommand();
            adap.InsertCommand = bulder.GetInsertCommand();
            adap.DeleteCommand = bulder.GetDeleteCommand();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            comboBox1.SelectedItem = "Номер";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            adap.Update(ds.Tables[0]);
            toolStripStatusLabel1.Text = "Зберігаю зміни до \"NeruhomistDb.mdb\", в директорію з виконуваним файлом...";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter writer = new System.IO.StringWriter();
            ds.Tables[0].WriteXml(writer, XmlWriteMode.IgnoreSchema, false);
            System.IO.StreamWriter file = new System.IO.StreamWriter(".\\outputObjects.txt");
            file.WriteLine(writer.ToString());
            file.Close();
            toolStripStatusLabel1.Text = "Зберігаю до \"outputObjects.txt\", рекомендується відкрити файл в браузері...";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Відкриваю довідку...";
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            try 
            {
                dv = new DataView(ds.Tables[0]);
                dataGridView1.DataSource = dv;
                dv.RowFilter = comboBox1.Items[comboBox1.SelectedIndex].ToString() + "='" + textBox1.Text + "'";
                toolStripStatusLabel1.Text = "Фільтрую дані за заданим списком...";
            }
            catch
            {
                MessageBox.Show("В обраному полі відсутні введені дані", "Помилка даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = ds.Tables[0];
            toolStripStatusLabel1.Text = "Повертаюсь до невідфільтрованої БД...";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) dataGridView1.Rows[i].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    if (dataGridView1[k, i].Value.ToString() == toolStripTextBox1.Text)
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
            currencyManager1.ResumeBinding();
            toolStripStatusLabel1.Text = "Шукаю введене значення...";
        }
    }
}
