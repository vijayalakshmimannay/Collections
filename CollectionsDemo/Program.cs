// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;


namespace CollectionDemo
{
    class program
    {
        static void Main(string[] args)
        {
            CollectionDemo.CollectionsDemo sample = new CollectionDemo.CollectionsDemo();
            sample.List();
            sample.Stack();
            sample.Queue();
            sample.Set();
            sample.Dictionary();
        }
    }
}
           
