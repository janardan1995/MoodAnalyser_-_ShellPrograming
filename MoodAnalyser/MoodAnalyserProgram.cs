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
        public string str;
        public MoodAnalyser()
        {           
        }

        public MoodAnalyser(string message)
        {
           this.str = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (str.Length == 0)
                {
                    throw new MoodAnalysisException("Empty message");
                }

                if (str.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
               
                    return "HAPPY";             
             }
            catch (NullReferenceException)
            {
                //return "HAPPY";
                throw new MoodAnalysisException("null message");
            }
            catch (Exception)
            {
                throw new MoodAnalysisException("empty message");
            }
        }
    }            
}
