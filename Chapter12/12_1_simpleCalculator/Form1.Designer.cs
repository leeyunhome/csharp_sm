namespace _12_1_simpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxNum1 = new System.Windows.Forms.Label();
            this.textBoxOperator = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxOperator = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.AutoSize = true;
            this.textBoxNum1.Location = new System.Drawing.Point(47, 55);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(82, 15);
            this.textBoxNum1.TabIndex = 0;
            this.textBoxNum1.Text = "first number";
            // 
            // textBoxOperator
            // 
            this.textBoxOperator.AutoSize = true;
            this.textBoxOperator.Location = new System.Drawing.Point(50, 86);
            this.textBoxOperator.Name = "textBoxOperator";
            this.textBoxOperator.Size = new System.Drawing.Size(61, 15);
            this.textBoxOperator.TabIndex = 1;
            this.textBoxOperator.Text = "operator";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.AutoSize = true;
            this.textBoxNum2.Location = new System.Drawing.Point(53, 117);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(108, 15);
            this.textBoxNum2.TabIndex = 2;
            this.textBoxNum2.Text = "second number";
            // 
            // textBoxResult
            // 
            this.textBoxResult.AutoSize = true;
            this.textBoxResult.Location = new System.Drawing.Point(50, 151);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(42, 15);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.Text = "result";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(332, 55);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(114, 111);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Calculation";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(184, 55);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 25);
            this.txtBoxNum1.TabIndex = 5;
            this.txtBoxNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxOperator
            // 
            this.txtBoxOperator.Location = new System.Drawing.Point(184, 86);
            this.txtBoxOperator.Name = "txtBoxOperator";
            this.txtBoxOperator.Size = new System.Drawing.Size(100, 25);
            this.txtBoxOperator.TabIndex = 5;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(184, 117);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 25);
            this.txtBoxNum2.TabIndex = 5;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(184, 151);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(100, 25);
            this.txtBoxResult.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxOperator);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxOperator);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Form1";
            this.Text = "simple calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBoxNum1;
        private System.Windows.Forms.Label textBoxOperator;
        private System.Windows.Forms.Label textBoxNum2;
        private System.Windows.Forms.Label textBoxResult;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox txtBoxOperator;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

