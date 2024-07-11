using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    partial class storeMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storeMainScreen));
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.storeNameLable = new System.Windows.Forms.Label();
            this.shoppingCartDatagrid = new System.Windows.Forms.DataGridView();
            this.closeLable = new System.Windows.Forms.Label();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.EnableImgMove = new System.Windows.Forms.CheckBox();
            this.loadList = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.getInfoPic = new System.Windows.Forms.PictureBox();
            this.HouseholdElectronicImg = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clothesImage = new System.Windows.Forms.PictureBox();
            this.electronicImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseholdElectronicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(716, 263);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.ReadOnly = true;
            this.payTextBox.Size = new System.Drawing.Size(104, 20);
            this.payTextBox.TabIndex = 1;
            // 
            // pay
            // 
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.pay.Location = new System.Drawing.Point(708, 309);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(115, 29);
            this.pay.TabIndex = 3;
            this.pay.Text = "pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.total.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.total.Location = new System.Drawing.Point(662, 263);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(48, 21);
            this.total.TabIndex = 4;
            this.total.Text = "Total";
            // 
            // storeNameLable
            // 
            this.storeNameLable.AutoSize = true;
            this.storeNameLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.storeNameLable.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.storeNameLable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storeNameLable.Location = new System.Drawing.Point(177, 25);
            this.storeNameLable.Name = "storeNameLable";
            this.storeNameLable.Size = new System.Drawing.Size(166, 65);
            this.storeNameLable.TabIndex = 11;
            this.storeNameLable.Text = "label1";
            // 
            // shoppingCartDatagrid
            // 
            this.shoppingCartDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shoppingCartDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shoppingCartDatagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.shoppingCartDatagrid.Location = new System.Drawing.Point(588, 30);
            this.shoppingCartDatagrid.MultiSelect = false;
            this.shoppingCartDatagrid.Name = "shoppingCartDatagrid";
            this.shoppingCartDatagrid.ReadOnly = true;
            this.shoppingCartDatagrid.RowHeadersWidth = 62;
            this.shoppingCartDatagrid.RowTemplate.Height = 25;
            this.shoppingCartDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shoppingCartDatagrid.Size = new System.Drawing.Size(232, 227);
            this.shoppingCartDatagrid.TabIndex = 2;
            // 
            // closeLable
            // 
            this.closeLable.AutoSize = true;
            this.closeLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.closeLable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.closeLable.Location = new System.Drawing.Point(802, -5);
            this.closeLable.Name = "closeLable";
            this.closeLable.Size = new System.Drawing.Size(30, 32);
            this.closeLable.TabIndex = 17;
            this.closeLable.Text = "X";
            this.closeLable.Click += new System.EventHandler(this.closeLable_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.RemoveItem.Location = new System.Drawing.Point(588, 263);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(68, 24);
            this.RemoveItem.TabIndex = 19;
            this.RemoveItem.Text = "Remove";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // EnableImgMove
            // 
            this.EnableImgMove.AutoSize = true;
            this.EnableImgMove.Location = new System.Drawing.Point(716, 464);
            this.EnableImgMove.Name = "EnableImgMove";
            this.EnableImgMove.Size = new System.Drawing.Size(109, 17);
            this.EnableImgMove.TabIndex = 22;
            this.EnableImgMove.Text = "Enable Img Move";
            this.EnableImgMove.UseVisualStyleBackColor = true;
            this.EnableImgMove.CheckedChanged += new System.EventHandler(this.EnableImgMove_CheckedChanged);
            // 
            // loadList
            // 
            this.loadList.Location = new System.Drawing.Point(609, 480);
            this.loadList.Name = "loadList";
            this.loadList.Size = new System.Drawing.Size(75, 23);
            this.loadList.TabIndex = 23;
            this.loadList.Text = "load List";
            this.loadList.UseVisualStyleBackColor = true;
            this.loadList.Click += new System.EventHandler(this.loadList_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(509, 480);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 24;
            this.save.Text = "save List";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // getInfoPic
            // 
            this.getInfoPic.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.getInfo;
            this.getInfoPic.Location = new System.Drawing.Point(636, 309);
            this.getInfoPic.Name = "getInfoPic";
            this.getInfoPic.Size = new System.Drawing.Size(29, 29);
            this.getInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.getInfoPic.TabIndex = 25;
            this.getInfoPic.TabStop = false;
            this.getInfoPic.Click += new System.EventHandler(this.getInfoPic_Click);
            // 
            // HouseholdElectronicImg
            // 
            this.HouseholdElectronicImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HouseholdElectronicImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HouseholdElectronicImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HouseholdElectronicImg.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.appliances;
            this.HouseholdElectronicImg.Location = new System.Drawing.Point(12, 277);
            this.HouseholdElectronicImg.Name = "HouseholdElectronicImg";
            this.HouseholdElectronicImg.Size = new System.Drawing.Size(122, 92);
            this.HouseholdElectronicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HouseholdElectronicImg.TabIndex = 20;
            this.HouseholdElectronicImg.TabStop = false;
            this.HouseholdElectronicImg.Click += new System.EventHandler(this.HouseholdElectronicImg_Click);
            this.HouseholdElectronicImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HouseholdElectronicImg_MouseDown);
            this.HouseholdElectronicImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HouseholdElectronicImg_MouseMove);
            this.HouseholdElectronicImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HouseholdElectronicImg_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.addProduct;
            this.pictureBox3.Location = new System.Drawing.Point(588, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.manager2;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 438);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ManagerLoginForm_Load);
            // 
            // clothesImage
            // 
            this.clothesImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clothesImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clothesImage.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.clothes;
            this.clothesImage.Location = new System.Drawing.Point(221, 137);
            this.clothesImage.Name = "clothesImage";
            this.clothesImage.Size = new System.Drawing.Size(122, 92);
            this.clothesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clothesImage.TabIndex = 8;
            this.clothesImage.TabStop = false;
            this.clothesImage.Click += new System.EventHandler(this.InventoryForm_Load);
            this.clothesImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clothesImage_MouseDown);
            this.clothesImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clothesImage_MouseMove);
            this.clothesImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clothesImage_MouseUp);
            // 
            // electronicImage
            // 
            this.electronicImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.electronicImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.electronicImage.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.electronic;
            this.electronicImage.Location = new System.Drawing.Point(12, 137);
            this.electronicImage.Name = "electronicImage";
            this.electronicImage.Size = new System.Drawing.Size(122, 92);
            this.electronicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.electronicImage.TabIndex = 6;
            this.electronicImage.TabStop = false;
            this.electronicImage.Click += new System.EventHandler(this.electronicImage_MouseClick);
            this.electronicImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.electronicImage_MouseDown);
            this.electronicImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.electronicImage_MouseMove);
            this.electronicImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.electronicImage_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.furniture;
            this.pictureBox1.Location = new System.Drawing.Point(447, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox4.Location = new System.Drawing.Point(-5, 438);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(875, 78);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // storeMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.ControlBox = false;
            this.Controls.Add(this.getInfoPic);
            this.Controls.Add(this.save);
            this.Controls.Add(this.loadList);
            this.Controls.Add(this.EnableImgMove);
            this.Controls.Add(this.HouseholdElectronicImg);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.closeLable);
            this.Controls.Add(this.shoppingCartDatagrid);
            this.Controls.Add(this.storeNameLable);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.clothesImage);
            this.Controls.Add(this.electronicImage);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.payTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "storeMainScreen";
            this.Opacity = 0.99D;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseholdElectronicImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox payTextBox;
        private Button pay;
        private PictureBox pictureBox1;
        private PictureBox electronicImage;
        private PictureBox clothesImage;
        private PictureBox pictureBox2;
        private Label total;
        private PictureBox pictureBox3;
        private Label storeNameLable;
        private DataGridView shoppingCartDatagrid;
        private Label closeLable;
        private PictureBox pictureBox4;
        private Button RemoveItem;
        private PictureBox HouseholdElectronicImg;
        private CheckBox EnableImgMove;
        private Button loadList;
        private Button save;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private PictureBox getInfoPic;
    }
}