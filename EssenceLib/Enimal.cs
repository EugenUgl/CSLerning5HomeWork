using System;

namespace EssenceLib
{
    /// <summary>
    /// Класс описывающий животное
    /// </summary>
    public class Enimal : Essence
    {
        private int age;
        private int size;

        /// <summary>
        /// Поле возраст
        /// </summary>
        public int Age { get => age; set => age = value; }

        /// <summary>
        /// Поле размер
        /// </summary>
        public int Size { get => size; set => size = value; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Enimal()
        {
            type = nameof(Enimal);
        }

        /// <summary>
        /// Конструктор инициализирующий все поля класса
        /// </summary>
        /// <param name="age"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        public Enimal(int age, int size, string name) : base(name)
        {
            type = nameof(Enimal);
            Age = age;
            Size = size;
        }

        /// <summary>
        /// Метод выводящий все свойства класса на консоль
        /// </summary>
        public override void ShowSpecifications()
        {
            Console.WriteLine($"{nameof(type)}: {type}");
            base.ShowSpecifications();
            Console.WriteLine($"{nameof(Age)}: {Age} years");
            Console.WriteLine($"{nameof(Size)}: {Size} m");
            Console.WriteLine($"");
        }
    }
}
