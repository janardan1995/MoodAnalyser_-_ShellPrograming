// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyseeFactory.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyserProject
{
    using System;
    using System.Reflection;

    /// <summary>
    /// This is MoodAnalyser Factory to create an object from reflection
    /// </summary>
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// CreatedMoodAnalyserReflection to create a reflection object
        /// </summary>
        /// <param name="ClassName">it will return object  </param>
        /// <returns>its return an object</returns>
        public static object MoodAnalyserReflection(string ClassName)
        {
            Type type = Type.GetType("MoodAnalyserProject." + ClassName);          
            
            try
            {
                if (type == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR+"");
                }
                object classObject = Activator.CreateInstance(type);                
                return classObject;                
            }
            catch (MoodAnalyserException ex)
            {                
                return ex.Message;
            }
        }   
    }
}


