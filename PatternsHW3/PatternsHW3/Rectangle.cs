using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW3
{
    /// <summary>
    /// Класс описывающий сущность Прямоугольник.
    /// </summary>
    public class Rectangle : IFigure
    {
        // Ребро А
        double EdgeA { get; }
        
        // Ребро B
        double EdgeB { get; }

        /// <summary>
        /// Метод расчета площади прямоугольника.
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare()
        {
            return EdgeA * EdgeB;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="edgeA">Ребро А</param>
        /// <param name="edgeB">Ребро B</param>
        public Rectangle(double edgeA, double edgeB)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
        }
    }
}
