using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radosław Bielak IA\nZadanie 5\nFabryka Gitar");
            List<Guitar> BassGuitar = new List<Guitar>();
            BassGuitarFactory BassFactory = new BassGuitarFactory();
            Console.WriteLine("\nWe've build a new " + BassFactory.Name() + " guitar");
            BassGuitar.Add(BassFactory.CreateBody());
            BassGuitar.Add(BassFactory.CreateNeck());
            BassGuitar.Add(BassFactory.CreatePickups());
            BassGuitar.Add(BassFactory.CreateStrings());
            foreach (Guitar b in BassGuitar) Console.WriteLine(b);

            List<Guitar> ElectricGuitar = new List<Guitar>();
            ElectricGuitarFactory ElectricFactory = new ElectricGuitarFactory();
            Console.WriteLine("\nWe've build a new " + ElectricFactory.Name() + " guitar");
            ElectricGuitar.Add(ElectricFactory.CreateBody());
            ElectricGuitar.Add(ElectricFactory.CreateNeck());
            ElectricGuitar.Add(ElectricFactory.CreatePickups());
            ElectricGuitar.Add(ElectricFactory.CreateStrings());
            foreach (Guitar e in ElectricGuitar) Console.WriteLine(e);

            List<Guitar> AcousticGuitar = new List<Guitar>();
            AcousticGuitarFactory AcousticFactory = new AcousticGuitarFactory();
            Console.WriteLine("\nWe've build a new " + AcousticFactory.Name() + " guitar");
            AcousticGuitar.Add(AcousticFactory.CreateBody());
            AcousticGuitar.Add(AcousticFactory.CreateNeck());
            AcousticGuitar.Add(AcousticFactory.CreatePickups());
            AcousticGuitar.Add(AcousticFactory.CreateStrings());
            foreach (Guitar b in AcousticGuitar) Console.WriteLine(b);
        }
    }
}
