namespace MarketModel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_totalExchangeNumber = new System.Windows.Forms.TextBox();
            this.tbox_totalPersonNumber = new System.Windows.Forms.TextBox();
            this.tBox_exchangeCyc = new System.Windows.Forms.TextBox();
            this.tBox_inventoryNumber = new System.Windows.Forms.TextBox();
            this.tBox_initialPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox_leastPriceRate = new System.Windows.Forms.TextBox();
            this.tBox_leastExchange = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tBox_exchangeRate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tBox_ExchangeFreq = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cBox_Cyc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易总量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "初始价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "市场交易手总数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(49, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "操盘人总数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(49, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "市场交易周期：";
            // 
            // tbox_totalExchangeNumber
            // 
            this.tbox_totalExchangeNumber.Location = new System.Drawing.Point(176, 41);
            this.tbox_totalExchangeNumber.Name = "tbox_totalExchangeNumber";
            this.tbox_totalExchangeNumber.Size = new System.Drawing.Size(140, 21);
            this.tbox_totalExchangeNumber.TabIndex = 5;
            // 
            // tbox_totalPersonNumber
            // 
            this.tbox_totalPersonNumber.Location = new System.Drawing.Point(176, 69);
            this.tbox_totalPersonNumber.Name = "tbox_totalPersonNumber";
            this.tbox_totalPersonNumber.Size = new System.Drawing.Size(140, 21);
            this.tbox_totalPersonNumber.TabIndex = 6;
            // 
            // tBox_exchangeCyc
            // 
            this.tBox_exchangeCyc.Location = new System.Drawing.Point(176, 102);
            this.tBox_exchangeCyc.Name = "tBox_exchangeCyc";
            this.tBox_exchangeCyc.Size = new System.Drawing.Size(140, 21);
            this.tBox_exchangeCyc.TabIndex = 7;
            // 
            // tBox_inventoryNumber
            // 
            this.tBox_inventoryNumber.Location = new System.Drawing.Point(176, 151);
            this.tBox_inventoryNumber.Name = "tBox_inventoryNumber";
            this.tBox_inventoryNumber.Size = new System.Drawing.Size(140, 21);
            this.tBox_inventoryNumber.TabIndex = 8;
            // 
            // tBox_initialPrice
            // 
            this.tBox_initialPrice.Location = new System.Drawing.Point(176, 189);
            this.tBox_initialPrice.Name = "tBox_initialPrice";
            this.tBox_initialPrice.Size = new System.Drawing.Size(140, 21);
            this.tBox_initialPrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(49, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "熔断率：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(49, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "最低交易手数：";
            // 
            // tBox_leastPriceRate
            // 
            this.tBox_leastPriceRate.Location = new System.Drawing.Point(176, 225);
            this.tBox_leastPriceRate.Name = "tBox_leastPriceRate";
            this.tBox_leastPriceRate.Size = new System.Drawing.Size(140, 21);
            this.tBox_leastPriceRate.TabIndex = 12;
            // 
            // tBox_leastExchange
            // 
            this.tBox_leastExchange.Location = new System.Drawing.Point(176, 260);
            this.tBox_leastExchange.Name = "tBox_leastExchange";
            this.tBox_leastExchange.Size = new System.Drawing.Size(140, 21);
            this.tBox_leastExchange.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(240, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "开始模拟";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "手";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "人";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "天";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "手";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "元/手";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "手";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(49, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "交易费率：";
            // 
            // tBox_exchangeRate
            // 
            this.tBox_exchangeRate.Location = new System.Drawing.Point(176, 298);
            this.tBox_exchangeRate.Name = "tBox_exchangeRate";
            this.tBox_exchangeRate.Size = new System.Drawing.Size(140, 21);
            this.tBox_exchangeRate.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(49, 341);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "交易周期：";
            // 
            // tBox_ExchangeFreq
            // 
            this.tBox_ExchangeFreq.Location = new System.Drawing.Point(176, 341);
            this.tBox_ExchangeFreq.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_ExchangeFreq.Name = "tBox_ExchangeFreq";
            this.tBox_ExchangeFreq.Size = new System.Drawing.Size(140, 21);
            this.tBox_ExchangeFreq.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(334, 346);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 27;
            this.label18.Text = "分钟";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(49, 446);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 19);
            this.label19.TabIndex = 28;
            this.label19.Text = "最终价格：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(49, 484);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 19);
            this.label20.TabIndex = 29;
            this.label20.Text = "交易金收入：";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(167, 452);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(47, 12);
            this.lbl_price.TabIndex = 30;
            this.lbl_price.Text = "label21";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Location = new System.Drawing.Point(167, 486);
            this.lbl_income.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(47, 12);
            this.lbl_income.TabIndex = 31;
            this.lbl_income.Text = "label22";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(410, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(843, 253);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(410, 298);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(843, 271);
            this.chart2.TabIndex = 33;
            this.chart2.Text = "chart2";
            // 
            // cBox_Cyc
            // 
            this.cBox_Cyc.FormattingEnabled = true;
            this.cBox_Cyc.Location = new System.Drawing.Point(410, 271);
            this.cBox_Cyc.Name = "cBox_Cyc";
            this.cBox_Cyc.Size = new System.Drawing.Size(134, 20);
            this.cBox_Cyc.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 581);
            this.Controls.Add(this.cBox_Cyc);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tBox_ExchangeFreq);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tBox_exchangeRate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBox_leastExchange);
            this.Controls.Add(this.tBox_leastPriceRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBox_initialPrice);
            this.Controls.Add(this.tBox_inventoryNumber);
            this.Controls.Add(this.tBox_exchangeCyc);
            this.Controls.Add(this.tbox_totalPersonNumber);
            this.Controls.Add(this.tbox_totalExchangeNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_totalExchangeNumber;
        private System.Windows.Forms.TextBox tbox_totalPersonNumber;
        private System.Windows.Forms.TextBox tBox_exchangeCyc;
        private System.Windows.Forms.TextBox tBox_inventoryNumber;
        private System.Windows.Forms.TextBox tBox_initialPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBox_leastPriceRate;
        private System.Windows.Forms.TextBox tBox_leastExchange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBox_exchangeRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBox_ExchangeFreq;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox cBox_Cyc;
    }
}

