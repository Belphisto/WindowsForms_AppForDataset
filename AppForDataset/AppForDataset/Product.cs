using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDataset
{
    public class Product
    {
        private string _name;
        private DateTime _commissionDate;
        private decimal _initialPrice;

        public string Name { get { return _name; } set { _name = value; } }
        public DateTime CommissionDate { get { return _commissionDate; } set { _commissionDate = value; } }
        public decimal InitialPrice { get { return _initialPrice;} set { _initialPrice = value; } }

        // Метод для изменения цены товара
        public void UpdatePrice()
        {
            int daysPassed = (DateTime.Now - _commissionDate).Days;

            if (daysPassed > 15 && daysPassed <= 30)
            {
                _initialPrice *= (decimal)0.95; // 5% уценка после 15 дней
            }
            else if (daysPassed > 30 && daysPassed <= 45)
            {
                _initialPrice *= (decimal)0.9; // Дополнительная 5% уценка после 30 дней
            }
            else if (daysPassed > 45)
            {
                _initialPrice *= (decimal)0.25; // Максимальная 75% уценка после 45 дней
            }
        }
    }
}
