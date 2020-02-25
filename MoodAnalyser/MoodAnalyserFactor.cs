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
            try
            {
                if (type.Equals("MoodAnalyser"))
                return new MoodAnalyser();
                else
                throw new MoodAnalysisException("NO SUCH CASE ERROR1");
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException("NO SUCH CASE ERROR2");
            }

        }

    }
}
