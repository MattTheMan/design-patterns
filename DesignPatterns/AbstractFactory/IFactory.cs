///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace Factory
{
    /// <summary>
    /// This is the factory interface.
    /// It is generic so that it can be used for different factory types.    
    /// </summary>
    public interface IFactory<T>
    {
        T Create();
    }
}
