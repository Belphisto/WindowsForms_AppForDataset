using System.CodeDom.Compiler;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AppForDataset
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private DataSet productsSet;
        private DataTable products;
        private BindingSource bindingSource;

        string saveFileName = "";
        int countDaysForReturn = 90;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataSet();
            InitializeUI();
        }
        private void InitializeUI()
        {
            CreateToolStripButton.Click += CreateToolStripMenuItem_Click;
            OpenToolStripButton.Click += OpenToolStripMenuItem_Click;
            SaveToolStripButton.Click += SaveToolStripMenuItem_Click;
            AboutProgrammToolStripButton.Click += AboutProgrammToolStripMenuItem_Click;
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
            if (productsSet.Tables["Items"].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want save this dataset?", "Saving?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                productsSet.Clear(); // Очистка данных перед загрузкой
                productsSet.ReadXml(openFileDialog.FileName);
                saveFileName = openFileDialog.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileName == "")
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                productsSet.WriteXml(saveFileName);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                productsSet.WriteXml(saveFileDialog.FileName);
                saveFileName = saveFileDialog.FileName;
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (productsSet.Tables["Items"].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want save this dataset?", "Saving?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                    saveFileName = "";
                    InitializeDataSet();
                }
                else if (result == DialogResult.No)
                {
                    saveFileName = "";
                    InitializeDataSet();
                }
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productsSet.Tables["Items"].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want save this dataset?", "Saving?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                    saveFileName = "";
                    InitializeDataSet();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            MessageBox.Show("Project Windows Forms\n" +
                "Target Platform: .Net 6.0 (long-term support)\n\n" +
                "Completed by: Maria Antaleeva\n" +
                "group: EU-239\n\n\n", "About Programm");
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

        private void CheckUserInput()
        {
            // Âûçûâàåì InputBox äëÿ ââîäà ñòðîêè
            string userInput = Interaction.InputBox($"Введите количество дней, спустя которые товар считается нераспроданным: ");

            // Check if the user pressed "Cancel" or entered an empty string
            if (string.IsNullOrEmpty(userInput))
            {
                countDaysForReturn = 90;
            }
            else
            {
                if (int.TryParse(userInput, out int count))
                {
                    countDaysForReturn = count;
                }
                else 
                {
                    countDaysForReturn = 90;
                    MessageBox.Show("Неверный формат ввода числа. Установлено значение по умолчанию = 90 дней", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserInput();
            List<DataRow> fordeleted = new List<DataRow>();
            foreach (DataRow row in productsSet.Tables["Items"].Rows)
            {
                DateTime currentDate = DateTime.Now;
                DateTime date = (DateTime)row["Date"];

                int daysPassed = (currentDate - date).Days;

                if(daysPassed >= countDaysForReturn)
                {
                    fordeleted.Add(row);
                }
            }
            foreach( DataRow row in fordeleted)
            {
                products.Rows.Remove(row);
            }
            MessageBox.Show("Весь непроданный спустя заданное количество дней товар успешно возвращен владельцам", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SellToolStripMenuItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Product sold successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected row not found in DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to sell.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the exception
            Exception ex = e.Exception;

            // Log or display a custom error message
            MessageBox.Show($"Error in DataGridView: {ex.Message}\n\n DateFormat:dd/mm/YYYY or dd.mm.YYYY \n price format: 12,12 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, set the error status to Handled if you've handled the error
            e.ThrowException = false;
        }
    }
}