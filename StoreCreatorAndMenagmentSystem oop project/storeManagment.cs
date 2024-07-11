using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;


namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class storeManagment : Form
    {
        productType type;
        private Store _mystore;
        int[] a = new int[10];

        public storeManagment(Store mystore)
        {
            InitializeComponent();
            _mystore = mystore;
        }



        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            type =(productType)category.SelectedIndex;

            if (type == productType.efurniture)
            {
                amontText.Visible = true;
                amount.Visible = true;
                FournitureMaterial.Visible = true;
                FournitureMaterialText.Visible = true;
                FurnitureStyleText.Visible = true;
                KindOfFurnitureText.Visible = true;
                FurnitureStyle.Visible = true;
                KindOfFurniture.Visible = true;
                Price.Visible = true;
                colorText.Visible = true;
                color.Visible = true;
                PriceText.Visible = true;
            }
            if (type != productType.efurniture)
            {
                FurnitureStyleText.Visible = false;
                KindOfFurnitureText.Visible = false;
                FurnitureStyle.Visible = false;
                KindOfFurniture.Visible = false;
                FournitureMaterial.Visible = false;
                FournitureMaterialText.Visible = false;

            }
            if (type == productType.etechDevice)
            {
                OSmenu.Visible = true;
                osMenuText.Visible = true;
                amontText.Visible = true;
                amount.Visible = true;
                KindOfElectronicText.Visible = true;
                KindOfElectronic.Visible = true;
                WarrentyTimeText.Visible = true;
                Warrenty.Visible = true;
                BrandMenu.Visible = true;
                BrandMenuText.Visible = true;
                Price.Visible = true;
                colorText.Visible = true;
                color.Visible = true;
                PriceText.Visible = true;
            }
            if (type != productType.etechDevice)
            {
                OSmenu.Visible = false;
                osMenuText.Visible = false;
                KindOfElectronicText.Visible = false;
                KindOfElectronic.Visible = false;


            }
            if(type != productType.etechDevice && type != productType.eHouseholdElectronic)
            {
                BrandMenu.Visible = false;
                BrandMenuText.Visible = false;
                WarrentyTimeText.Visible = false;
                Warrenty.Visible = false;
            }
            if (type == productType.eClothing)
            {
                amontText.Visible = true;
                amount.Visible = true;
                KindOfClothes.Visible = true;
                KindOfClothesText.Visible = true;
                sizeOfClothes.Visible = true;
                sizeOfClothesText.Visible = true;
                Price.Visible = true;
                colorText.Visible = true;
                color.Visible = true;
                PriceText.Visible = true;
            }
            if (type != productType.eClothing)
            {
                KindOfClothes.Visible = false;
                KindOfClothesText.Visible = false;
                sizeOfClothes.Visible = false;
                sizeOfClothesText.Visible = false;
            }
            if (type == productType.eHouseholdElectronic)
            {
                amontText.Visible = true;
                amount.Visible = true;
                KindOfElectronicText.Visible = true;
                kindOfHouseElectronicMenu.Visible = true;
                WarrentyTimeText.Visible = true;
                Warrenty.Visible = true;
                BrandMenu.Visible = true;
                BrandMenuText.Visible = true;
                Price.Visible = true;
                colorText.Visible = true;
                color.Visible = true;
                PriceText.Visible = true;
            }
            if (type != productType.eHouseholdElectronic)
            {
                KindOfElectronicText.Visible = false;
                kindOfHouseElectronicMenu.Visible = false;
                WarrentyTimeText.Visible = false;
                Warrenty.Visible = false;
            }

            int index = category.SelectedIndex;
            int count = category.Items.Count;
            clearCheck(category);
        }
        void clearCheck(CheckedListBox _checkBox)
        {
            int index = _checkBox.SelectedIndex;
            int count = _checkBox.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    _checkBox.SetItemChecked(i, false);
                }

            }
        }

        private void FurnitureStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(FurnitureStyle);
            a[1] = FurnitureStyle.SelectedIndex;
        }

        private void KindOfElectronic_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(KindOfElectronic);
            a[0] = KindOfElectronic.SelectedIndex;
        }

        private void KindOfFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(KindOfFurniture);
            a[0] = KindOfFurniture.SelectedIndex;
        }

        private void KindOfClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(KindOfClothes);
            a[0] = KindOfClothes.SelectedIndex;
        }

        private void BrandMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(BrandMenu);
            a[1] = BrandMenu.SelectedIndex;

        }

        private void sizeOfClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(sizeOfClothes);
            a[1] = sizeOfClothes.SelectedIndex;

        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(color);
            a[2] = color.SelectedIndex;
        }

        private void OSmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(OSmenu);
            a[6]= OSmenu.SelectedIndex;
        }

        private void kindOfHouseElectronicMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(kindOfHouseElectronicMenu);
            a[0]= kindOfHouseElectronicMenu.SelectedIndex;


        }

        private void Warrenty_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in Warrenty.Text)
            {
                if (item > '9')
                {
                    Warrenty.Text = "0";
                }
            }
            a[3] = Convert.ToInt32(Warrenty.Text);
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in Price.Text)
            {
                if (item > '9')
                {
                    Price.Text = "0";
                }
            }
            if(Price.Text!="")
                a[4] = Convert.ToInt32(Price.Text);
        }

        private void FournitureMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCheck(FournitureMaterial);
            a[3] = FournitureMaterial.SelectedIndex;
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (amount.Text.Length > 0)
            {
                foreach (var item in amount.Text)
                {
                    if (item > '9')
                    {
                        amount.Text = "0";
                    }
                }
                if (amontText.Text!="")
                    a[5] = Convert.ToInt32(amount.Text);
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            int flag = 1;
            if ((productType)category.SelectedIndex ==productType.efurniture && (KindOfFurniture.SelectedIndex == -1 || FournitureMaterial.SelectedIndex == -1 || FurnitureStyle.SelectedIndex == -1 || color.SelectedIndex == -1))
            {

                MessageBox.Show("must choose all options before adding");

                flag = 0;
            }
            else if ((productType)category.SelectedIndex == productType.etechDevice && (KindOfElectronic.SelectedIndex == -1 || BrandMenu.SelectedIndex == -1 || color.SelectedIndex == -1 || OSmenu.SelectedIndex == -1))
            {
                flag = 0;
                MessageBox.Show("must choose all options before adding");

            }
            else if ((productType)category.SelectedIndex == productType.eClothing && (KindOfClothes.SelectedIndex == -1 || sizeOfClothes.SelectedIndex == -1 || color.SelectedIndex == -1))
            {
                flag = 0;
                MessageBox.Show("must choose all options before adding");
            }
            else if ((productType)category.SelectedIndex == productType.eHouseholdElectronic && (kindOfHouseElectronicMenu.SelectedIndex == -1 || BrandMenu.SelectedIndex == -1 || color.SelectedIndex == -1 ))
            {
                flag = 0;
                MessageBox.Show("must choose all options before adding");

            }

            else if (Price.Text == "" || Price.Text == "0" || Convert.ToInt32(Price.Text) > 9999)
            {
                flag = 0;
                MessageBox.Show("Price value is invalid");

            }
            else if (amount.Text == "" || amount.Text == "0" || Convert.ToInt32(amount.Text) > 99)
            {
                flag = 0;
                MessageBox.Show("amount vailue is invalid");

            }
            else if (flag == 1)
            {
                _mystore.addProduct((productType)category.SelectedIndex, a);
                amount.Text = "0";
                if (KindOfClothes.SelectedIndex != -1)
                    KindOfClothes.SetItemChecked(KindOfClothes.SelectedIndex, false);
                KindOfClothes.ClearSelected();
                if (KindOfElectronic.SelectedIndex != -1)
                    KindOfElectronic.SetItemChecked(KindOfElectronic.SelectedIndex, false);
                KindOfElectronic.ClearSelected();
                if (KindOfFurniture.SelectedIndex != -1)
                    KindOfFurniture.SetItemChecked(KindOfFurniture.SelectedIndex, false);
                KindOfFurniture.ClearSelected();

                if (kindOfHouseElectronicMenu.SelectedIndex != -1)
                    kindOfHouseElectronicMenu.SetItemChecked(kindOfHouseElectronicMenu.SelectedIndex, false);
                kindOfHouseElectronicMenu.ClearSelected();

                if (OSmenu.SelectedIndex != -1)
                    OSmenu.SetItemChecked(OSmenu.SelectedIndex, false);
                OSmenu.ClearSelected();

                if (BrandMenu.SelectedIndex != -1)
                    BrandMenu.SetItemChecked(BrandMenu.SelectedIndex, false);
                BrandMenu.ClearSelected();

                if (color.SelectedIndex != -1)
                    color.SetItemChecked(color.SelectedIndex, false);
                color.ClearSelected();
                Warrenty.Text = "0";

                if (sizeOfClothes.SelectedIndex != -1)
                    sizeOfClothes.SetItemChecked(sizeOfClothes.SelectedIndex, false);
                sizeOfClothes.ClearSelected();

                if (FurnitureStyle.SelectedIndex != -1)
                    FurnitureStyle.SetItemChecked(FurnitureStyle.SelectedIndex, false);
                FurnitureStyle.ClearSelected();
                Price.Text = "0";

                if (FournitureMaterial.SelectedIndex != -1)
                    FournitureMaterial.SetItemChecked(FournitureMaterial.SelectedIndex, false);
                FournitureMaterial.ClearSelected();

            }

        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
// a[0]=kind of electronic/clothes/furniture
// a[1]=brand of electronic/size of clothes/furniture style
// a[2]=color
// a[3]=electronic warrenty
// a[4]=price
// a[5]=amount
//a[6]os
