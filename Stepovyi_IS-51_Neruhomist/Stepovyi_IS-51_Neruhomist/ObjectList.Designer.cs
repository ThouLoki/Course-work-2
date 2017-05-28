namespace Stepovyi_IS_51_Neruhomist
{
    partial class ObjectList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectList));
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neruhomistDbDataSet = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSet();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.objectsTableAdapter = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.ObjectsTableAdapter();
            this.tableAdapterManager = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.TableAdapterManager();
            this.neruhomistDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.objectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.objectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // objectsBindingSource
            // 
            this.objectsBindingSource.DataMember = "Objects";
            this.objectsBindingSource.DataSource = this.neruhomistDbDataSet;
            // 
            // neruhomistDbDataSet
            // 
            this.neruhomistDbDataSet.DataSetName = "NeruhomistDbDataSet";
            this.neruhomistDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Код, Місцезнаходження, [К-ксть кімнат], [Розмір(кв м)], [Вартість (" +
    "$)]\r\nFROM            Objects";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\NeruhomistDb.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Objects` (`Місцезнаходження`, `К-ксть кімнат`, `Розмір(кв м)`, `Варт" +
    "ість ($)`) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Місцезнаходження", System.Data.OleDb.OleDbType.VarWChar, 0, "Місцезнаходження"),
            new System.Data.OleDb.OleDbParameter("К-ксть_кімнат", System.Data.OleDb.OleDbType.VarWChar, 0, "К-ксть кімнат"),
            new System.Data.OleDb.OleDbParameter("Розмір(кв_м)", System.Data.OleDb.OleDbType.VarWChar, 0, "Розмір(кв м)"),
            new System.Data.OleDb.OleDbParameter("Вартість_($)", System.Data.OleDb.OleDbType.VarWChar, 0, "Вартість ($)")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.CommandTimeout = 5;
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Місцезнаходження", System.Data.OleDb.OleDbType.VarWChar, 0, "Місцезнаходження"),
            new System.Data.OleDb.OleDbParameter("К-ксть_кімнат", System.Data.OleDb.OleDbType.VarWChar, 0, "К-ксть кімнат"),
            new System.Data.OleDb.OleDbParameter("Розмір(кв_м)", System.Data.OleDb.OleDbType.VarWChar, 0, "Розмір(кв м)"),
            new System.Data.OleDb.OleDbParameter("Вартість_($)", System.Data.OleDb.OleDbType.VarWChar, 0, "Вартість ($)"),
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Місцезнаходження", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Місцезнаходження", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Місцезнаходження", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Місцезнаходження", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_К-ксть_кімнат", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "К-ксть кімнат", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_К-ксть_кімнат", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "К-ксть кімнат", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Розмір(кв_м)", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Розмір(кв м)", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Розмір(кв_м)", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Розмір(кв м)", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Вартість_($)", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Вартість ($)", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Вартість_($)", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Вартість ($)", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Місцезнаходження", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Місцезнаходження", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Місцезнаходження", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Місцезнаходження", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_К-ксть_кімнат", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "К-ксть кімнат", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_К-ксть_кімнат", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "К-ксть кімнат", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Розмір(кв_м)", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Розмір(кв м)", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Розмір(кв_м)", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Розмір(кв м)", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Вартість_($)", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Вартість ($)", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Вартість_($)", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Вартість ($)", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.FillLoadOption = System.Data.LoadOption.Upsert;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Objects", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Місцезнаходження", "Місцезнаходження"),
                        new System.Data.Common.DataColumnMapping("К-ксть кімнат", "К-ксть кімнат"),
                        new System.Data.Common.DataColumnMapping("Розмір(кв м)", "Розмір(кв м)"),
                        new System.Data.Common.DataColumnMapping("Вартість ($)", "Вартість ($)")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // objectsTableAdapter
            // 
            this.objectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // neruhomistDbDataSetBindingSource
            // 
            this.neruhomistDbDataSetBindingSource.DataSource = this.neruhomistDbDataSet;
            this.neruhomistDbDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 204);
            this.dataGridView1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dataGridView1, "Інформація з бази даних");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton1.Text = "Зберегти(ДБ)";
            this.toolStripButton1.ToolTipText = "Зберегти дані до бази даних";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 22);
            this.toolStripButton2.Text = "Зберегти(txt-Файл)";
            this.toolStripButton2.ToolTipText = "Зберегти дані до текстового файлу";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Відкрити довідку";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton4.Text = "Назад";
            this.toolStripButton4.ToolTipText = "Повернутися до невідфільтрованої БД";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.ToolTipText = "Поле для пошукового запросу";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton5.Text = "Пошук:";
            this.toolStripButton5.ToolTipText = "Знайти введене значення (кнопка)";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "Очікую на команду";
            // 
            // objectsBindingSource1
            // 
            this.objectsBindingSource1.DataMember = "Objects";
            this.objectsBindingSource1.DataSource = this.neruhomistDbDataSetBindingSource;
            // 
            // objectsBindingSource2
            // 
            this.objectsBindingSource2.DataMember = "Objects";
            this.objectsBindingSource2.DataSource = this.neruhomistDbDataSetBindingSource;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\Довідка.txt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1";
            this.toolTip1.SetToolTip(this.textBox1, "Введіть значення для фільтрування");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фільтр:";
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(138, 79);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(83, 23);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Застосувати";
            this.toolTip1.SetToolTip(this.Filter, "Застосувати введений фільтр");
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Номер",
            "Адреса",
            "Кімнати",
            "Розмір",
            "Ціна"});
            this.comboBox1.Location = new System.Drawing.Point(73, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBox1, "Оберіть категорію для філтра");
            // 
            // ObjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База об\'єктів";
            this.Load += new System.EventHandler(this.ObjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NeruhomistDbDataSet neruhomistDbDataSet;
        private System.Windows.Forms.BindingSource objectsBindingSource;
        private NeruhomistDbDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter;
        private NeruhomistDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.BindingSource neruhomistDbDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource objectsBindingSource2;
        private System.Windows.Forms.BindingSource objectsBindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}