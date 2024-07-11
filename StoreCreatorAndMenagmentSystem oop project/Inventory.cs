using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class Inventory : Form
    {
        private Store _mystore;
        private buyer _buyer;
        private storeMainScreen _mainScreen;
        private double _sum;
        private List<product> filterdList;
        productType _type;
        public Inventory(Store mystore, productType type, buyer buyer, storeMainScreen mainScreen, double sum)
        {
            InitializeComponent();
            SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
            charge.Play();
            _mystore = mystore;
            _buyer = buyer;
            _mainScreen = mainScreen;
            _sum = sum;
            _type = type;


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSize = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].DataPropertyName = "sn";

            dataGridView1.Columns.Add("description", "description");
            dataGridView1.Columns["description"].DataPropertyName = "description";
            dataGridView1.DataSource = _mystore.storeProductList;

            dataGridView1.Columns.Add("amount", "amount");
            dataGridView1.Columns["amount"].DataPropertyName = "amount";

            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns["price"].DataPropertyName = "price";

            updatefilterdList();

        }


        private void addFurniture_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedCells.Count > 0)
            {
                SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
                charge.Play();

                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                product k = _mystore.storeProductList.Find(p => p.sn == selectedId);
                if (_buyer.ShoppingCart.Find(p => p.sn == k.sn) != null)
                {   _buyer.ShoppingCart.Find(p => p.sn == k.sn).amount++;
                    _sum += k.Price;
                }
                else
                {
                    product c=(product)k.Clone();

                    c.amount = 1;
                    _buyer.AddToCart(c);
                    _sum += c.Price;
                }
                if (k.amount == 1)
                {
                    _mystore.storeProductList.Remove(k);       
                }
                else
                {
                    _mystore.storeProductList.Find(p => p.sn == k.sn).amount--;  
                }
                updatefilterdList();

                _mainScreen.UpdateShoppingCart(_sum);
            }

        }
        void updatefilterdList()
        {
            dataGridView1.DataSource = null;
            if (_mystore.storeProductList != null)
            {
                filterdList = _mystore.storeProductList.Where(item => item.ProductType == _type).ToList();
                dataGridView1.DataSource = filterdList;
            }
        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
