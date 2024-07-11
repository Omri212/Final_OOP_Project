using System.Drawing;
using System.Windows.Forms;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    partial class storeManagment
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
            this.addProduct = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.CheckedListBox();
            this.KindOfFurniture = new System.Windows.Forms.CheckedListBox();
            this.FurnitureStyle = new System.Windows.Forms.CheckedListBox();
            this.color = new System.Windows.Forms.CheckedListBox();
            this.KindOfFurnitureText = new System.Windows.Forms.Label();
            this.FurnitureStyleText = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.Label();
            this.KindOfClothesText = new System.Windows.Forms.Label();
            this.KindOfClothes = new System.Windows.Forms.CheckedListBox();
            this.sizeOfClothesText = new System.Windows.Forms.Label();
            this.sizeOfClothes = new System.Windows.Forms.CheckedListBox();
            this.KindOfElectronicText = new System.Windows.Forms.Label();
            this.KindOfElectronic = new System.Windows.Forms.CheckedListBox();
            this.BrandMenu = new System.Windows.Forms.CheckedListBox();
            this.BrandMenuText = new System.Windows.Forms.Label();
            this.WarrentyTimeText = new System.Windows.Forms.Label();
            this.Warrenty = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.FournitureMaterial = new System.Windows.Forms.CheckedListBox();
            this.FournitureMaterialText = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.amontText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeLable = new System.Windows.Forms.Label();
            this.OSmenu = new System.Windows.Forms.CheckedListBox();
            this.osMenuText = new System.Windows.Forms.Label();
            this.kindOfHouseElectronic = new System.Windows.Forms.Label();
            this.kindOfHouseElectronicMenu = new System.Windows.Forms.CheckedListBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.addProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProduct.Location = new System.Drawing.Point(480, 415);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(153, 35);
            this.addProduct.TabIndex = 29;
            this.addProduct.Text = "add";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.SystemColors.Window;
            this.category.CheckOnClick = true;
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "furniture ",
            "tech Device",
            "clothes",
            "Household Electronic"});
            this.category.Location = new System.Drawing.Point(298, 53);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(131, 64);
            this.category.TabIndex = 1;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // KindOfFurniture
            // 
            this.KindOfFurniture.CheckOnClick = true;
            this.KindOfFurniture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KindOfFurniture.FormattingEnabled = true;
            this.KindOfFurniture.Items.AddRange(new object[] {
            "Chair",
            "Table",
            "Sofa",
            "Bed",
            "Cabinet"});
            this.KindOfFurniture.Location = new System.Drawing.Point(435, 53);
            this.KindOfFurniture.Name = "KindOfFurniture";
            this.KindOfFurniture.Size = new System.Drawing.Size(102, 79);
            this.KindOfFurniture.TabIndex = 2;
            this.KindOfFurniture.Visible = false;
            this.KindOfFurniture.SelectedIndexChanged += new System.EventHandler(this.KindOfFurniture_SelectedIndexChanged);
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.CheckOnClick = true;
            this.FurnitureStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FurnitureStyle.FormattingEnabled = true;
            this.FurnitureStyle.Items.AddRange(new object[] {
            "Modern Style",
            "Farmhouse Style",
            "Industrial Style",
            "Rustic Style",
            "Mid-century Modern Style",
            "Scandinavian"});
            this.FurnitureStyle.Location = new System.Drawing.Point(435, 160);
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.Size = new System.Drawing.Size(103, 94);
            this.FurnitureStyle.TabIndex = 3;
            this.FurnitureStyle.Visible = false;
            this.FurnitureStyle.SelectedIndexChanged += new System.EventHandler(this.FurnitureStyle_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.CheckOnClick = true;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Black",
            "White",
            "Brown",
            "Red",
            "Blue",
            "Green"});
            this.color.Location = new System.Drawing.Point(435, 278);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(129, 94);
            this.color.TabIndex = 4;
            this.color.Visible = false;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // KindOfFurnitureText
            // 
            this.KindOfFurnitureText.AutoSize = true;
            this.KindOfFurnitureText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.KindOfFurnitureText.Location = new System.Drawing.Point(442, 37);
            this.KindOfFurnitureText.Name = "KindOfFurnitureText";
            this.KindOfFurnitureText.Size = new System.Drawing.Size(104, 15);
            this.KindOfFurnitureText.TabIndex = 5;
            this.KindOfFurnitureText.Text = "Kind Of Furniture";
            this.KindOfFurnitureText.Visible = false;
            // 
            // FurnitureStyleText
            // 
            this.FurnitureStyleText.AutoSize = true;
            this.FurnitureStyleText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.FurnitureStyleText.Location = new System.Drawing.Point(442, 145);
            this.FurnitureStyleText.Name = "FurnitureStyleText";
            this.FurnitureStyleText.Size = new System.Drawing.Size(90, 15);
            this.FurnitureStyleText.TabIndex = 6;
            this.FurnitureStyleText.Text = "Furniture Style";
            this.FurnitureStyleText.Visible = false;
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.colorText.Location = new System.Drawing.Point(462, 263);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(35, 15);
            this.colorText.TabIndex = 7;
            this.colorText.Text = "color";
            this.colorText.Visible = false;
            // 
            // KindOfClothesText
            // 
            this.KindOfClothesText.AutoSize = true;
            this.KindOfClothesText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.KindOfClothesText.Location = new System.Drawing.Point(444, 37);
            this.KindOfClothesText.Name = "KindOfClothesText";
            this.KindOfClothesText.Size = new System.Drawing.Size(87, 15);
            this.KindOfClothesText.TabIndex = 9;
            this.KindOfClothesText.Text = "KindOfClothes";
            this.KindOfClothesText.Visible = false;
            // 
            // KindOfClothes
            // 
            this.KindOfClothes.CheckOnClick = true;
            this.KindOfClothes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KindOfClothes.FormattingEnabled = true;
            this.KindOfClothes.Items.AddRange(new object[] {
            "T-Shirt",
            " Polo Shirt",
            "Dress Shirt",
            "Hoodie",
            "Jacket",
            "Pants",
            "Shorts",
            "Skirt",
            "Dress"});
            this.KindOfClothes.Location = new System.Drawing.Point(436, 53);
            this.KindOfClothes.Name = "KindOfClothes";
            this.KindOfClothes.Size = new System.Drawing.Size(102, 79);
            this.KindOfClothes.TabIndex = 8;
            this.KindOfClothes.Visible = false;
            this.KindOfClothes.SelectedIndexChanged += new System.EventHandler(this.KindOfClothes_SelectedIndexChanged);
            // 
            // sizeOfClothesText
            // 
            this.sizeOfClothesText.AutoSize = true;
            this.sizeOfClothesText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.sizeOfClothesText.Location = new System.Drawing.Point(442, 145);
            this.sizeOfClothesText.Name = "sizeOfClothesText";
            this.sizeOfClothesText.Size = new System.Drawing.Size(30, 15);
            this.sizeOfClothesText.TabIndex = 11;
            this.sizeOfClothesText.Text = "Size";
            this.sizeOfClothesText.Visible = false;
            // 
            // sizeOfClothes
            // 
            this.sizeOfClothes.CheckOnClick = true;
            this.sizeOfClothes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeOfClothes.FormattingEnabled = true;
            this.sizeOfClothes.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.sizeOfClothes.Location = new System.Drawing.Point(435, 160);
            this.sizeOfClothes.Name = "sizeOfClothes";
            this.sizeOfClothes.Size = new System.Drawing.Size(103, 94);
            this.sizeOfClothes.TabIndex = 10;
            this.sizeOfClothes.Visible = false;
            this.sizeOfClothes.SelectedIndexChanged += new System.EventHandler(this.sizeOfClothes_SelectedIndexChanged);
            // 
            // KindOfElectronicText
            // 
            this.KindOfElectronicText.AutoSize = true;
            this.KindOfElectronicText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.KindOfElectronicText.Location = new System.Drawing.Point(444, 37);
            this.KindOfElectronicText.Name = "KindOfElectronicText";
            this.KindOfElectronicText.Size = new System.Drawing.Size(107, 15);
            this.KindOfElectronicText.TabIndex = 13;
            this.KindOfElectronicText.Text = "Kind Of Electronic";
            this.KindOfElectronicText.Visible = false;
            // 
            // KindOfElectronic
            // 
            this.KindOfElectronic.CheckOnClick = true;
            this.KindOfElectronic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KindOfElectronic.FormattingEnabled = true;
            this.KindOfElectronic.Items.AddRange(new object[] {
            "Smartphone",
            "Laptop   ",
            "Desktop Computer",
            "Tablet",
            "Smartwatch",
            "TV"});
            this.KindOfElectronic.Location = new System.Drawing.Point(436, 53);
            this.KindOfElectronic.Name = "KindOfElectronic";
            this.KindOfElectronic.Size = new System.Drawing.Size(102, 79);
            this.KindOfElectronic.TabIndex = 12;
            this.KindOfElectronic.Visible = false;
            this.KindOfElectronic.SelectedIndexChanged += new System.EventHandler(this.KindOfElectronic_SelectedIndexChanged);
            // 
            // BrandMenu
            // 
            this.BrandMenu.CheckOnClick = true;
            this.BrandMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrandMenu.FormattingEnabled = true;
            this.BrandMenu.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Microsoft",
            "Dell",
            "HP",
            "Sony   "});
            this.BrandMenu.Location = new System.Drawing.Point(436, 160);
            this.BrandMenu.Name = "BrandMenu";
            this.BrandMenu.Size = new System.Drawing.Size(128, 94);
            this.BrandMenu.TabIndex = 15;
            this.BrandMenu.Visible = false;
            this.BrandMenu.SelectedIndexChanged += new System.EventHandler(this.BrandMenu_SelectedIndexChanged);
            // 
            // BrandMenuText
            // 
            this.BrandMenuText.AutoSize = true;
            this.BrandMenuText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.BrandMenuText.Location = new System.Drawing.Point(444, 145);
            this.BrandMenuText.Name = "BrandMenuText";
            this.BrandMenuText.Size = new System.Drawing.Size(75, 15);
            this.BrandMenuText.TabIndex = 14;
            this.BrandMenuText.Text = "Brand Menu";
            this.BrandMenuText.Visible = false;
            // 
            // WarrentyTimeText
            // 
            this.WarrentyTimeText.AutoSize = true;
            this.WarrentyTimeText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.WarrentyTimeText.Location = new System.Drawing.Point(604, 34);
            this.WarrentyTimeText.Name = "WarrentyTimeText";
            this.WarrentyTimeText.Size = new System.Drawing.Size(60, 15);
            this.WarrentyTimeText.TabIndex = 16;
            this.WarrentyTimeText.Text = "Warrenty";
            this.WarrentyTimeText.Visible = false;
            // 
            // Warrenty
            // 
            this.Warrenty.Location = new System.Drawing.Point(604, 50);
            this.Warrenty.MaxLength = 2;
            this.Warrenty.Name = "Warrenty";
            this.Warrenty.Size = new System.Drawing.Size(60, 20);
            this.Warrenty.TabIndex = 17;
            this.Warrenty.Visible = false;
            this.Warrenty.TextChanged += new System.EventHandler(this.Warrenty_TextChanged);
            // 
            // Price
            // 
            this.Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Price.Location = new System.Drawing.Point(604, 352);
            this.Price.MaxLength = 4;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(60, 20);
            this.Price.TabIndex = 19;
            this.Price.Visible = false;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.PriceText.Location = new System.Drawing.Point(604, 337);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(35, 15);
            this.PriceText.TabIndex = 18;
            this.PriceText.Text = "Price";
            this.PriceText.Visible = false;
            // 
            // FournitureMaterial
            // 
            this.FournitureMaterial.CheckOnClick = true;
            this.FournitureMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FournitureMaterial.FormattingEnabled = true;
            this.FournitureMaterial.Items.AddRange(new object[] {
            "Wood",
            "Stainless Steel",
            "Cane",
            "Plastic",
            "Fabric"});
            this.FournitureMaterial.Location = new System.Drawing.Point(604, 160);
            this.FournitureMaterial.Name = "FournitureMaterial";
            this.FournitureMaterial.Size = new System.Drawing.Size(103, 79);
            this.FournitureMaterial.TabIndex = 21;
            this.FournitureMaterial.Visible = false;
            this.FournitureMaterial.SelectedIndexChanged += new System.EventHandler(this.FournitureMaterial_SelectedIndexChanged);
            // 
            // FournitureMaterialText
            // 
            this.FournitureMaterialText.AutoSize = true;
            this.FournitureMaterialText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.FournitureMaterialText.Location = new System.Drawing.Point(624, 145);
            this.FournitureMaterialText.Name = "FournitureMaterialText";
            this.FournitureMaterialText.Size = new System.Drawing.Size(53, 15);
            this.FournitureMaterialText.TabIndex = 20;
            this.FournitureMaterialText.Text = "Material";
            this.FournitureMaterialText.Visible = false;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(604, 275);
            this.amount.MaxLength = 2;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(60, 20);
            this.amount.TabIndex = 23;
            this.amount.Visible = false;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // amontText
            // 
            this.amontText.AutoSize = true;
            this.amontText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.amontText.Location = new System.Drawing.Point(604, 260);
            this.amontText.Name = "amontText";
            this.amontText.Size = new System.Drawing.Size(43, 15);
            this.amontText.TabIndex = 22;
            this.amontText.Text = "amont";
            this.amontText.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.IF_Creator_Icon_05_03_5121;
            this.pictureBox2.Location = new System.Drawing.Point(6, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 30);
            this.label9.TabIndex = 27;
            this.label9.Text = "system";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "Product Managment ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 543);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // closeLable
            // 
            this.closeLable.AutoSize = true;
            this.closeLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.closeLable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.closeLable.Location = new System.Drawing.Point(696, 1);
            this.closeLable.Name = "closeLable";
            this.closeLable.Size = new System.Drawing.Size(30, 32);
            this.closeLable.TabIndex = 30;
            this.closeLable.Text = "X";
            this.closeLable.Click += new System.EventHandler(this.closeLable_Click);
            // 
            // OSmenu
            // 
            this.OSmenu.CheckOnClick = true;
            this.OSmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OSmenu.FormattingEnabled = true;
            this.OSmenu.Items.AddRange(new object[] {
            "iOS",
            "Android",
            "Windows",
            "macOS",
            "Linux"});
            this.OSmenu.Location = new System.Drawing.Point(604, 160);
            this.OSmenu.Name = "OSmenu";
            this.OSmenu.Size = new System.Drawing.Size(103, 79);
            this.OSmenu.TabIndex = 32;
            this.OSmenu.Visible = false;
            this.OSmenu.SelectedIndexChanged += new System.EventHandler(this.OSmenu_SelectedIndexChanged);
            // 
            // osMenuText
            // 
            this.osMenuText.AutoSize = true;
            this.osMenuText.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.osMenuText.Location = new System.Drawing.Point(612, 145);
            this.osMenuText.Name = "osMenuText";
            this.osMenuText.Size = new System.Drawing.Size(58, 15);
            this.osMenuText.TabIndex = 31;
            this.osMenuText.Text = "OS menu";
            this.osMenuText.Visible = false;
            // 
            // kindOfHouseElectronic
            // 
            this.kindOfHouseElectronic.AutoSize = true;
            this.kindOfHouseElectronic.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.kindOfHouseElectronic.Location = new System.Drawing.Point(443, 37);
            this.kindOfHouseElectronic.Name = "kindOfHouseElectronic";
            this.kindOfHouseElectronic.Size = new System.Drawing.Size(107, 15);
            this.kindOfHouseElectronic.TabIndex = 34;
            this.kindOfHouseElectronic.Text = "Kind Of Electronic";
            this.kindOfHouseElectronic.Visible = false;
            // 
            // kindOfHouseElectronicMenu
            // 
            this.kindOfHouseElectronicMenu.CheckOnClick = true;
            this.kindOfHouseElectronicMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kindOfHouseElectronicMenu.FormattingEnabled = true;
            this.kindOfHouseElectronicMenu.Items.AddRange(new object[] {
            "Oven",
            "Refrigerator",
            "Washing Machine",
            "Dishwasher",
            "Air Conditioner",
            "Water Heater"});
            this.kindOfHouseElectronicMenu.Location = new System.Drawing.Point(435, 53);
            this.kindOfHouseElectronicMenu.Name = "kindOfHouseElectronicMenu";
            this.kindOfHouseElectronicMenu.Size = new System.Drawing.Size(129, 79);
            this.kindOfHouseElectronicMenu.TabIndex = 33;
            this.kindOfHouseElectronicMenu.Visible = false;
            this.kindOfHouseElectronicMenu.SelectedIndexChanged += new System.EventHandler(this.kindOfHouseElectronicMenu_SelectedIndexChanged);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(StoreCreatorAndMenagmentSystem_oop_project.sourceFiles.Store);
            // 
            // storeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(723, 471);
            this.Controls.Add(this.kindOfHouseElectronic);
            this.Controls.Add(this.kindOfHouseElectronicMenu);
            this.Controls.Add(this.OSmenu);
            this.Controls.Add(this.osMenuText);
            this.Controls.Add(this.closeLable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amontText);
            this.Controls.Add(this.FournitureMaterial);
            this.Controls.Add(this.FournitureMaterialText);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.Warrenty);
            this.Controls.Add(this.WarrentyTimeText);
            this.Controls.Add(this.BrandMenu);
            this.Controls.Add(this.BrandMenuText);
            this.Controls.Add(this.KindOfElectronicText);
            this.Controls.Add(this.KindOfElectronic);
            this.Controls.Add(this.sizeOfClothesText);
            this.Controls.Add(this.sizeOfClothes);
            this.Controls.Add(this.KindOfClothesText);
            this.Controls.Add(this.KindOfClothes);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.FurnitureStyleText);
            this.Controls.Add(this.KindOfFurnitureText);
            this.Controls.Add(this.color);
            this.Controls.Add(this.FurnitureStyle);
            this.Controls.Add(this.KindOfFurniture);
            this.Controls.Add(this.category);
            this.Controls.Add(this.addProduct);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "storeManagment";
            this.Text = "storeManagment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addProduct;
        private CheckedListBox category;
        private CheckedListBox KindOfFurniture;
        private CheckedListBox FurnitureStyle;
        private CheckedListBox color;
        private Label KindOfFurnitureText;
        private Label FurnitureStyleText;
        private Label colorText;
        private Label KindOfClothesText;
        private CheckedListBox KindOfClothes;
        private Label sizeOfClothesText;
        private CheckedListBox sizeOfClothes;
        private Label KindOfElectronicText;
        private CheckedListBox KindOfElectronic;
        private CheckedListBox BrandMenu;
        private Label BrandMenuText;
        private Label WarrentyTimeText;
        private TextBox Warrenty;
        private Label PriceText;
        private CheckedListBox FournitureMaterial;
        private Label FournitureMaterialText;
        private TextBox amount;
        private Label amontText;
        private TextBox Price;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label7;
        private PictureBox pictureBox1;
        private Label closeLable;
        private BindingSource storeBindingSource;
        private CheckedListBox OSmenu;
        private Label osMenuText;
        private Label kindOfHouseElectronic;
        private CheckedListBox kindOfHouseElectronicMenu;
    }
}