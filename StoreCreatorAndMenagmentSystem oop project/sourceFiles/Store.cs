using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class Store
    {

        private string _storName { get; set; }
        private List<product> _storeProductList { get; set; }
        private string _store_manager_name { get; set; }
        private string _password { get; set; }
        private char[] chars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '<', '>', ',', '.', '?', '/' };
        private char[] capitalLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] nonCapitalLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
       
        public Store(string Storename, string managerName, string managerPassword)
        {
            storeName = Storename;
            _storeProductList = new List<product>();

            store_manager_name = managerName;

            password=managerPassword;

        }


  
        public string password { get { return _password; } set { if (password_valid(value)) { this._password = value; } } }
        public string storeName { get { return _storName; } set { _storName = value; } }
        public string store_manager_name { get { return _store_manager_name; } set { _store_manager_name = value; } }
        public List<product> storeProductList { get { return _storeProductList; } set { _storeProductList = value; } }

        private bool password_validate(string password)
        { if (password == _password) return true; return false; }


        public bool data_validate(string username,string storeName, string password)
        {
            if (password_validate(password) && username == _store_manager_name) return true; return false;
        }

        public bool password_valid(string password)
        {

            if (password == null)
            {
                return false;
            }
            if (password.Length < 8)
                return false;
            if (!chars.Any(c => password.Contains(c)))
                return false;
            if (!capitalLetters.Any(c => password.Contains(c)))
                return false;
            if (!nonCapitalLetters.Any(c => password.Contains(c)))
                return false;

            return true;
        }
        public void addProduct(productType choose, int[] arr)
        {

            product a;
            switch (choose)
            {
                case productType.efurniture:
                     a = new Furniture(arr[0], arr[3], arr[1], arr[2], arr[4], arr[5]);
                    storeProductList.Add(a);
                    break;

                case productType.etechDevice:
                    // type, color,  brand,  warranty,  price,  amount,  applianceType
                     a = new techDevice(arr[0], arr[2], arr[1], arr[3], arr[4], arr[5], arr[6]);
                    storeProductList.Add(a);
                    break;

                case productType.eClothing:

                     a = new Clothing(arr[0], arr[2], arr[1], arr[4], arr[5]);
                    storeProductList.Add(a);
                    break;

               case productType.eHouseholdElectronic:
                    //type brand warranty priceamount operatingSystem
                     a = new HouseholdElectronic(arr[0], arr[2], arr[1], arr[3], arr[4], arr[5]);
                    storeProductList.Add(a);
                    break;

                default:
                    break;
            }
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
