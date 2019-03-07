namespace TesWin1
{
    partial class ShowUser
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
            this.user_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // user_dataGridView
            // 
            this.user_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView.Location = new System.Drawing.Point(12, 25);
            this.user_dataGridView.Name = "user_dataGridView";
            this.user_dataGridView.Size = new System.Drawing.Size(776, 338);
            this.user_dataGridView.TabIndex = 0;
            // 
            // ShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_dataGridView);
            this.Name = "ShowUser";
            this.Text = "ShowUser";
            this.Load += new System.EventHandler(this.ShowUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView user_dataGridView;
    }
}