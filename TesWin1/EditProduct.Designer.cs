namespace TesWin1
{
    partial class EditProduct
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
            this.edit_proid_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_proname_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_proprice_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_prodetail_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_cancel_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_proid_textBox
            // 
            this.edit_proid_textBox.Location = new System.Drawing.Point(327, 92);
            this.edit_proid_textBox.Name = "edit_proid_textBox";
            this.edit_proid_textBox.Size = new System.Drawing.Size(274, 20);
            this.edit_proid_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อสินค้า :";
            // 
            // edit_proname_textBox
            // 
            this.edit_proname_textBox.Location = new System.Drawing.Point(327, 140);
            this.edit_proname_textBox.Name = "edit_proname_textBox";
            this.edit_proname_textBox.Size = new System.Drawing.Size(274, 20);
            this.edit_proname_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ราคาสินค้า :";
            // 
            // edit_proprice_textBox
            // 
            this.edit_proprice_textBox.Location = new System.Drawing.Point(327, 183);
            this.edit_proprice_textBox.Name = "edit_proprice_textBox";
            this.edit_proprice_textBox.Size = new System.Drawing.Size(274, 20);
            this.edit_proprice_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "รายละเอียดสินค้า :";
            // 
            // edit_prodetail_textBox
            // 
            this.edit_prodetail_textBox.Location = new System.Drawing.Point(327, 225);
            this.edit_prodetail_textBox.Name = "edit_prodetail_textBox";
            this.edit_prodetail_textBox.Size = new System.Drawing.Size(274, 20);
            this.edit_prodetail_textBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ประเภทสินค้า :";
            // 
            // edit_cancel_button
            // 
            this.edit_cancel_button.Location = new System.Drawing.Point(476, 348);
            this.edit_cancel_button.Name = "edit_cancel_button";
            this.edit_cancel_button.Size = new System.Drawing.Size(125, 48);
            this.edit_cancel_button.TabIndex = 10;
            this.edit_cancel_button.Text = "ยกเลิก";
            this.edit_cancel_button.UseVisualStyleBackColor = true;
            this.edit_cancel_button.Click += new System.EventHandler(this.edit_cancel_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(225, 348);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(125, 48);
            this.edit_button.TabIndex = 11;
            this.edit_button.Text = "แก้ไข";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.edit_cancel_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit_prodetail_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit_proprice_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_proname_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_proid_textBox);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edit_proid_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_proname_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_proprice_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edit_prodetail_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button edit_cancel_button;
        private System.Windows.Forms.Button edit_button;
    }
}