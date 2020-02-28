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
    /// this my Factory class to create object by using reflection
    /// </summary>
    public class CreateMoodFactory
    {
        /// <summary>
        /// CreatedMoodAnalyserReflection to create a reflection object
        /// </summary>
        /// <param name="ClassName">it will return object  </param>
        /// <returns></returns>
        public static object CreateMoodAnalyserReflection(string ClassName)
        {
            Type type = Type.GetType("MoodAnalyserProject." + ClassName);          
            
            try
            {
                if (type == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR+"");
                }
                else
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
                    object classObject = constructorInfo.Invoke(new object[] { });
                    return classObject;

                }

            }
            catch (MoodAnalyserException ex)
            {
                
                return ex.Message;
            }
        }

        /// <summary>
        /// just it create an object of MoodAnalysis class
        /// </summary>
        /// <returns>return an object</returns>
        public static MoodAnalyser CreateMoodAnalyserObject()
        {
            return new MoodAnalyser();
        }
    }
}


