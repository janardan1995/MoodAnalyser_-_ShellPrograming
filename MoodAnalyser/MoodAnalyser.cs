// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyserProject
{
    using System;

    /// <summary>
    /// MoodAnalyser class
    /// </summary>
    public class MoodAnalyser
    {
        /// <summary>
        /// static string variable
        /// </summary>
        public static string variable;

        /// <summary>
        /// default constructor
        /// </summary>
        public MoodAnalyser()
        {
        }

        /// <summary>
        /// constructor with perimeter 
        /// </summary>
        /// <param name="message">string type</param>
        public MoodAnalyser(string message)
        {
            variable = message;
        }

        /// <summary>
        /// a Method name AnalyseMood
        /// </summary>
        /// <returns>it will return a string Accordin to the message variable</returns>
        public static string AnalyseMood()
        {
            try
            {
                ////for empty message
                if (variable == "")
                {                    
                    throw new MoodAnalyserException(MoodAnalyserProject.State.EMPTY + "");
                }

                ////for null message
                else if (variable == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NULL_REFERENCE_ERROR + "");
                }

                ////message contains the word sad or not 
                if (variable.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException("NO_SUCH_METHOD_ERROR");
            }
            catch (MoodAnalyserException ex)
            {               
               throw new MoodAnalyserException(ex.Message);
            }
        }

        /// <summary>
        /// this will override the base class of equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>return bool </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

           if (this.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            return false;
        }
    }
}