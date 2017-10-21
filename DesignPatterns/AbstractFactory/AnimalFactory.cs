///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace AbstractFactory
{
    /// <summary>
    /// This is the abstract factory.
    /// The DogFactory class and CatFactory class the concrete
    /// factory classes which create Dogs and Cats respectively.
    /// </summary>
    public abstract class AnimalFactory
    {
        public abstract Animal CreateAnimal();
    }
}
