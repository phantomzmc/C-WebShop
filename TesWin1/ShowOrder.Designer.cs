﻿namespace TesWin1
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
            this.label1 = new System.Windows.Forms.Label();
            this.del_proid_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edit_order_textBox = new System.Windows.Forms.TextBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // order_dataGridView
            // 
            this.order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dataGridView.Location = new System.Drawing.Point(12, 87);
            this.order_dataGridView.Name = "order_dataGridView";
            this.order_dataGridView.Size = new System.Drawing.Size(776, 328);
            this.order_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า";
            // 
            // del_proid_textBox
            // 
            this.del_proid_textBox.Location = new System.Drawing.Point(508, 39);
            this.del_proid_textBox.Name = "del_proid_textBox";
            this.del_proid_textBox.Size = new System.Drawing.Size(170, 20);
            this.del_proid_textBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ลบ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_order_textBox
            // 
            this.edit_order_textBox.Location = new System.Drawing.Point(94, 39);
            this.edit_order_textBox.Name = "edit_order_textBox";
            this.edit_order_textBox.Size = new System.Drawing.Size(196, 20);
            this.edit_order_textBox.TabIndex = 4;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(311, 37);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 5;
            this.edit_button.Text = "เเก้ไข";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "รหัสสินค้า";
            // 
            // ShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.edit_order_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.del_proid_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_dataGridView);
            this.Name = "ShowOrder";
            this.Text = "ShowOrder";
            this.Load += new System.EventHandler(this.ShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView order_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox del_proid_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edit_order_textBox;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label2;
    }
}