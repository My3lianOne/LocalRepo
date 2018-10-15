using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Торочков Илья
/// Применить шаблон «Фабрика» для создания объектов, описывающих геометрические фигуры (круг, квадрат, прямоугольник).
/// </summary>
namespace PatternsHW3
{    
    static class Program
    {
        //Константа Число Пи.
        public static readonly double Pi = 3.14;

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFigure[] figures = {
                FigureFactory.GetFigure("rectangle", 10, 10),
                FigureFactory.GetFigure("Square",15),
                FigureFactory.GetFigure("CiRcLe",20)
            };


            foreach (var figure in figures)
            {
                Console.WriteLine("Square of figure " + figure.GetType().Name + " : " + figure.GetSquare());
                Console.ReadKey();
            }
        }
    }
}
