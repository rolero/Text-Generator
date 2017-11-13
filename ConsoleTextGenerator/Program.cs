﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TextGenerator;
using TextGenerator.TextSources;

namespace ConsoleTextGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new Twitter("AddKeyHere", "AddSecretHere", "AddTwitterHere");
            var items = twitter.GetTextFromSource();
            var textGen = new SimpleTextGenerator(StateParsingDelegates.ParseSingleWords);
            items.ToList().ForEach(x => textGen.Consume(x));
            while (true)
            {
                Console.WriteLine(textGen.Generate());
                Console.ReadKey();
            }
        }
    }
}