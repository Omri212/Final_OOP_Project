using System.Drawing;
using System.Windows.Forms;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    partial class Inventory
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
            this.addFurniture = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addproducts = new System.Windows.Forms.Label();
            this.closeLable = new System.Windows.Forms.Label();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addFurniture
            // 
            this.addFurniture.BackgroundImage = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.addProduct;
            this.addFurniture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFurniture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFurniture.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addFurniture.ForeColor = System.Drawing.Color.Transparent;
            this.addFurniture.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addFurniture.Location = new System.Drawing.Point(225, 233);
            this.addFurniture.Name = "addFurniture";
            this.addFurniture.Size = new System.Drawing.Size(66, 47);
            this.addFurniture.TabIndex = 1;
            this.addFurniture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addFurniture.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addFurniture.UseVisualStyleBackColor = true;
            this.addFurniture.Click += new System.EventHandler(this.addFurniture_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(513, 186);
            this.dataGridView1.TabIndex = 2;
            // 
            // Addproducts
            // 
            this.Addproducts.AutoSize = true;
            this.Addproducts.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Addproducts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Addproducts.Location = new System.Drawing.Point(225, 218);
            this.Addproducts.Name = "Addproducts";
            this.Addproducts.Size = new System.Drawing.Size(81, 15);
            this.Addproducts.TabIndex = 3;
            this.Addproducts.Text = "Add products";
            // 
            // closeLable
            // 
            this.closeLable.AutoSize = true;
            this.closeLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.closeLable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.closeLable.Location = new System.Drawing.Point(529, -7);
            this.closeLable.Name = "closeLable";
            this.closeLable.Size = new System.Drawing.Size(30, 32);
            this.closeLable.TabIndex = 28;
            this.closeLable.Text = "X";
            this.closeLable.Click += new System.EventHandler(this.closeLable_Click);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(StoreCreatorAndMenagmentSystem_oop_project.sourceFiles.Store);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 290);
            this.Controls.Add(this.closeLable);
            this.Controls.Add(this.Addproducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addFurniture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addFurniture;
        private BindingSource storeBindingSource;
        private DataGridView dataGridView1;
        private Label Addproducts;
        private Label closeLable;
    }
}