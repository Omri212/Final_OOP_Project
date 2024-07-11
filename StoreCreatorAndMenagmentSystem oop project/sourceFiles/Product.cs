using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
     internal enum productType
    {
        efurniture=0, etechDevice, eClothing, eHouseholdElectronic
    }
    internal class product:ICloneable
    {
        
        private productType _product_type { get; set; }
        private double _price { get; set; }
        private string _type { get; set; }

        private static int _id = 0;
        private int _sn { get; set; }
        private int _amount { get; set; }
        private string _description { get; set; }
        private string _color { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public product()
        {
            this._sn = _id++;
        }
       

        public productType ProductType { get { return _product_type; } set { _product_type = value; } }
        public double price { get { return _price; } set { _price = value; } }
        public string type { get { return _type; } set { _type = value; } }
        public int sn { get { return _sn; } set { _sn = value; } }
        public int amount { get { return _amount; } set { _amount = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public string description { get { return _description; } set { _description = value; } }

        public virtual string getInfo() { return "product"; }

        public int Id
        {
            get { return _id; }
        }

        


        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }



        protected string color_menu(int color)
        {
            switch (color)
            {
                case 0:
                    return "Black";
                case 1:
                    return "White";
                case 2:
                    return "Brown";
                case 3:
                    return "Red";
                case 4:
                    return "Blue";
                case 5:
                    return "Green";
                default:
                    return "Unknown";
            }
        }
    }
}
