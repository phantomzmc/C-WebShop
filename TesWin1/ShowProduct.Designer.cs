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
            this.dataGridView1.Location = new System.Drawing.Point(158, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowProduct";
            this.Text = "ShowProduct";
            this.Load += new System.EventHandler(this.ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource shopCafeDataSetBindingSource;
        private ShopCafeDataSet shopCafeDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}