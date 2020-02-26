using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserProject
{
    public class CreateMoodFactory
    {
        public static Type CreateMoodAnalyserReflection(string ClassName)
        {
            try
            {
                if (ClassName == null || ClassName!= "MoodAnalyserProject.MoodAnalyser" || ClassName=="")
                {
                    throw new MoodAnalyserException("No Such Class Error");
                }
                else
                {
                    Type t = Type.GetType(ClassName);
                    return t;
                }

            }
            catch (Exception)
            {
                throw new MoodAnalyserException("No Such Class Error");
            }
        }

        public static MoodAnalyser CreateMoodAnalyserObject()
        {
            return new MoodAnalyser();
        }

    }
   
}
