using MachineLearningML.Model;
using System;

namespace MachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = new ModelInput();
                input.SentimentText = Console.ReadLine();
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("Toxic: " + result.Prediction);
                Console.WriteLine();
            }
           
        }
    }
}
