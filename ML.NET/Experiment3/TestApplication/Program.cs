using SampleClassification.Model;
using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var input = new ModelInput();
                input.Tweet = Console.ReadLine();
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("Donald Tweet: " + result.Prediction + " - " + result.Score[1]);
                Console.WriteLine();
            }
            
        }
    }
}
