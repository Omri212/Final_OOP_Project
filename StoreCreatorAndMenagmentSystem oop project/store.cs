using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class storeMainScreen : Form
    {
        public Form _currentForm = null;
        private Store _mystore;
        private productType _type;
        private buyer _buyer = new buyer();
        private double sum;
        private new_store _thisStore;
        private ThankYouForm thankYouForm;
        private Point mouseOffset;
        private bool isMouseDown;
        int moveFlage;
        List<JObject> _temp;
        public storeMainScreen(Store mystore, new_store thisStore)
        {

            InitializeComponent();
            string filePath = $"{mystore.storeName}_list.json";
            deserializeD(mystore, filePath);

            _mystore = mystore;
              storeNameLable.Text = _mystore.storeName;
              _thisStore = thisStore;
              sum = 0;
            moveFlage = 0;

            //set up the "shopping cart" window in the main shop screan
            shoppingCartDatagrid.AutoGenerateColumns = false;
            shoppingCartDatagrid.ReadOnly = true;
            shoppingCartDatagrid.AllowUserToAddRows = false;
            shoppingCartDatagrid.AutoSize = false;
            shoppingCartDatagrid.RowHeadersVisible = false;

            shoppingCartDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shoppingCartDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            shoppingCartDatagrid.Columns.Add("description", "description");
            shoppingCartDatagrid.Columns["description"].DataPropertyName = "description";


            shoppingCartDatagrid.Columns.Add("amount", "amount");
            shoppingCartDatagrid.Columns["amount"].DataPropertyName = "amount";


            shoppingCartDatagrid.Columns.Add("sn", "sn");
            shoppingCartDatagrid.Columns["sn"].DataPropertyName = "sn";

            shoppingCartDatagrid.Columns[0].Width = 55;
            shoppingCartDatagrid.Columns[1].Width = 18;
            shoppingCartDatagrid.Columns[2].Visible = false;
        }

        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {

            if (_currentForm != null)
                _currentForm.Close();
            _currentForm = new managerLogin(_mystore);
            _currentForm.Show();

        }

        public void UpdateShoppingCart(double _sum)
        {

            shoppingCartDatagrid.DataSource = null;
            shoppingCartDatagrid.DataSource = _buyer.ShoppingCart;
            payTextBox.Text = _sum.ToString();
            sum = _sum;

        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (payTextBox.Text != "" && payTextBox.Text != "0")
            {
                _buyer.ShoppingCart.Clear();
                UpdateShoppingCart(0);
                SoundPlayer charge = new SoundPlayer(@"soundSource\cash.wav");
                charge.Play();
                if (thankYouForm != null)
                {
                    thankYouForm.Close();
                }
                thankYouForm = new ThankYouForm(_mystore);
                thankYouForm.Show();
            }
            else
            {
                MessageBox.Show("Shoping cart is empty");

            }

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
           
            if (moveFlage == 0)
            {
                _type = productType.eClothing;
                if (_currentForm != null)
                    _currentForm.Close();

                _currentForm = new Inventory(_mystore, _type, _buyer, this, sum);
                _currentForm.Show();
            }
        }
        private void pictureBox1_MouseClick(object sender, EventArgs e)
        {
          
            if (moveFlage == 0)
            {

                _type = productType.efurniture;
                if (_currentForm != null)
                    _currentForm.Close();

                _currentForm = new Inventory(_mystore, _type, _buyer, this, sum);
                _currentForm.Show();
            }
        }

        private void electronicImage_MouseClick(object sender, EventArgs e)
        {
            if (moveFlage==0)
            {
                _type = productType.etechDevice;
                if (_currentForm != null)
                    _currentForm.Close();

                _currentForm = new Inventory(_mystore, _type, _buyer, this, sum);
                _currentForm.Show();
            }
        }

        private void HouseholdElectronicImg_Click(object sender, EventArgs e)
        {
           
            if (moveFlage == 0)
            {
                _type = productType.eHouseholdElectronic;
                if (_currentForm != null)
                    _currentForm.Close();

                _currentForm = new Inventory(_mystore, _type, _buyer,  this, sum);
                _currentForm.Show();
            }
        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            
            SoundPlayer charge = new SoundPlayer(@"soundSource\exit.wav");
            charge.Play();
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            string listJason = JsonConvert.SerializeObject(_mystore.storeProductList);
            string filePath = $"{_mystore.storeName}_list.json";
            File.WriteAllText(filePath, listJason);

            _thisStore.Close();//close the main program
        }
        private void getInfoPic_Click(object sender, EventArgs e)
        {
            SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
            charge.Play();
            if (shoppingCartDatagrid.Rows.Count > 0)
            {
                int selectedId = Convert.ToInt32(shoppingCartDatagrid.SelectedRows[0].Cells["sn"].Value);
                product k = _buyer.ShoppingCart.Find(p => p.sn == selectedId);
                if (k != null)
                {
                    MessageBox.Show(k.getInfo());
                }
            }
            else
            {
                MessageBox.Show("Shoping cart is empty");

            }
        }
        private void RemoveItem_Click(object sender, EventArgs e)// need to return the removed item to the invantory
        {
            SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
            charge.Play();
            if (shoppingCartDatagrid.Rows.Count > 0)
            {

                int selectedId = Convert.ToInt32(shoppingCartDatagrid.SelectedRows[0].Cells["sn"].Value);
                product k = _buyer.ShoppingCart.Find(p => p.sn == selectedId);
                if (k != null)
                {
                    if (k.amount == 1)
                    {
                        sum -= k.price;
                        payTextBox.Text = sum.ToString();
                        _buyer.RemoveFromCart(k);
                    }
                    else
                    {
                        sum -= k.price;
                        payTextBox.Text = sum.ToString();
                        _buyer.ShoppingCart.Find(p => p.sn == k.sn).amount--;
                     

                    }
                    if (_mystore.storeProductList.Find(p => p.sn == selectedId) != null)
                    {
                        _mystore.storeProductList.Find(p => p.sn == selectedId).amount++;

                    }
                    else
                    {
                        product x=(product)k.Clone();
                        x.amount = 1;
                        _mystore.storeProductList.Add(x);
                    }

                    shoppingCartDatagrid.DataSource = null;
                    shoppingCartDatagrid.DataSource = _buyer.ShoppingCart;

                }
            }
            else
            {
                MessageBox.Show("Shoping cart is empty");

            }
        }
        
        private void electronicImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveFlage ==1)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void electronicImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                if (isMouseDown)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                    electronicImage.Location = electronicImage.Parent.PointToClient(mousePos);
                }
            }
        }

        private void electronicImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                isMouseDown = false;
            }
        }

        private void clothesImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                if (isMouseDown)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                    clothesImage.Location = clothesImage.Parent.PointToClient(mousePos);
                }
            }
        }

        private void clothesImage_MouseUp(object sender, MouseEventArgs e)
        {

            if (moveFlage == 1)
            {
                isMouseDown = false;
            }
        }

        private void clothesImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1) {
            isMouseDown = true;
            mouseOffset = new Point(-e.X, -e.Y);
        }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        if (moveFlage == 1)
        {
            isMouseDown = false;
        }

        }

        private void HouseholdElectronicImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void HouseholdElectronicImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                if (isMouseDown)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                    pictureBox1.Location = pictureBox1.Parent.PointToClient(mousePos);
                }
            }
        }

        private void HouseholdElectronicImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveFlage == 1)
            {
                if (isMouseDown)
                {
                    Point mousePos = Control.MousePosition;

                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                    HouseholdElectronicImg.Location = HouseholdElectronicImg.Parent.PointToClient(mousePos);
                }
            }
        }

        private void EnableImgMove_CheckedChanged(object sender, EventArgs e)
        {
            if (moveFlage == 1)
                moveFlage = 0;
            else
                moveFlage = 1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1=new SaveFileDialog();
            saveFileDialog1.FileName = $"{_mystore.storeName}_list.json";
            saveFileDialog1.ShowDialog(this);
            string listJason = JsonConvert.SerializeObject(_mystore.storeProductList);
            string path = saveFileDialog1.FileName;

            if (path != "")
            {
            File.WriteAllText(path, listJason);
            }
        }

        private void loadList_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.ShowDialog(this);
            string path = openFileDialog1.FileName;
            if (path != "")
            { 
                _mystore.storeProductList.Clear();
               
                deserializeD(_mystore, path);
            }   
        }
        private void deserializeD(Store mystore, string filePath)
        {
            
            if (File.Exists(filePath))
            {
                string storeListJson = File.ReadAllText(filePath);
                if (storeListJson != null)
                {
                    _temp = new List<JObject>();
                    _temp = JsonConvert.DeserializeObject<List<JObject>>(storeListJson);
                    foreach (JObject p in _temp)
                    {
                        switch ((productType)p.Value<int>("ProductType"))
                        {
                            case productType.efurniture:
                                Furniture furniture = new Furniture(0, 0, 0, 0, 0, 0);
                                furniture.amount = p.Value<int>("amount");
                                furniture.sn = p.Value<int>("sn");
                                furniture.price = p.Value<int>("price"); ;
                                furniture.type = p.Value<string>("type"); ;
                                furniture.color = p.Value<string>("color");
                                furniture.Style = p.Value<string>("Style"); ;
                                furniture.Material = p.Value<string>("Material");
                                furniture.description = p.Value<string>("description");
                                mystore.storeProductList.Add(furniture);

                                break;
                            case productType.etechDevice:
                                techDevice techDevice = new techDevice(0, 0, 0, 0, 0, 0, 0);
                                techDevice.amount = p.Value<int>("amount");
                                techDevice.price = p.Value<int>("price");
                                techDevice.type = p.Value<string>("type");
                                techDevice.color = p.Value<string>("color");
                                techDevice.Brand = p.Value<string>("Brand");
                                techDevice.sn = p.Value<int>("sn");
                                techDevice.description = p.Value<string>("description");
                                techDevice.Warrenty = p.Value<int>("Warrenty");
                                techDevice.operatingSystem = p.Value<string>("operatingSystem");
                                mystore.storeProductList.Add(techDevice);
                                break;

                            case productType.eClothing:
                                Clothing clothing = new Clothing(0, 0, 0, 0, 0);
                                clothing.amount = p.Value<int>("amount");
                                clothing.price = p.Value<int>("price");
                                clothing.type = p.Value<string>("type");
                                clothing.color = p.Value<string>("color");
                                clothing.sn = p.Value<int>("sn");
                                clothing.description = p.Value<string>("description");
                                clothing.size = p.Value<string>("size");
                                mystore.storeProductList.Add(clothing);
                                break;

                            case productType.eHouseholdElectronic:
                                HouseholdElectronic householdElectronic = new HouseholdElectronic(0, 0, 0, 0, 0, 0);
                                householdElectronic.amount = p.Value<int>("amount");
                                householdElectronic.price = p.Value<int>("price");
                                householdElectronic.type = p.Value<string>("type");
                                householdElectronic.color = p.Value<string>("color");
                                householdElectronic.sn = p.Value<int>("sn");
                                householdElectronic.description = p.Value<string>("description");
                                householdElectronic.Brand = p.Value<string>("Brand");
                                householdElectronic.Warrenty = p.Value<int>("Warranty");
                                mystore.storeProductList.Add(householdElectronic);
                                break;

                        }
                    }


                }
            }
        }


    }

    
    }

    
