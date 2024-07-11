using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using StoreCreatorAndMenagmentSystem_oop_project.sourceFiles;


namespace StoreCreatorAndMenagmentSystem_oop_project
{
    internal partial class ThankYouForm : Form
    {
        Store _mystore;
        public ThankYouForm(Store mystore)
        {
            InitializeComponent();
            _mystore = mystore;
            storeName.Text = _mystore.storeName;
        }



        private void closeLable_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
