using System;
using System.Collections;
using System.Diagnostics;
using Castle.Components.DictionaryAdapter;

namespace UseCastleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dic = new Hashtable();
            var fac = new DictionaryAdapterFactory();
            var ada = fac.GetAdapter<IHelloWorld>(dic);
            dic["Message"] = "Hello World";
            dic["SayHello"] = "SayHello World";
            dic[1] = 2;
            Debug.Assert(ada.Message == "Hello world!");
        }
    }

    public interface IHelloWorld
    {
        string Message { get; }

        void SayHello();
    }
}
