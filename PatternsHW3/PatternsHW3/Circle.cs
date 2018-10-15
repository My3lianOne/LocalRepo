using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW3
{
    /// <summary>
    /// Класс описывающий сущность Круг.
    /// </summary>
    public class Circle : IFigure
    {
        //Радиус круга
        double Rad { get; }

        /// <summary>
        /// Метод расчета площади круга.
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare()
        {
            return Program.Pi * Math.Pow(Rad, 2);
        }

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="rad">Радиус круга</param>
        public Circle(double rad)
        {
            Rad = rad;
        }
    }
}
