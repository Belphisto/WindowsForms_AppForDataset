using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForDataset
{
    public partial class UserInputForm : Form
    {
        public event Action<Product> SendProduct;
        public UserInputForm()
        {
            InitializeComponent();
            this.Text = "Добавить новый товар в базу";
        }

        public UserInputForm(Product product)
        {
            InitializeComponent();
            this.Text = "Редактировать товар";

            textBoxName.Text = product.Name;
            textBoxPrice.Text = product.InitialPrice.ToString();
            dateTimePicker1.Value = product.CommissionDate;
        }

        private bool CheckValidUserInput(string input, out decimal dec)
        {
            //fix
            dec = 10;
            return true;
        }

        private bool CheckValidUserInput(string input, out string field)
        {
            //fix
            field = "temp";
            return true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Product send = new Product();
            if (CheckValidUserInput(textBoxName.Text, out string name)  
                && CheckValidUserInput(textBoxPrice.Text, out decimal price))
            {
                send.Name = name;
                send.CommissionDate = dateTimePicker1.Value;
                send.InitialPrice = price;

                SendProduct?.Invoke(send);
                this.Close();
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
