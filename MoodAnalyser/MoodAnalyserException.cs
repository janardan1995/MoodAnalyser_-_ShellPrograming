using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public enum state
    {
        EMPTY,NULL,OTHER
    }
    public class MoodAnalyserException : Exception
    {
        public MoodAnalyserException(string message): base(message)
        {

        }
    }

    
}
