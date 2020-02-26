// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyserProject
{
    using System;
    
    public class MoodAnalyser
    {
        public static string variable;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            variable = message;
        }

        public static string AnalyseMood()
        {
            try
            {
                if (variable == "")
                {
                    Console.WriteLine("THIS IS AN {0} MESSAGE", MoodAnalyserProject.state.EMPTY);
                    throw new MoodAnalyserException("empty message");
                }
                if (variable.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("THIS IS AN {0} MESSAGE", MoodAnalyserProject.state.NULL);
                throw new MoodAnalyserException("null message");
                
            }
             catch (ArgumentException)
            {
                Console.WriteLine("THIS IS AN {0} MESSAGE", MoodAnalyserProject.state.OTHER);
                throw new MoodAnalyserException("other message");
               
            }

        }
        public override bool Equals(object obj)
        {
            Type type = (Type)obj;
            if (this.GetType().ToString().Equals(type.FullName))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        public static void Main()
        {
            try
            {
                var obj1 = CreateMoodFactory.CreateMoodAnalyserObject();
                var obj2 = CreateMoodFactory.CreateMoodAnalyserReflection("MoodAnalyserProject.MoodAnalyser");
                var x = obj1.Equals(obj2);
                Console.WriteLine(x);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }


    
}
