using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class Clothing : product
    {
        private string _size;

        public Clothing(int type, int color, int size, int price, int amount)
        {
            this.type = type_menu(type);
            this._size = size_menu(size);
            this.color = color_menu(color);
            this.amount = amount;
            this.Price = price;
            this.ProductType = productType.eClothing;
            this.description = "| " + this.type + " | " + this._size + " | "+this.color;
        }
        public string size { get { return _size; } set { _size = value; } }

        override public string getInfo()
        {
            return "Clothing";
        }
        private string type_menu(int type)
        {

            switch (type)
            {
                case 0:
                    return "T-Shirt";
                case 1:
                    return "Polo Shirt";
                case 2:
                    return "Dress Shirt";
                case 3:
                    return "Hoodie";
                case 4:
                    return "Jacket";
                case 5:
                    return "Pants";
                case 6:
                    return "Shorts";
                case 7:
                    return "Skirt";
                case 8:
                    return "Dress";
                default:
                    return "Unknown";
            }
        }


        private string size_menu(int size)
        {


            switch (size)
            {
                case 0:
                    return "XS";
                case 1:
                    return "S";
                case 2:
                    return "M";
                case 3:
                    return "L";
                case 4:
                    return "XL";
                case 5:
                    return "XXL";
                default:
                    return "Unknown";
            }
        }



    }
}
