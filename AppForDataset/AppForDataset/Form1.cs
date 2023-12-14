using System.CodeDom.Compiler;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace AppForDataset
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private DataSet productsSet;
        private DataTable products;
        private BindingSource bindingSource;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataSet();
        }

        private void InitializeDataSet()
        {
            productsSet = new DataSet("CommissionStoreDataSet");
            products = new DataTable("Items");

            // Add field in table
            products.Columns.Add("Name", typeof(string));
            products.Columns.Add("Date", typeof(DateTime));
            products.Columns.Add("InitialPrice", typeof(decimal));

            // Set "Name" as the primary key
            products.PrimaryKey = new DataColumn[] { products.Columns["Name"] };

            // Add table in DataSet
            productsSet.Tables.Add(products);

            // Создание BindingSource и привязка его к DataSet
            bindingSource = new BindingSource();
            bindingSource.DataSource = productsSet.Tables["Items"];

            // Привязка DataGridView к BindingSource
            dataGridView1.DataSource = bindingSource;

            // Hook up the event handler for editing control showing
            //dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "Date")
            {
                if (e.Control is DataGridViewTextBoxEditingControl textBox)
                {
                    // Apply date format
                    //textBox.KeyPress -= DateTextBox_KeyPress; // to prevent event hooking multiple times
                    //textBox.KeyPress += DateTextBox_KeyPress;

                    // Set the format when the cell is being edited
                    //textBox.Text = FormatDate(textBox.Text);
                }
            }
            else if (dataGridView1.CurrentCell.OwningColumn.Name == "InitialPrice")
            {
                if (e.Control is DataGridViewTextBoxEditingControl textBox)
                {
                    // Apply numeric format
                    //textBox.KeyPress -= NumericTextBox_KeyPress; // to prevent event hooking multiple times
                    //textBox.KeyPress += NumericTextBox_KeyPress;
                }
            }
        }

        private string FormatDate(string input)
        {
            // Apply your desired date format here
            // For example, format as "dd/MM/yyyy"
            if (DateTime.TryParse(input, out DateTime date))
            {
                return date.ToString("dd/MM/yyyy");
            }
            return input;
        }

        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric digits, backspace, and slash for date
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric digits, backspace, and decimal point for numeric
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                productsSet.Clear(); // Очистка данных перед загрузкой
                productsSet.ReadXml(openFileDialog.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                productsSet.WriteXml(saveFileDialog.FileName);
            }
        }
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void UpdatePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in productsSet.Tables["Items"].Rows)
            {
                DateTime currentDate = DateTime.Now;
                DateTime date = (DateTime)row["Date"];
                decimal initialPrice = (decimal)row["InitialPrice"];

                int daysPassed = (currentDate - date).Days;
                // Логика уценки
                int count = daysPassed / 15;

                for (int i = 0; i < count;)
                {
                    initialPrice *= (decimal)0.95; // 5% уценка после 15 дней

                    if (initialPrice < (decimal)0.25 * (decimal)row["InitialPrice"])
                    {
                        // Если уценка больше 75%, устанавливаем 75%
                        initialPrice = 0.25m * (decimal)row["InitialPrice"];
                        break;
                    }
                }

                row["InitialPrice"] = initialPrice;
            }
        }

        private void ReturnProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value from the first column of the selected row
                object itemId = selectedRow.Cells["Name"].Value;

                // Find the corresponding row in the DataTable
                DataRow foundRow = products.Rows.Find(itemId);

                // Remove the row from the DataTable
                if (foundRow != null)
                {
                    products.Rows.Remove(foundRow);
                    MessageBox.Show("Row removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected row not found in DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the exception
            Exception ex = e.Exception;

            // Log or display a custom error message
            MessageBox.Show($"Error in DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, set the error status to Handled if you've handled the error
            e.ThrowException = false;
        }
    }
}