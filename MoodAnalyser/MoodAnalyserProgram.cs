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
                if (str == "")
                {

                    Console.WriteLine("exception is {0}", MoodAnalysisException.state.EMPTY);
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
                 Console.WriteLine("exception is {0}", MoodAnalysisException.state.EMPTY);
                throw new MoodAnalysisException("null message");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("exception is {0}", MoodAnalysisException.state.OTHER);
                throw new MoodAnalysisException("other message");
            }

        }
    }            
}
