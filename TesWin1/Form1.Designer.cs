namespace TesWin1
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
            this.productname_textBox = new System.Windows.Forms.TextBox();
            this.productprice_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productdetail_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeproduct_comboBox = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // productname_textBox
            // 
            this.productname_textBox.Location = new System.Drawing.Point(236, 65);
            this.productname_textBox.Name = "productname_textBox";
            this.productname_textBox.Size = new System.Drawing.Size(321, 20);
            this.productname_textBox.TabIndex = 1;
            // 
            // productprice_textBox
            // 
            this.productprice_textBox.Location = new System.Drawing.Point(236, 113);
            this.productprice_textBox.Name = "productprice_textBox";
            this.productprice_textBox.Size = new System.Drawing.Size(321, 20);
            this.productprice_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // productdetail_textBox
            // 
            this.productdetail_textBox.Location = new System.Drawing.Point(236, 167);
            this.productdetail_textBox.Name = "productdetail_textBox";
            this.productdetail_textBox.Size = new System.Drawing.Size(321, 20);
            this.productdetail_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Type";
            // 
            // typeproduct_comboBox
            // 
            this.typeproduct_comboBox.FormattingEnabled = true;
            this.typeproduct_comboBox.Location = new System.Drawing.Point(236, 223);
            this.typeproduct_comboBox.Name = "typeproduct_comboBox";
            this.typeproduct_comboBox.Size = new System.Drawing.Size(321, 21);
            this.typeproduct_comboBox.TabIndex = 7;
            this.typeproduct_comboBox.SelectedIndexChanged += new System.EventHandler(this.typeproduct_comboBox_SelectedIndexChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(236, 306);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(141, 52);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(422, 306);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(135, 52);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(190, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.typeproduct_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productdetail_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productprice_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productname_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productname_textBox;
        private System.Windows.Forms.TextBox productprice_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productdetail_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeproduct_comboBox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

