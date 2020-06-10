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
        [ColumnName("Sarcasm"), LoadColumn(0)]
        public string Sarcasm { get; set; }


        [ColumnName("SarcasmText"), LoadColumn(1)]
        public string SarcasmText { get; set; }


        [ColumnName("ContextText"), LoadColumn(2)]
        public string ContextText { get; set; }


    }
}
