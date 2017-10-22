///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Text;

namespace FactoryDelegate
{
    public delegate Stream StreamFactory();

    public class Program
    {
        public static void Main(string[] args)
        {
            // Have our factory create a FileStream.
            // Then write some text to that file.
            SetFactoryToMakeFileStreams();
            Stream stream1 = _factory();            
            byte[] bytes = new UTF8Encoding().GetBytes("Hello world in a file!");
            stream1.Write(bytes, 0, bytes.Length);

            // Now have our factory create a MemoryStream.
            // Then write some text to memory.
            SetFactoryToMakeMemoryStreams();
            Stream stream2 = _factory();
            bytes = new UTF8Encoding().GetBytes("Hello world in memory!");
            stream2.Write(bytes, 0, bytes.Length);

            // Write the streams to the console.
            PrintStreamToConsole(stream1);
            PrintStreamToConsole(stream2);

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }        

        private static StreamFactory _factory;

        private static void SetFactoryToMakeFileStreams() => _factory = () => new FileStream("TestFile.txt", FileMode.OpenOrCreate);

        private static void SetFactoryToMakeMemoryStreams() => _factory = () => new MemoryStream();

        private static void PrintStreamToConsole(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
