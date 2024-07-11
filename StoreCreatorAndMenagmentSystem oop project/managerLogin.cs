using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class managerLogin : Form
    {
        public Form _currentForm = null;
        private Store _mystore;
        private string _username = null;
        private string _password = null;
        public managerLogin(Store mystore)
        {
            InitializeComponent();
            _mystore = mystore;

        }
        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {
            if (_mystore.data_validate(_username,_mystore.storeName, _password))
            {
                if (_currentForm != null)
                    _currentForm.Close();
                _currentForm = new storeManagment(_mystore);
                _currentForm.Show();

                Close();
            }
            else
            {

                MessageBox.Show("user name or password not match");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _password = textBox2.Text;
        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
