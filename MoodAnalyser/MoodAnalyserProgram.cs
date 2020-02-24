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

        public enum state
        {
            EMPTY,NULL
        }

        public string AnalyseMood()
        {
            try
            {
                if (str=="")
                {
                    throw new MoodAnalysisException("empty message");

                    
                }
                else
                {
                    if (str.ToLower().Contains("sad"))
                    {
                        return "SAD";
                    }

                    return "HAPPY";
                }             
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
