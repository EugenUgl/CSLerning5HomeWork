using System;
using EssenceLib;

namespace CSLerning5
{


    class Program
    { 
        static void Main(string[] args)
        {
            
            View view = new View();

            Plant plant = new()
            {
                Name = view.Input("Input name of plant"),
                Growth = Convert.ToInt32(view.Input("Input heigth of plant sm"))                
            };

            Enimal kat = new(10, 2, "Tom");

            Console.WriteLine($"");
            plant.ShowSpecifications();
            kat.ShowSpecifications();

            Console.WriteLine("Hello World!");
        }
    }
}
