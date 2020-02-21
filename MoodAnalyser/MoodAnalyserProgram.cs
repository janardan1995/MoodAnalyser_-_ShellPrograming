// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Class1
{
    using System;
    public class MoodAnalyser
    {
        public static string AnalysisMoodFunction(string str)
        {                      
            if (str.ToLower().Contains("sad"))
            {
                return "Sad mood";
            }
            return "Happy";
        }
    }
}
