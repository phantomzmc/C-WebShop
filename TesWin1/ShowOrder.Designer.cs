namespace TesWin1
{
    partial class ShowOrder
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
            this.order_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // order_dataGridView
            // 
            this.order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.order_dataGridView.Name = "order_dataGridView";
            this.order_dataGridView.Size = new System.Drawing.Size(776, 328);
            this.order_dataGridView.TabIndex = 0;
            // 
            // ShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order_dataGridView);
            this.Name = "ShowOrder";
            this.Text = "ShowOrder";
            this.Load += new System.EventHandler(this.ShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView order_dataGridView;
    }
}