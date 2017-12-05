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
using System.Windows.Forms.DataVisualization.Charting;

namespace MarketModel
{
    public partial class Form1 : Form
    {
        int initPrice;              // 交易初始价格
        double leastPriceRate;      // 最低交易价格
        int totalPersonNumber;      // 操盘手人数
        int totalExchangeNumber;    // 总交易手数
        int exchangeCyc;            // 交易周期
        int inventoryNumber;        // 货物总量
        int leastExchange;          // 最低交易手数
        double exchangeRate;        // 交易费率
        int exchangeFreqByMinite;   // 最小交易周期，以分为单位
        double exchangeIncome;      // 交易金收入 ∑（exchangeIncome × exchangeRate）
        int exchangeNumber;         // 交易手数计数

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initPrice = int.Parse(this.tBox_initialPrice.Text);
            leastPriceRate = double.Parse(this.tBox_leastPriceRate.Text) / 100;
            totalPersonNumber = int.Parse(this.tbox_totalPersonNumber.Text);
            totalExchangeNumber = int.Parse(this.tbox_totalExchangeNumber.Text);
            exchangeCyc = int.Parse(this.tBox_exchangeCyc.Text);
            inventoryNumber = int.Parse(this.tBox_inventoryNumber.Text);
            leastExchange = int.Parse(this.tBox_leastExchange.Text);
            exchangeRate = double.Parse(this.tBox_exchangeRate.Text) / 100;
            exchangeFreqByMinite = int.Parse(this.tBox_ExchangeFreq.Text);

            
            double[] exchangeEndPrice_list = new double[exchangeCyc];   // 头日收盘价格数组
            double[] exchangeStartPrice_lsit = new double[exchangeCyc]; // 次日开盘价格

            Oper[] oper_list = new Oper[totalPersonNumber];
            exchangeNumber = 0;
            exchangeIncome = 0;

            // Initial Oper list
            randomInitial(inventoryNumber, leastExchange, totalPersonNumber, initPrice, oper_list);

            int cyc = exchangeCyc;

            while (cyc > 0 && exchangeNumber <= totalExchangeNumber)
            {
                if(cyc == exchangeCyc)
                {
                    exchangeStartPrice_lsit[exchangeCyc - cyc] = initPrice;
                }
                else
                {
                    exchangeStartPrice_lsit[exchangeCyc - cyc] = exchangeEndPrice_list[exchangeCyc- 1 - cyc];
                }
                exchangeEndPrice_list[exchangeCyc - cyc] = exchangeByday(leastExchange, leastPriceRate, totalPersonNumber, exchangeFreqByMinite, exchangeStartPrice_lsit[exchangeCyc - cyc], oper_list);
                cyc--;

            }

            this.lbl_price.Text = exchangeEndPrice_list[exchangeCyc - 1].ToString();
            this.lbl_income.Text = exchangeIncome.ToString();

            // 画图操作
            chart1.Series.Clear();  // 清除默认的series
            Series exchangeStartPrice = new Series("开盘价格");
            Series exchangeEndPrice = new Series("收盘价格");

            exchangeStartPrice.ChartType = SeriesChartType.Spline;
            exchangeStartPrice.IsValueShownAsLabel = true;
            exchangeEndPrice.ChartType = SeriesChartType.Spline;
            exchangeEndPrice.IsValueShownAsLabel = true;

            for (int day = 0; day < exchangeCyc; day++)
            {
                exchangeEndPrice.Points.AddXY(day, exchangeEndPrice_list[day]);
                exchangeStartPrice.Points.AddXY(day, exchangeStartPrice_lsit[day]);
            }

            chart1.Series.Add(exchangeStartPrice);
            chart1.Series.Add(exchangeEndPrice);

        }

        private bool randomInitial(int inventoryNumber, int leastExchange, int totalPersonNumber, int inititalPrice, Oper[] oper_list)
        {
            int sum = 0;
            int divide = 0;

            divide = int.Parse((inventoryNumber / totalPersonNumber).ToString());
            divide = inventoryNumber / totalPersonNumber;
            Random ran = new Random();
            for (int i = 0; i < totalPersonNumber; i = i+2 )
            {
                int value = 0;
                int next = 0;
                
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
        private double exchangeByday(int leastExchange,double leastPriceRate, int totalPersonNumber, int exchangeFreq, double exchangeStartPrice, Oper[] oper_list)
        {
            int exchangeTimeinDay = 8;

            int freq = 60 / exchangeFreq * exchangeTimeinDay; //exchangeFreq以分钟计算结果。每分钟几次流转exchangeTimeinDay,每天交易的时间

            double exchangeEndPrice = 0;

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
                // 货物数字要开始流转，必须要遵守规则。

                for (int i = 0; i < totalPersonNumber; i++)
                {
                    Random ran_check = new Random();
                    int inventory = oper_list[(int)hashtable[i]].get_Inventory_Number();
                    int v = ran_check.Next(100);
                    if (leastExchange < inventory && v > 30) //ran_check > 30 参与交易，ran_check <=30 不参与交易。
                    {
                        Random r1 = new Random();   //在最小交易手数 - 持仓总数中的随机数
                        int value = r1.Next(leastExchange, inventory);
                        oper_list[(int)hashtable[i]].set_Inventory_Number(inventory - value);
                        Random r3 = new Random();
                        double price;
                        if (r3.Next(0,100) > 50)
                        {
                            price = Convert.ToDouble((oper_list[(int)hashtable[i]].get_Least_Price() * ( 1 + exchangeRate )).ToString("N3"));
                        }
                        else
                        {
                            price = Convert.ToDouble((oper_list[(int)hashtable[i]].get_Least_Price() * ( 1 - exchangeRate )).ToString("N3"));
                        }
                        Random r2 = new Random();   //在操盘手的编号中进行随机数
                        int indexK;
                        do
                        {
                            indexK = r2.Next(totalPersonNumber);
                        }
                        while ((int)hashtable[i] == indexK);
                        // 这个判断做的是保证价格在熔断范围内，一旦超出终止交易
                        if (price < exchangeStartPrice * (1 + leastPriceRate) && price > exchangeStartPrice * (1 - leastPriceRate))
                        {
                            oper_list[indexK].buy_Inventory(value);
                            oper_list[indexK].set_Least_Price(price);
                            exchangeIncome = Convert.ToDouble((exchangeIncome + price * exchangeRate).ToString("N3"));
                            exchangeEndPrice = price;
                            exchangeNumber++;
                        }
                        else
                        {
                            continue;
                        }
                        
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
