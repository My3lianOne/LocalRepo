using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW3
{
    /// <summary>
    /// Класс описывающий сущность Квадрат.
    /// </summary>
    public class Square : IFigure
    {
        //Ребро квадрата
        double Edge { get; }

        /// <summary>
        /// Метод расчета площади квадрата.
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare()
        {
            return Math.Pow(Edge, 2);
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="edge">Ребро квадрата</param>
        public Square(double edge)
        {
            Edge = edge;
        }
    }
}
