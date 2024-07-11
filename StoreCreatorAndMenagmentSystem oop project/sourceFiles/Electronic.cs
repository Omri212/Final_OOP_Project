using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class Electronic : product
    {

        private string _brand;
        private int _warrenty;


        public Electronic(int color, int brand, int Warrenty, int price, int amount)
        {
            this.Warrenty = Warrenty;
            this.Brand = brand_menu(brand);
            this.Price = price;
            this.amount = amount;
            this.color = color_menu(color);
        }

        public string Brand { get { return _brand; } set { _brand = value; } }

        public int Warrenty { get { return _warrenty; } set { _warrenty = value; } }
        override public string getInfo()
        {
            return "Electronic";
        }
       

        private string brand_menu(int brand)
        {
            switch (brand)
            {
                case 0:
                    return "Apple";
                case 1:
                    return "Samsung";
                case 2:
                    return "Microsoft";
                case 3:
                    return "Dell";
                case 4:
                    return "HP";
                case 5:
                    return "Sony";
                default:
                    return "Unknown";
            }
        }


    }
}
