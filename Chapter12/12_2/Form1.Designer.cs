namespace _12_2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxMinute = new System.Windows.Forms.ListBox();
            this.listBoxColon = new System.Windows.Forms.ListBox();
            this.listBoxSecond = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxMinute
            // 
            this.listBoxMinute.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxMinute.FormattingEnabled = true;
            this.listBoxMinute.ItemHeight = 43;
            this.listBoxMinute.Location = new System.Drawing.Point(23, 59);
            this.listBoxMinute.Name = "listBoxMinute";
            this.listBoxMinute.Size = new System.Drawing.Size(120, 90);
            this.listBoxMinute.TabIndex = 0;
            // 
            // listBoxColon
            // 
            this.listBoxColon.FormattingEnabled = true;
            this.listBoxColon.ItemHeight = 15;
            this.listBoxColon.Location = new System.Drawing.Point(199, 59);
            this.listBoxColon.Name = "listBoxColon";
            this.listBoxColon.Size = new System.Drawing.Size(120, 94);
            this.listBoxColon.TabIndex = 1;
            this.listBoxColon.SelectedIndexChanged += new System.EventHandler(this.listBoxColon_SelectedIndexChanged);
            // 
            // listBoxSecond
            // 
            this.listBoxSecond.Font = new System.Drawing.Font("Gulim", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxSecond.FormattingEnabled = true;
            this.listBoxSecond.ItemHeight = 43;
            this.listBoxSecond.Location = new System.Drawing.Point(365, 59);
            this.listBoxSecond.Name = "listBoxSecond";
            this.listBoxSecond.Size = new System.Drawing.Size(120, 90);
            this.listBoxSecond.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSecond);
            this.Controls.Add(this.listBoxColon);
            this.Controls.Add(this.listBoxMinute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxMinute;
        private System.Windows.Forms.ListBox listBoxColon;
        private System.Windows.Forms.ListBox listBoxSecond;
    }
}

