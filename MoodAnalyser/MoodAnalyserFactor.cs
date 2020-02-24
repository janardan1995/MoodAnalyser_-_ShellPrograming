using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Class1;

namespace Class1
{
   public class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser(string type)
        {
            if (type.Equals("MoodAnalyser"))
            {
                return new MoodAnalyser();
            }
            else
                return null;
        }

    }
}
