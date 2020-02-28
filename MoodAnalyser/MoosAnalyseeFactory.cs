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
        /// <returns>its return an object</returns>
        public static object CreateMoodAnalyserReflection(string ClassName)
        {
            Type type = Type.GetType("MoodAnalyserProject." + ClassName);          
            
            try
            {
                if (type == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR+"");
                }
                
                ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
                object classObject = constructorInfo.Invoke(new object[] { });
                return classObject;                
            }
            catch (MoodAnalyserException ex)
            {                
                return ex.Message;
            }
        }

        /// <summary>
        /// this is the second method where improper constructor should throw an exception
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns>its return an object</returns>
        public static object CreateMoodAnalyserImproperConstructor(string ClassName)
        {
            Type type = Type.GetType("MoodAnalyserProject" + ClassName);
            try
            {
                if (type == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR + "");
                } 
                
                ConstructorInfo constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
                if (constructorInfo == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.N0_SUCH_METHOD_ERROR + "");
                }
                object classInfo = constructorInfo.Invoke(new object[] { "I am in any mood" });
                return classInfo;               

            }
            catch (MoodAnalyserException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// parameter passing constructor
        /// </summary>
        /// <param name="ClassName"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserReflectionParameter(string ClassName,params object[] p)
        {
            Type type = Type.GetType("MoodAnalyserProject." + ClassName);

            try
            {
                if (type == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR + "");
                }
                object classObject = Activator.CreateInstance(type,p);
                return classObject;
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


