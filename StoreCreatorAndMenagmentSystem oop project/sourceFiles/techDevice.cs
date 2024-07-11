using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class techDevice : Electronic
    {

        private string _operatingSystem;

        public techDevice(int type, int color,int brand, int warranty, int price, int amount, int operatingSystem)
            : base(color, brand, warranty, price, amount)
        {

            this._operatingSystem = operating_system_menu(operatingSystem);
            this.ProductType = productType.etechDevice;
            this.type = type_menu(type);
            this.description =  this.type +" | " + this._operatingSystem+ " | " + this.color + " | " + this.Warrenty;

        }
        //"ProductType": 3,
        public string operatingSystem { get { return _operatingSystem; } set { _operatingSystem = value; } }

        override public string getInfo()
        {
            return "techDevice";
        }
        private string type_menu(int type)
        {
            switch (type)
            {
                case 0:
                    return "Smartphone";
                case 1:
                    return "Laptop";
                case 2:
                    return "Desktop Computer";
                case 3:
                    return "Tablet";
                case 4:
                    return "Smartwatch";
                case 5:
                    return "TV";
                default:
                    return "Unknown";
            }
        }
        private string operating_system_menu(int os)
        {
            switch (os)
            {
                case 0:
                    return "iOS";
                case 1:
                    return "Android";
                case 2:
                    return "Windows";
                case 3:
                    return "macOS";
                case 4:
                    return "Linux";
                default:
                    return "Unknown";
            }
        }
 

    }
    }
