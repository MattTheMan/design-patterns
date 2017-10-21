///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace Factory
{
    /// <summary>
    /// This is a concrete factory class which creates cats.
    /// </summary>
    public class CatFactory : IFactory<Animal>
    {
        public Animal Create() => new Cat();
    }
}
