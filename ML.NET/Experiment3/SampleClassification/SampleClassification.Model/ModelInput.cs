//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleClassification.Model
{
    public class ModelInput
    {
        [ColumnName("Sentiment"), LoadColumn(0)]
        public string Sentiment { get; set; }


        [ColumnName("Tweet"), LoadColumn(1)]
        public string Tweet { get; set; }


    }
}
