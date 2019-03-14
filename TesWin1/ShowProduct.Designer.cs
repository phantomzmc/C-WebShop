namespace TesWin1
{
    partial class ShowProduct
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
            this.shopCafeDataSet = new TesWin1.ShopCafeDataSet();
            this.shopCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del_proid_textBox = new System.Windows.Forms.TextBox();
            this.del_proid_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_proid_button = new System.Windows.Forms.Button();
            this.edit_proid_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shopCafeDataSet
            // 
            this.shopCafeDataSet.DataSetName = "ShopCafeDataSet";
            this.shopCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopCafeDataSetBindingSource
            // 
            this.shopCafeDataSetBindingSource.DataSource = this.shopCafeDataSet;
            this.shopCafeDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // del_proid_textBox
            // 
            this.del_proid_textBox.Location = new System.Drawing.Point(477, 41);
            this.del_proid_textBox.Name = "del_proid_textBox";
            this.del_proid_textBox.Size = new System.Drawing.Size(184, 20);
            this.del_proid_textBox.TabIndex = 1;
            // 
            // del_proid_button
            // 
            this.del_proid_button.Location = new System.Drawing.Point(682, 39);
            this.del_proid_button.Name = "del_proid_button";
            this.del_proid_button.Size = new System.Drawing.Size(75, 23);
            this.del_proid_button.TabIndex = 2;
            this.del_proid_button.Text = "ลบ";
            this.del_proid_button.UseVisualStyleBackColor = true;
            this.del_proid_button.Click += new System.EventHandler(this.del_proid_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "รหัสสินค้า";
            // 
            // edit_proid_button
            // 
            this.edit_proid_button.Location = new System.Drawing.Point(301, 39);
            this.edit_proid_button.Name = "edit_proid_button";
            this.edit_proid_button.Size = new System.Drawing.Size(75, 23);
            this.edit_proid_button.TabIndex = 5;
            this.edit_proid_button.Text = "แก้ไข";
            this.edit_proid_button.UseVisualStyleBackColor = true;
            this.edit_proid_button.Click += new System.EventHandler(this.edit_proid_button_Click);
            // 
            // edit_proid_textBox
            // 
            this.edit_proid_textBox.Location = new System.Drawing.Point(96, 41);
            this.edit_proid_textBox.Name = "edit_proid_textBox";
            this.edit_proid_textBox.Size = new System.Drawing.Size(184, 20);
            this.edit_proid_textBox.TabIndex = 4;
            // 
            // ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_proid_button);
            this.Controls.Add(this.edit_proid_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_proid_button);
            this.Controls.Add(this.del_proid_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowProduct";
            this.Text = "ShowProduct";
            this.Load += new System.EventHandler(this.ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource shopCafeDataSetBindingSource;
        private ShopCafeDataSet shopCafeDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox del_proid_textBox;
        private System.Windows.Forms.Button del_proid_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_proid_button;
        private System.Windows.Forms.TextBox edit_proid_textBox;
    }
}