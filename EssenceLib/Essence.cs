using System;

namespace EssenceLib
{
    /// <summary>
    /// Абстрактный класс сущность, который хранит в себе общие элементы для классов растение и животное
    /// </summary>
    public abstract class Essence
    {
        protected string type;
        private string name;

        /// <summary>
        /// Тип сущности
        /// </summary>
        public virtual string Type_ { get => type; set => type = value; }

        /// <summary>
        /// Имя сущности
        /// </summary>
        public virtual string Name { get => name; set => name = value; }

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Essence()
        {
            
        }

        /// <summary>
        /// конструктор инициирующий поле имя
        /// </summary>
        /// <param name="name"></param>
        public Essence(string name)
        {
            this.name = name;
        }


        /// <summary>
        /// Виртуальный метод, который выводит имя сущности на консоль
        /// </summary>
        public virtual void ShowSpecifications()
        {
            Console.WriteLine($"{nameof(Name)}: {Name} ");
        }
    }
}
