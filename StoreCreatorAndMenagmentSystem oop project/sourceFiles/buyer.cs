using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCreatorAndMenagmentSystem_oop_project.sourceFiles
{
    internal class buyer
    {
        
        private List<product> _shoppingCart;

        public buyer()
        {
            _shoppingCart = new List<product>();
        }

        public List<product> ShoppingCart
        {
            get { return _shoppingCart; }
            set { _shoppingCart = value; }
        }
        
        public void AddToCart(product _product)
        {
            _shoppingCart.Add(_product);

        }
        public void RemoveFromCart(product _product)
        {
            _shoppingCart.Remove(_product);
        }


    }

}
