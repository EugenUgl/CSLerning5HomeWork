using System;

namespace EssenceLib
{
    /// <summary>
    /// Класс описывающий растение, унаследован от класса Essence (сущность)
    /// </summary>
    public class Plant : Essence
    {
        /// <summary>
        /// Высота растения (поле)
        /// </summary>
        private int growth;

        /// <summary>
        /// Высота растения (свойство)
        /// </summary>
        public int Growth { get => growth; set => growth = value; }
                
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Plant()
        {
            type = nameof(Plant);
        }


        /// <summary>
        /// Конструктор, принимающий в себя весь набор параметров
        /// </summary>
        /// <param name="heigth"></param>
        /// <param name="name"></param>
        public Plant(int heigth, string name) : base(name)
        {
            type = nameof(Plant);
            Growth = heigth;
        }


        /// <summary>
        /// Переопределенный метод вывода свойств растения на консоль
        /// </summary>
        public override void ShowSpecifications()
        {
            Console.WriteLine($"{nameof(type)}: {type}");
            base.ShowSpecifications();
            Console.WriteLine($"{nameof(Growth)}: {Growth} sm");
            Console.WriteLine($"");
        }
    }
}
