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
using static System.Windows.Forms.AxHost;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class new_store : Form
    {
        public static Store mystore;
        public Form _currentForm = null;
        private string _store_name;
        private string _manager_name;
        private string _manager_Password;
        private List<string> storeNames;
        private string storeDBfilePath = $"storeDB.json";

        public new_store()
        {
            InitializeComponent();
            SoundPlayer charge = new SoundPlayer(@"soundSource\start.wav");
            charge.Play();
            storeNames = new List<string>();
            if (File.Exists(storeDBfilePath))
            {
                string json = File.ReadAllText(storeDBfilePath);
                storeNames = JsonConvert.DeserializeObject<List<string>>(json);
            }
            else
            {
                string json = JsonConvert.SerializeObject(storeNames);
            }
        }

        private void createStoreButton_Click(object sender, EventArgs e)
        {
            SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
            charge.Play();

            if (password.Text != reEnterPassword.Text)
            {
                MessageBox.Show("password dose not match");
            }
            else
            {
                _manager_name = managerName.Text;
                _store_name = storeName.Text;
                _manager_Password = password.Text;

                if (storeNames != null && storeNames.Contains(_store_name))
                {
                    MessageBox.Show("store alredy exist, please choose another name");

                }
                else
                {
                    if (_manager_name == "" || _manager_Password == "" || _store_name == "")
                    {
                        MessageBox.Show("please fill all data");

                    }
                    else
                    {
                        mystore = new Store(_store_name, _manager_name, _manager_Password);

                        if (!mystore.password_valid(_manager_Password))
                        {

                            MessageBox.Show("password invalid");

                        }
                        else
                        {
                            if (_currentForm != null)
                                _currentForm.Dispose();
                            _currentForm = new storeMainScreen(mystore, this);
                            _currentForm.Show();

                            string storeJson = JsonConvert.SerializeObject(mystore);
                            string filePath = $"{_store_name}.json";
                            File.WriteAllText(filePath, storeJson);
                            storeNames.Add(_store_name);

                            string storeNameDBjson = JsonConvert.SerializeObject(storeNames);
                            string filePath1 = "storeDB.json";
                            File.WriteAllText(filePath1, storeNameDBjson);
                            this.Visible=false;
                        }
                    }
                }
            }
        }


        private bool storeNameValidation()
        {
            if (storeName.Text == "")
            {
                errorProvider1.SetError(storeName, "Please enter store name");
                return false;
            }
            errorProvider1.SetError(storeName, "");

            return true;
        }
        private bool managerNameValidation()
        {
            if (managerName.Text == "")
            {
                errorProvider1.SetError(managerName, "Please enter manager name");
                return false;
            }
            errorProvider1.SetError(managerName, "");
            return true;
        }
        private bool passwordMatchValidation()
        {
            if (reEnterPassword.Text != "" && reEnterPassword.Text != password.Text)
            {
                errorProvider1.SetError(reEnterPassword, "Password don't match");
                return false;
            }
            errorProvider1.SetError(reEnterPassword, "");

            return true;
        }

        private void storeName_TextChanged(object sender, EventArgs e)
            {
            _store_name = storeName.Text;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            _manager_Password = password.Text;
        }
        private void closeLable_Click(object sender, EventArgs e)
        {
            SoundPlayer charge = new SoundPlayer(@"soundSource\exit.wav");
            charge.Play();
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer charge = new SoundPlayer(@"soundSource\button.wav");
            charge.Play();
            
            string filePath = $"{_store_name}.json";
            if (File.Exists(filePath))
            {
                string storeJson = File.ReadAllText(filePath);
                Store mystore = JsonConvert.DeserializeObject<Store>(storeJson);

                if (mystore.data_validate(managerName.Text, storeName.Text, password.Text))
                {
                   
                    _currentForm = new storeMainScreen(mystore, this);
                    _currentForm.Show();
                    this.Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("one or more of login information don't match");
                    
                }

            }
            else
            {
                MessageBox.Show("one or more of login information don't match");

            }
        }

        private void storeName_Validating(object sender, CancelEventArgs e)
        {
            storeNameValidation();
        }

        private void managerName_Validating(object sender, CancelEventArgs e)
        {
            managerNameValidation();
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            passwordMatchValidation();
        }

        private void reEnterPassword_Validating(object sender, CancelEventArgs e)
        {
            passwordMatchValidation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadingImg.Dispose();

        }
    }
}