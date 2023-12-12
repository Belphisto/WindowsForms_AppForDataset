using System.Data;
using System.Windows.Forms;

namespace AppForDataset
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private DataSet dataSet;
        private DataTable dataTable;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataSet();
            InitializeUI();
        }

        private void InitializeDataSet()
        {
            dataSet = new DataSet("CommissionStoreDataSet");
            dataTable = new DataTable("Items");

            // Добавление полей в таблицу
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("InitialPrice", typeof(decimal));

            // Добавление таблицы в DataSet
            dataSet.Tables.Add(dataTable);

            // Настройка отношений, если необходимо
            // dataSet.Relations.Add("relationName", parentColumn, childColumn);
        }

        private void InitializeUI()
        {
            // Настройка DataGridView
            dataGridView1.DataSource = dataSet.Tables["Items"];
        }
    }
}