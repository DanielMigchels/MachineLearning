using SampleClassification.Model;
using System;

namespace SarcasmDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = new ModelInput();
                input.ContextText = Console.ReadLine();
                input.SarcasmText = Console.ReadLine();
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("Sarcasm: " + result.Prediction);
                Console.WriteLine();
            }
        }
    }
}
