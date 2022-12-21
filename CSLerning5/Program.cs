using System;
using EssenceLib;

namespace CSLerning5
{

    /// <summary>
    /// Класс, методы которого предназначены для ввода/вывода данных на консоль
    /// </summary>
    class View
    {
        /// <summary>
        /// Метод вывода данных с консоли
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        public string Input(string mess)
        {
            Console.Write(mess + ":");
            var value = Console.ReadLine();

            return value;
        }

        /// <summary>
        /// Метод ввода данных на консоль
        /// </summary>
        /// <param name="mess"></param>
        /// <param name="value"></param>
        public void Output(string mess, object value)
        {
            Console.WriteLine(mess + value.ToString());
        }
    }


    class Program
    { 
        static void Main(string[] args)
        {
            
            View view = new View();

            Plant plant = new()
            {
                Name = view.Input("Input name of plant"),
                Heigth = Convert.ToInt32(view.Input("Input heigth of plant sm"))                
            };

            Enimal kat = new(10, 2, "Tom");

            Console.WriteLine($"");
            plant.ShowSpecifications();
            kat.ShowSpecifications();

            Console.WriteLine("Hello World!");
        }
    }
}
