///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace AbstractFactory
{
    /// <summary>
    /// This is the abstract factory - in this case I've simply used an interface.
    /// Note I have also made the Factory interface generic so that it can be used
    /// for different factory types.    
    /// </summary>
    public interface IFactory<T>
    {
        T Create();
    }
}
