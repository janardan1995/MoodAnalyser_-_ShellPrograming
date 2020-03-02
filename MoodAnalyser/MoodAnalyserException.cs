// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyserException.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyserProject
{    
    using System;

    /// <summary>
    /// Enumerator are written here
    /// </summary>   
    public enum State
    {
        EMPTY,
        NULL_REFERENCE_ERROR,
        NO_SUCH_METHOD_ERROR, 
        NO_SUCH_FIELD_ERROR,
        NO_SUCH_CLASS_ERROR,OTHER,
    }

    /// <summary>
    ///this is my  Custom exception throws MoodAnalyserExceptiom 
    /// </summary>
    [Serializable]
    public class MoodAnalyserException : Exception
    {     
        /// <summary>
        /// this custom MoodAnalyserException taken a string typr perimeter
        /// </summary>
        /// <param name="message">single perimeter</param>
        public MoodAnalyserException(string message): base(message)
        {
        }
    }    
}
