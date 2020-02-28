namespace _12_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSecond = new System.Windows.Forms.ListBox();
            this.listBoxColon = new System.Windows.Forms.ListBox();
            this.listBoxmSecond = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxLapTime = new System.Windows.Forms.ListBox();
            this.buttonLapTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(161, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "abc";
            // 
            // listBoxSecond
            // 
            this.listBoxSecond.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxSecond.FormattingEnabled = true;
            this.listBoxSecond.ItemHeight = 43;
            this.listBoxSecond.Location = new System.Drawing.Point(32, 124);
            this.listBoxSecond.Name = "listBoxSecond";
            this.listBoxSecond.Size = new System.Drawing.Size(120, 90);
            this.listBoxSecond.TabIndex = 1;
            // 
            // listBoxColon
            // 
            this.listBoxColon.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxColon.FormattingEnabled = true;
            this.listBoxColon.ItemHeight = 43;
            this.listBoxColon.Location = new System.Drawing.Point(169, 124);
            this.listBoxColon.Name = "listBoxColon";
            this.listBoxColon.Size = new System.Drawing.Size(66, 90);
            this.listBoxColon.TabIndex = 2;
            // 
            // listBoxmSecond
            // 
            this.listBoxmSecond.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxmSecond.FormattingEnabled = true;
            this.listBoxmSecond.ItemHeight = 43;
            this.listBoxmSecond.Location = new System.Drawing.Point(262, 124);
            this.listBoxmSecond.Name = "listBoxmSecond";
            this.listBoxmSecond.Size = new System.Drawing.Size(120, 90);
            this.listBoxmSecond.TabIndex = 3;
            this.listBoxmSecond.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonStart.Location = new System.Drawing.Point(32, 258);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(137, 73);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonStop.Location = new System.Drawing.Point(175, 258);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(135, 73);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonReset.Location = new System.Drawing.Point(318, 258);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 54);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // listBoxLapTime
            // 
            this.listBoxLapTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxLapTime.FormattingEnabled = true;
            this.listBoxLapTime.ItemHeight = 15;
            this.listBoxLapTime.Location = new System.Drawing.Point(680, 0);
            this.listBoxLapTime.Name = "listBoxLapTime";
            this.listBoxLapTime.Size = new System.Drawing.Size(120, 450);
            this.listBoxLapTime.TabIndex = 7;
            // 
            // buttonLapTime
            // 
            this.buttonLapTime.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLapTime.Location = new System.Drawing.Point(461, 258);
            this.buttonLapTime.Name = "buttonLapTime";
            this.buttonLapTime.Size = new System.Drawing.Size(170, 54);
            this.buttonLapTime.TabIndex = 8;
            this.buttonLapTime.Text = "lap";
            this.buttonLapTime.UseVisualStyleBackColor = true;
            this.buttonLapTime.Click += new System.EventHandler(this.buttonLapTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLapTime);
            this.Controls.Add(this.listBoxLapTime);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxmSecond);
            this.Controls.Add(this.listBoxColon);
            this.Controls.Add(this.listBoxSecond);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSecond;
        private System.Windows.Forms.ListBox listBoxColon;
        private System.Windows.Forms.ListBox listBoxmSecond;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxLapTime;
        private System.Windows.Forms.Button buttonLapTime;
    }
}

