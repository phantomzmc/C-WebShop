namespace TesWin1
{
    partial class AddOrder
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
            this.user_comboBox = new System.Windows.Forms.ComboBox();
            this.product_comboBox = new System.Windows.Forms.ComboBox();
            this.qty_comboBox = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qty_label = new System.Windows.Forms.Label();
            this.price_label2 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submit_button2 = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.promo_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_comboBox
            // 
            this.user_comboBox.FormattingEnabled = true;
            this.user_comboBox.Location = new System.Drawing.Point(536, 60);
            this.user_comboBox.Name = "user_comboBox";
            this.user_comboBox.Size = new System.Drawing.Size(252, 21);
            this.user_comboBox.TabIndex = 0;
            // 
            // product_comboBox
            // 
            this.product_comboBox.FormattingEnabled = true;
            this.product_comboBox.Location = new System.Drawing.Point(115, 117);
            this.product_comboBox.Name = "product_comboBox";
            this.product_comboBox.Size = new System.Drawing.Size(368, 21);
            this.product_comboBox.TabIndex = 1;
            this.product_comboBox.SelectedIndexChanged += new System.EventHandler(this.product_comboBox_SelectedIndexChanged);
            // 
            // qty_comboBox
            // 
            this.qty_comboBox.FormattingEnabled = true;
            this.qty_comboBox.Location = new System.Drawing.Point(115, 179);
            this.qty_comboBox.Name = "qty_comboBox";
            this.qty_comboBox.Size = new System.Drawing.Size(166, 21);
            this.qty_comboBox.TabIndex = 2;
            this.qty_comboBox.SelectedIndexChanged += new System.EventHandler(this.qty_comboBox_SelectedIndexChanged);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(511, 113);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(124, 87);
            this.submit_button.TabIndex = 3;
            this.submit_button.Text = "OK";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User";
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Location = new System.Drawing.Point(482, 281);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(13, 13);
            this.qty_label.TabIndex = 7;
            this.qty_label.Text = "0";
            // 
            // price_label2
            // 
            this.price_label2.AutoSize = true;
            this.price_label2.Location = new System.Drawing.Point(467, 252);
            this.price_label2.Name = "price_label2";
            this.price_label2.Size = new System.Drawing.Size(28, 13);
            this.price_label2.TabIndex = 8;
            this.price_label2.Text = "0.00";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(467, 308);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(28, 13);
            this.total_label.TabIndex = 9;
            this.total_label.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "รวม :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "จำนวน :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ราคา :";
            // 
            // submit_button2
            // 
            this.submit_button2.Location = new System.Drawing.Point(374, 349);
            this.submit_button2.Name = "submit_button2";
            this.submit_button2.Size = new System.Drawing.Size(157, 66);
            this.submit_button2.TabIndex = 13;
            this.submit_button2.Text = "Submit";
            this.submit_button2.UseVisualStyleBackColor = true;
            this.submit_button2.Click += new System.EventHandler(this.submit_button2_Click);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(112, 60);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(30, 13);
            this.date_label.TabIndex = 14;
            this.date_label.Text = "Date";
            // 
            // promo_comboBox
            // 
            this.promo_comboBox.FormattingEnabled = true;
            this.promo_comboBox.Location = new System.Drawing.Point(295, 179);
            this.promo_comboBox.Name = "promo_comboBox";
            this.promo_comboBox.Size = new System.Drawing.Size(188, 21);
            this.promo_comboBox.TabIndex = 15;
            this.promo_comboBox.SelectedIndexChanged += new System.EventHandler(this.promo_comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Discount";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.promo_comboBox);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.submit_button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.price_label2);
            this.Controls.Add(this.qty_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.qty_comboBox);
            this.Controls.Add(this.product_comboBox);
            this.Controls.Add(this.user_comboBox);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox user_comboBox;
        private System.Windows.Forms.ComboBox product_comboBox;
        private System.Windows.Forms.ComboBox qty_comboBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.Label price_label2;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit_button2;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ComboBox promo_comboBox;
        private System.Windows.Forms.Label label7;
    }
}