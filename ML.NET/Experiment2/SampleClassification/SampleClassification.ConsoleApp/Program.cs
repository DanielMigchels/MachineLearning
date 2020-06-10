//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                SarcasmText = @"NC and NH.",
                ContextText = @"Yeah, I get that argument. At this point, I'd prefer is she lived in NC as well.",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Sarcasm with predicted Sarcasm from sample data...\n\n");
            Console.WriteLine($"SarcasmText: {sampleData.SarcasmText}");
            Console.WriteLine($"ContextText: {sampleData.ContextText}");
            Console.WriteLine($"\n\nPredicted Sarcasm value {predictionResult.Prediction} \nPredicted Sarcasm scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
