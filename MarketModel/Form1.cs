using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initPrice = System.Int32.Parse(this.tBox_initialPrice.Text);
            leastPrice = System.Int32.Parse(this.tBox_leastPrice.Text);
            totalPersonNumber = System.Int32.Parse(this.tbox_totalPersonNumber.Text);
            totalExchangeNumber = System.Int32.Parse(this.tbox_totalExchangeNumber.Text);
            exchangeCyc = System.Int32.Parse(this.tBox_exchangeCyc.Text);
            inventoryNumber = System.Int32.Parse(this.tBox_inventoryNumber.Text);
            leastExchange = System.Int32.Parse(this.tBox_leastExchange.Text);
            exchangeRate = System.Double.Parse(this.tBox_exchangeRate.Text);

            int exchangeNumber = 0; // 交易手数计数
            int exchangeEndPrice = 0;   // 头日收盘价格
            int exchangeStartPrice = 0; // 次日开盘价格

            Oper[] oper_list = new Oper[totalPersonNumber];

            // Initial Oper list

            while (exchangeCyc >= 0 && exchangeNumber <= totalExchangeNumber)
            {

                exchangeCyc--;
            }
        }

    }
}
