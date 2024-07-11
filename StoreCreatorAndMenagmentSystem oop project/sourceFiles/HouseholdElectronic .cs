using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class HouseholdElectronic : Electronic
    {
        

        public HouseholdElectronic(int type,int color, int brand, int warranty, int price, int amount)
            : base(color, brand, warranty, price, amount)
        {
            this.type = appliance_type_menu(type);
            this.ProductType = productType.eHouseholdElectronic;
            this.description = this.type + " | " +this.color + " | "  +this.Warrenty;
        }
        override public string getInfo()
        {
            return "HouseholdElectronic";
        }
        private string appliance_type_menu(int type)
        {
            switch (type)
            {
                case 0:
                    return "Oven";
                case 1:
                    return "Refrigerator";
                case 2:
                    return "Washing Machine";
                case 3:
                    return "Dishwasher";
                case 4:
                    return "Air Conditioner";
                case 5:
                    return "Water Heater";
                default:
                    return "Unknown";
            }
        }

    }
}
