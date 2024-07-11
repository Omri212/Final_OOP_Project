using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class Furniture : product
    {

        private string _material;
        private string _style;



        public Furniture(int type, int material, int style, int color, int price, int amount)
        {
            this.type = type_menu(type);
            this.Material = material_menu(material);
            this.Style = style_menu(style);
            this.color = color_menu(color);
            this.Price = price;
            this.amount = amount;
            this.ProductType = productType.efurniture;
            this.description = "| " + this.type + " | " + this._style + " | "+this.color;
        }

        public string Material { get { return _material; } set { _material = value; } }
        public string Style { get { return _style; } set { _style = value; } }
        public override string getInfo()
        {
            return "Furniture";
        }
        private string material_menu(int material)
        {

            switch (material)
            {
                case 0:
                    return "Wood";

                case 1:
                    return "Stainless Steel";
                case 2:
                    return "Cane";
                case 3:
                    return "Plastic";
                case 4:
                    return "Fabric";
                default:
                    return "unknown";
            }

        }

        private string style_menu(int style)
        {

            switch (style)
            {
                case 0:
                    return "Modern Style";

                case 1:
                    return "Farmhouse Style";
                case 2:
                    return "Industrial Style";
                case 3:
                    return "Rustic Style";
                case 4:
                    return "Mid-century Modern Style";
                case 5:
                    return "Scandinavian";
                default:
                    return "unknown";
            }

        }

        private string type_menu(int type)
        {
            switch (type)
            {
                case 0:
                    return "Chair";
                case 1:
                    return "Table";
                case 2:
                    return "Sofa";
                case 3:
                    return "Bed";
                case 4:
                    return "Cabinet";
                default:
                    return "Unknown";
            }
        }




    }

}
