using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketModel
{
    class Oper
    {
        private int inventory_number { get; set; }
        private int least_price { get; set; }
        private double cash { get; set; }
        private int exchange_number { get; set; }
        private double exchange_rate { get; set; }
        private double security_deposit { get; set; }

        public void set_Inventory_Number(int Inventory_Number)
        {
            inventory_number = Inventory_Number;
        }

        public void set_Least_Price(int Least_Price)
        {
            least_price = Least_Price;
        }

        public void set_Exchang_Rate(double Exchange_Rate)
        {
            exchange_rate = Exchange_Rate;
        }

        public void set_Security_Deposit(double Security_Deposit)
        {
            security_deposit = Security_Deposit;
        }

        public void buy_Inventory(int inventory)
        {
            inventory_number = inventory_number + inventory;
        }

        public int get_Inventory_Number()
        {
            return inventory_number;
        }

        public int get_Least_Price()
        {
            return least_price;
        }

        public double get_Exchang_Rate()
        {
            return exchange_rate;
        }

        public double get_Security_Deposit()
        {
            return security_deposit;
        }


    }
}
