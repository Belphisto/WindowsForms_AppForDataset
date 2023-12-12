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

            // ���������� ����� � �������
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("InitialPrice", typeof(decimal));

            // ���������� ������� � DataSet
            dataSet.Tables.Add(dataTable);

            // ��������� ���������, ���� ����������
            // dataSet.Relations.Add("relationName", parentColumn, childColumn);
        }

        private void InitializeUI()
        {
            // ��������� DataGridView
            dataGridView1.DataSource = dataSet.Tables["Items"];
        }
    }
}