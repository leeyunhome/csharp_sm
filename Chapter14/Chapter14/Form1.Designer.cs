namespace Chapter14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelThriftMoney = new System.Windows.Forms.Label();
            this.labelLottoMoney = new System.Windows.Forms.Label();
            this.labelThriftDebt = new System.Windows.Forms.Label();
            this.labelLottoDebt = new System.Windows.Forms.Label();
            this.pictureBoxThriftHappy = new System.Windows.Forms.PictureBox();
            this.pictureBoxThriftNormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxThriftUnhappy = new System.Windows.Forms.PictureBox();
            this.pictureBoxLottoHappy = new System.Windows.Forms.PictureBox();
            this.pictureBoxLottoNormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxLottoUnhappy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelWinLotto = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftUnhappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoUnhappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 20F);
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "thrift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 20F);
            this.label2.Location = new System.Drawing.Point(335, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "lotto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Money:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Money:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Debt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Debt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status";
            // 
            // labelThriftMoney
            // 
            this.labelThriftMoney.AutoSize = true;
            this.labelThriftMoney.Location = new System.Drawing.Point(108, 93);
            this.labelThriftMoney.Name = "labelThriftMoney";
            this.labelThriftMoney.Size = new System.Drawing.Size(0, 15);
            this.labelThriftMoney.TabIndex = 6;
            // 
            // labelLottoMoney
            // 
            this.labelLottoMoney.AutoSize = true;
            this.labelLottoMoney.Location = new System.Drawing.Point(341, 93);
            this.labelLottoMoney.Name = "labelLottoMoney";
            this.labelLottoMoney.Size = new System.Drawing.Size(0, 15);
            this.labelLottoMoney.TabIndex = 7;
            // 
            // labelThriftDebt
            // 
            this.labelThriftDebt.AutoSize = true;
            this.labelThriftDebt.Location = new System.Drawing.Point(84, 118);
            this.labelThriftDebt.Name = "labelThriftDebt";
            this.labelThriftDebt.Size = new System.Drawing.Size(0, 15);
            this.labelThriftDebt.TabIndex = 8;
            // 
            // labelLottoDebt
            // 
            this.labelLottoDebt.AutoSize = true;
            this.labelLottoDebt.Location = new System.Drawing.Point(329, 118);
            this.labelLottoDebt.Name = "labelLottoDebt";
            this.labelLottoDebt.Size = new System.Drawing.Size(0, 15);
            this.labelLottoDebt.TabIndex = 9;
            // 
            // pictureBoxThriftHappy
            // 
            this.pictureBoxThriftHappy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThriftHappy.Image")));
            this.pictureBoxThriftHappy.Location = new System.Drawing.Point(77, 203);
            this.pictureBoxThriftHappy.Name = "pictureBoxThriftHappy";
            this.pictureBoxThriftHappy.Size = new System.Drawing.Size(113, 93);
            this.pictureBoxThriftHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThriftHappy.TabIndex = 10;
            this.pictureBoxThriftHappy.TabStop = false;
            this.pictureBoxThriftHappy.Visible = false;
            // 
            // pictureBoxThriftNormal
            // 
            this.pictureBoxThriftNormal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThriftNormal.Image")));
            this.pictureBoxThriftNormal.Location = new System.Drawing.Point(76, 212);
            this.pictureBoxThriftNormal.Name = "pictureBoxThriftNormal";
            this.pictureBoxThriftNormal.Size = new System.Drawing.Size(145, 125);
            this.pictureBoxThriftNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThriftNormal.TabIndex = 11;
            this.pictureBoxThriftNormal.TabStop = false;
            this.pictureBoxThriftNormal.Visible = false;
            // 
            // pictureBoxThriftUnhappy
            // 
            this.pictureBoxThriftUnhappy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThriftUnhappy.Image")));
            this.pictureBoxThriftUnhappy.Location = new System.Drawing.Point(77, 203);
            this.pictureBoxThriftUnhappy.Name = "pictureBoxThriftUnhappy";
            this.pictureBoxThriftUnhappy.Size = new System.Drawing.Size(134, 126);
            this.pictureBoxThriftUnhappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThriftUnhappy.TabIndex = 12;
            this.pictureBoxThriftUnhappy.TabStop = false;
            this.pictureBoxThriftUnhappy.Visible = false;
            // 
            // pictureBoxLottoHappy
            // 
            this.pictureBoxLottoHappy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLottoHappy.Image")));
            this.pictureBoxLottoHappy.Location = new System.Drawing.Point(344, 203);
            this.pictureBoxLottoHappy.Name = "pictureBoxLottoHappy";
            this.pictureBoxLottoHappy.Size = new System.Drawing.Size(111, 93);
            this.pictureBoxLottoHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLottoHappy.TabIndex = 13;
            this.pictureBoxLottoHappy.TabStop = false;
            this.pictureBoxLottoHappy.Visible = false;
            // 
            // pictureBoxLottoNormal
            // 
            this.pictureBoxLottoNormal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLottoNormal.Image")));
            this.pictureBoxLottoNormal.Location = new System.Drawing.Point(344, 203);
            this.pictureBoxLottoNormal.Name = "pictureBoxLottoNormal";
            this.pictureBoxLottoNormal.Size = new System.Drawing.Size(186, 134);
            this.pictureBoxLottoNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLottoNormal.TabIndex = 14;
            this.pictureBoxLottoNormal.TabStop = false;
            this.pictureBoxLottoNormal.Visible = false;
            // 
            // pictureBoxLottoUnhappy
            // 
            this.pictureBoxLottoUnhappy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLottoUnhappy.Image")));
            this.pictureBoxLottoUnhappy.Location = new System.Drawing.Point(341, 203);
            this.pictureBoxLottoUnhappy.Name = "pictureBoxLottoUnhappy";
            this.pictureBoxLottoUnhappy.Size = new System.Drawing.Size(159, 112);
            this.pictureBoxLottoUnhappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLottoUnhappy.TabIndex = 15;
            this.pictureBoxLottoUnhappy.TabStop = false;
            this.pictureBoxLottoUnhappy.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWinLotto
            // 
            this.labelWinLotto.AutoSize = true;
            this.labelWinLotto.Location = new System.Drawing.Point(344, 145);
            this.labelWinLotto.Name = "labelWinLotto";
            this.labelWinLotto.Size = new System.Drawing.Size(0, 15);
            this.labelWinLotto.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(506, 93);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelWinLotto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxLottoUnhappy);
            this.Controls.Add(this.pictureBoxLottoNormal);
            this.Controls.Add(this.pictureBoxLottoHappy);
            this.Controls.Add(this.pictureBoxThriftUnhappy);
            this.Controls.Add(this.pictureBoxThriftNormal);
            this.Controls.Add(this.pictureBoxThriftHappy);
            this.Controls.Add(this.labelLottoDebt);
            this.Controls.Add(this.labelThriftDebt);
            this.Controls.Add(this.labelLottoMoney);
            this.Controls.Add(this.labelThriftMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThriftUnhappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoUnhappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelThriftMoney;
        private System.Windows.Forms.Label labelLottoMoney;
        private System.Windows.Forms.Label labelThriftDebt;
        private System.Windows.Forms.Label labelLottoDebt;
        private System.Windows.Forms.PictureBox pictureBoxThriftHappy;
        private System.Windows.Forms.PictureBox pictureBoxThriftNormal;
        private System.Windows.Forms.PictureBox pictureBoxThriftUnhappy;
        private System.Windows.Forms.PictureBox pictureBoxLottoHappy;
        private System.Windows.Forms.PictureBox pictureBoxLottoNormal;
        private System.Windows.Forms.PictureBox pictureBoxLottoUnhappy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWinLotto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

