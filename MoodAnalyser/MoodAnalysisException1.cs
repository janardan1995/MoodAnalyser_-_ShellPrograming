// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace Class1
{    
    public class MoodAnalysisException : Exception
    {       
        public MoodAnalysisException(string message) : base(message)
        {

        }
        public enum state
        {
            EMPTY, NULL, OTHER
        }      

    }
}