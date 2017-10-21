///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;

namespace AbstractFactory
{
    /// <summary>
    /// The program has an animal factory for creating subclass instances of Animal such as Dog or Cat.
    /// Simply swap out the concrete factory to change the type of animal which gets created.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {            
            MakeDogs();
            Animal animal1 = _factory.CreateAnimal();

            MakeCats();
            Animal animal2 = _factory.CreateAnimal();

            Console.WriteLine($"Animal 1 says: {animal1.Speak()}");
            Console.WriteLine($"Animal 2 says: {animal2.Speak()}");

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }

        private static AnimalFactory _factory;

        private static void MakeDogs() => _factory = new DogFactory();

        private static void MakeCats() => _factory = new CatFactory();
    }
}
