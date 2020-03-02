﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyserFactory.cs" company="Bridgelabz">
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
    public class MoodAnalyzerReflection
    {
        /// <summary>
        /// CreatedMoodAnalyserReflection to create a reflection object
        /// </summary>
        /// <param name="ClassName">it will return object  </param>
        /// <returns>its return an object</returns
        public static object MoodAnalyserReflection(string ClassName, params object[] p)
        {
            try
            {
                ////Type class takes object information from metadata  
                Type type = Type.GetType("MoodAnalyserProject." + ClassName);

                ////to create instance of that class
                var obj = Activator.CreateInstance(type, p);
                return obj;
            }
            catch (ArgumentNullException)
            {
                ////throws NO_SUCH_CLASS_EROOR
                throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR.ToString());
            }
            catch (MissingMethodException)
            {
                ////Throw NO_SUCH_METHOD_ERROR
                throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_METHOD_ERROR.ToString());
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserProject.State.OTHER.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static string MoodAnalyserReflector1(string methodName)
        {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type type = executing.GetType("MoodAnalyserProject.MoodAnalyser");
                MethodInfo methodInfo = type.GetMethod(methodName);
                if (methodInfo == null)
                    throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_METHOD_ERROR.ToString());
                return methodName;
            }
            //    string[] parametersArray = { "I am in Happy mood" };
            //    object classInstance = Activator.CreateInstance(type, parametersArray);
            //    object result = methodInfo.Invoke(classInstance, null);
            //    return result.ToString();
            //}
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_METHOD_ERROR.ToString());
            }
        }
    }
}