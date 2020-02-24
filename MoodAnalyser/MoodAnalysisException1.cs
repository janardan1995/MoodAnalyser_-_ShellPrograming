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

        //public string variable;
        //public MoodAnalysisException(string message)
        //{
        //    this.variable = message;
        //}
        //public override string Message
        //{
        //    get
        //    {
        //        return variable;
        //    }
        //}

    }
}