using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW3
{
    /// <summary>
    /// Класс-фабрика.
    /// </summary>
    public class FigureFactory
    {
        public static IFigure GetFigure(string type, params double[] param)
        {
            switch (type.ToUpper())
            {
                case "RECTANGLE":
                    return new Rectangle(param[0], param[1]);
                case "SQUARE":
                    return new Square(param[0]);
                case "CIRCLE":
                    return new Circle(param[0]);
            }
            return null;
        }
    }
}
