namespace Stepovyi_IS_51_Neruhomist
{
    partial class Form1
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
           // this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.candyFactoryDataSet = new Stepovyi_IS_51_Neruhomist.CandyFactoryDataSet();
            //this.таблица1TableAdapter = new Stepovyi_IS_51_Neruhomist.CandyFactoryDataSetTableAdapters.Таблица1TableAdapter();
            //this.tableAdapterManager = new Stepovyi_IS_51_Neruhomist.CandyFactoryDataSetTableAdapters.TableAdapterManager();
            this.neruhomistDbDataSet = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager1 = new Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.candyFactoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // таблица1BindingSource
            // 
            //this.таблица1BindingSource.DataMember = "Таблица1";
            //this.таблица1BindingSource.DataSource = this.candyFactoryDataSet;
            // 
            // candyFactoryDataSet
            // 
            //this.candyFactoryDataSet.DataSetName = "CandyFactoryDataSet";
            //this.candyFactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1TableAdapter
            // 
            //this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.UpdateOrder = Stepovyi_IS_51_Neruhomist.CandyFactoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.Таблица1TableAdapter = this.таблица1TableAdapter;
            // 
            // neruhomistDbDataSet
            // 
            this.neruhomistDbDataSet.DataSetName = "NeruhomistDbDataSet";
            this.neruhomistDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.neruhomistDbDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Stepovyi_IS_51_Neruhomist.NeruhomistDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 146);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(543, 220);
            this.clientsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ПІБ";
            this.dataGridViewTextBoxColumn1.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn2.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Бажаний тип нерухомості";
            this.dataGridViewTextBoxColumn4.HeaderText = "Бажаний тип нерухомості";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Максисальний бюджет ($)";
            this.dataGridViewTextBoxColumn5.HeaderText = "Максисальний бюджет ($)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 407);
            this.Controls.Add(this.clientsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            //((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            //(System.ComponentModel.ISupportInitialize)(this.candyFactoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neruhomistDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private CandyFactoryDataSet candyFactoryDataSet;
        //private System.Windows.Forms.BindingSource таблица1BindingSource;
        //private CandyFactoryDataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        //private CandyFactoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NeruhomistDbDataSet neruhomistDbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private NeruhomistDbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private NeruhomistDbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

