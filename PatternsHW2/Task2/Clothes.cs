using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Clothes : IItem, IDiscountable, IColorable, ISizable
    {
        public void SetColor(Color color) { }
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
    }
}
