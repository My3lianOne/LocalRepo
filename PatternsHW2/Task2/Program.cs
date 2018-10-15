using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Торочков Илья.
/// 2. Принцип разделения интерфейсов.
/// Товары в магазине могут иметь промокод, скидку, у них есть цена, состояние и т.д.Если этот товар – одежда,
/// то для нее устанавливается, из какого она материала, ее цвет и размер.Какие изменения нужно внести в код,
/// чтобы описать произвольные товары (книги, автомобили и т.п.), соблюдая принципы SOLID?
/// 
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes shirt = new Clothes();
            shirt.SetColor(new Color());
            shirt.SetPrice(100);
            shirt.SetSize(Size.XL);
            shirt.SetDiscount(20);
            shirt.SetPromocode("GEEKBRAINS");
        }
    }
}
