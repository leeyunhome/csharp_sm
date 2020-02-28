namespace _11_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHumanHp = new System.Windows.Forms.Label();
            this.labelAlienHp = new System.Windows.Forms.Label();
            this.buttonHumanRecover = new System.Windows.Forms.Button();
            this.buttonFight = new System.Windows.Forms.Button();
            this.buttonAlienRecover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(222, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# WAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(98, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "HUMAN vs ALIEN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(109, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Human";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(411, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(109, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "HP:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(411, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "HP:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelHumanHp
            // 
            this.labelHumanHp.AutoSize = true;
            this.labelHumanHp.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelHumanHp.Location = new System.Drawing.Point(217, 257);
            this.labelHumanHp.Name = "labelHumanHp";
            this.labelHumanHp.Size = new System.Drawing.Size(0, 48);
            this.labelHumanHp.TabIndex = 6;
            // 
            // labelAlienHp
            // 
            this.labelAlienHp.AutoSize = true;
            this.labelAlienHp.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAlienHp.Location = new System.Drawing.Point(508, 257);
            this.labelAlienHp.Name = "labelAlienHp";
            this.labelAlienHp.Size = new System.Drawing.Size(0, 48);
            this.labelAlienHp.TabIndex = 7;
            // 
            // buttonHumanRecover
            // 
            this.buttonHumanRecover.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonHumanRecover.Location = new System.Drawing.Point(117, 337);
            this.buttonHumanRecover.Name = "buttonHumanRecover";
            this.buttonHumanRecover.Size = new System.Drawing.Size(137, 44);
            this.buttonHumanRecover.TabIndex = 8;
            this.buttonHumanRecover.Text = "revive";
            this.buttonHumanRecover.UseVisualStyleBackColor = true;
            this.buttonHumanRecover.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFight
            // 
            this.buttonFight.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonFight.Location = new System.Drawing.Point(277, 337);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(139, 57);
            this.buttonFight.TabIndex = 9;
            this.buttonFight.Text = "Fight!";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // buttonAlienRecover
            // 
            this.buttonAlienRecover.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAlienRecover.Location = new System.Drawing.Point(422, 337);
            this.buttonAlienRecover.Name = "buttonAlienRecover";
            this.buttonAlienRecover.Size = new System.Drawing.Size(137, 44);
            this.buttonAlienRecover.TabIndex = 10;
            this.buttonAlienRecover.Text = "revive";
            this.buttonAlienRecover.UseVisualStyleBackColor = true;
            this.buttonAlienRecover.Click += new System.EventHandler(this.buttonAlienRecover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAlienRecover);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.buttonHumanRecover);
            this.Controls.Add(this.labelAlienHp);
            this.Controls.Add(this.labelHumanHp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelHumanHp;
        private System.Windows.Forms.Label labelAlienHp;
        private System.Windows.Forms.Button buttonHumanRecover;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Button buttonAlienRecover;
    }
}

