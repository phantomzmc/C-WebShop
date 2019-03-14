namespace TesWin1
{
    partial class EditOrder
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
            this.edit_order_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_order_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edit_order_button = new System.Windows.Forms.Button();
            this.edit_cancel_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายการที่ :";
            // 
            // edit_order_textBox
            // 
            this.edit_order_textBox.Location = new System.Drawing.Point(270, 71);
            this.edit_order_textBox.Name = "edit_order_textBox";
            this.edit_order_textBox.Size = new System.Drawing.Size(360, 20);
            this.edit_order_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อสินค้า :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "จำนวนสินค้า :";
            // 
            // total_order_textBox
            // 
            this.total_order_textBox.Location = new System.Drawing.Point(270, 198);
            this.total_order_textBox.Name = "total_order_textBox";
            this.total_order_textBox.Size = new System.Drawing.Size(360, 20);
            this.total_order_textBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ยอดรวม :";
            // 
            // edit_order_button
            // 
            this.edit_order_button.Location = new System.Drawing.Point(270, 280);
            this.edit_order_button.Name = "edit_order_button";
            this.edit_order_button.Size = new System.Drawing.Size(132, 51);
            this.edit_order_button.TabIndex = 14;
            this.edit_order_button.Text = "ตกลง";
            this.edit_order_button.UseVisualStyleBackColor = true;
            this.edit_order_button.Click += new System.EventHandler(this.edit_order_button_Click);
            // 
            // edit_cancel_button
            // 
            this.edit_cancel_button.Location = new System.Drawing.Point(498, 280);
            this.edit_cancel_button.Name = "edit_cancel_button";
            this.edit_cancel_button.Size = new System.Drawing.Size(132, 51);
            this.edit_cancel_button.TabIndex = 15;
            this.edit_cancel_button.Text = "ยกเลิก";
            this.edit_cancel_button.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(360, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.edit_cancel_button);
            this.Controls.Add(this.edit_order_button);
            this.Controls.Add(this.total_order_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_order_textBox);
            this.Controls.Add(this.label1);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edit_order_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_order_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button edit_order_button;
        private System.Windows.Forms.Button edit_cancel_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}