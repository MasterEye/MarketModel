using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketModel
{
    public partial class Form1 : Form
    {
        int initPrice;              // 交易初始价格
        int leastPrice;             // 最低交易价格
        int totalPersonNumber;      // 操盘手人数
        int totalExchangeNumber;    // 总交易手数
        int exchangeCyc;            // 交易周期
        int inventoryNumber;        // 货物总量
        int leastExchange;          // 最低交易手数
        double exchangeRate;        // 交易费率
        int exchangeFreqByMinite;   // 最小交易周期，以分为单位
        double exchangeIncome;      // 交易金收入 ∑（exchangeIncome × exchangeRate）

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initPrice = int.Parse(this.tBox_initialPrice.Text);
            leastPrice = int.Parse(this.tBox_leastPrice.Text);
            totalPersonNumber = int.Parse(this.tbox_totalPersonNumber.Text);
            totalExchangeNumber = int.Parse(this.tbox_totalExchangeNumber.Text);
            exchangeCyc = int.Parse(this.tBox_exchangeCyc.Text);
            inventoryNumber = int.Parse(this.tBox_inventoryNumber.Text);
            leastExchange = int.Parse(this.tBox_leastExchange.Text);
            exchangeRate = double.Parse(this.tBox_exchangeRate.Text) / 100;
            exchangeFreqByMinite = int.Parse(this.tBox_ExchangeFreq.Text);

            int exchangeNumber = 0; // 交易手数计数
            int[] exchangeEndPrice_list = new int[exchangeCyc];   // 头日收盘价格数组
            int[] exchangeStartPrice_lsit = new int[exchangeCyc]; // 次日开盘价格

            Oper[] oper_list = new Oper[totalPersonNumber];

            // Initial Oper list
            randomInitial(inventoryNumber, leastExchange, totalPersonNumber, leastExchange, oper_list);

            int cyc = exchangeCyc;

            while (cyc >= 0 && exchangeNumber <= totalExchangeNumber)
            {
                if(cyc == exchangeCyc)
                {
                    exchangeStartPrice_lsit[exchangeCyc - cyc] = 0;
                }
                else
                {
                    exchangeStartPrice_lsit[exchangeCyc - cyc] = exchangeEndPrice_list[exchangeCyc- 1 - cyc];
                }
                exchangeEndPrice_list[exchangeCyc - cyc] = exchangeByday(leastPrice, leastPrice, totalPersonNumber, exchangeFreqByMinite, oper_list);
                cyc--;

            }

            this.lbl_price.Text = exchangeEndPrice_list[exchangeCyc].ToString();
            this.lbl_income.Text = exchangeIncome.ToString();
        }

        private bool randomInitial(int inventoryNumber, int leastExchange, int totalPersonNumber, int inititalPrice, Oper[] oper_list)
        {
            int sum = 0;
            int divide = 0;

            divide = int.Parse((inventoryNumber / totalPersonNumber).ToString());
            divide = inventoryNumber / totalPersonNumber;

            for (int i = 0; i < totalPersonNumber; i = i+2 )
            {
                int value = 0;
                int next = 0;
                Random ran = new Random();

                try
                {
                    value = ran.Next(leastExchange, divide);
                }
                catch
                {
                    
                }

                next = divide * 2 - value;
                oper_list[i] = new Oper();
                oper_list[i + 1] = new Oper();
                oper_list[i].set_Inventory_Number(value);
                oper_list[i].set_Least_Price(inititalPrice);
                oper_list[i + 1].set_Inventory_Number(next);
                oper_list[i + 1].set_Least_Price(inititalPrice);
                sum = value + next;
            }

            if (sum == inventoryNumber)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 一天的交易过程，返回当天最终交易的价格，作为第二天的初始价格。
        /// </summary>
        /// <param name="leastExchange">最小交易手数，限定最低的交易量</param>
        /// <param name="leastPrice">开盘的初始价格</param>
        /// <param name="totalPersonNumber">总操盘人数</param>
        /// <param name="exchangeFreq">最小交易周期，如exchangeFreqByMinite相同</param>
        /// <param name="oper_list">操盘手的集合</param>
        /// <returns></returns>
        private int exchangeByday(int leastExchange,int leastPrice, int totalPersonNumber, int exchangeFreq, Oper[] oper_list)
        {
            int exchangeTimeinDay = 8;

            int freq = 60 / exchangeFreq * exchangeTimeinDay;

            int exchangeEndPrice = 0;
            //int exchangeStartPrice = 0;

            for (int f=0; f < freq; f++)
            {
                // 0 - totalPersonNumber中的随机数，并保存在hashtable中。
                Hashtable hashtable = new Hashtable();
                Random ran_index = new Random();
                for (int i = 0; i < totalPersonNumber; i++)
                {
                    int value;
                    do
                    {
                        value = ran_index.Next(totalPersonNumber);
                    }
                    while (hashtable.ContainsValue(value));

                    hashtable.Add(i, value);
                }
                //TODO 货物数字要开始流转，必须要遵守规则。

                for (int i = 0; i < totalPersonNumber; i++)
                {
                    Random ran_check = new Random();
                    int inventory = oper_list[(int)hashtable[i]].get_Inventory_Number();
                    if (leastExchange < inventory && ran_check.Next(100) > 50) //ran_check > 50 参与交易，ran_check <=50 不参与交易。
                    {
                        Random r1 = new Random();   //在最小交易手数 - 持仓总数中的随机数
                        int value = r1.Next(leastExchange, inventory);
                        oper_list[(int)hashtable[i]].set_Inventory_Number(inventory - value);
                        int price = oper_list[(int)hashtable[i]].get_Least_Price() + leastPrice;
                        Random r2 = new Random();   //在操盘手的编号中进行随机数
                        int indexK;
                        do
                        {
                            indexK = r2.Next(totalPersonNumber);
                        }
                        while ((int)hashtable[i] != indexK);
                        oper_list[indexK].buy_Inventory(value);
                        oper_list[(int)hashtable[i]].set_Least_Price(price);
                        exchangeIncome = exchangeIncome + price * exchangeRate;
                        exchangeEndPrice = price;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return exchangeEndPrice;
        }

    }
}
