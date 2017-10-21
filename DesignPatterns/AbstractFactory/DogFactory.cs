///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace AbstractFactory
{
    /// <summary>
    /// This is a concrete factory class which creates dogs.
    /// </summary>
    public class DogFactory : IFactory<Animal>
    {
        public Animal Create() => new Dog();
    }
}
