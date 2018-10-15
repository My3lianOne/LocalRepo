using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IItem
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);
    }

    interface IColorable
    {
        void SetColor(Color color);
    }

    interface ISizable
    {
        void SetSize(Size size);
    }
}
