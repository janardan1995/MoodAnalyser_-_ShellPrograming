// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyserFactory.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyserProject
{
    using System;
    using MoodAnalyserProject;
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
        public static object MoodAnalyserReflection(string ClassName,Object[] ConstructorPara = null,string MethodName=null,string FieldValue=null)
        {
            try
            {
                ////Type class takes object information from metadata  
                Type type = Type.GetType("MoodAnalyserProject." + ClassName);
                if (type == null)
                    throw new MoodAnalyserException(State.NO_SUCH_CLASS_ERROR.ToString());
               
                ////to create instance of that class
                Object obj = Activator.CreateInstance(type, ConstructorPara);

                if (FieldValue != null)
                {
                    FieldInfo fieldInfo = type.GetField(FieldValue);
                    if (fieldInfo == null)
                        throw new MoodAnalyserException(State.NO_SUCH_FIELD_ERROR.ToString());
                   
                    fieldInfo.SetValue(obj, FieldValue);
                    
                }            

                if (MethodName != null)
                {
                    MethodInfo MI = type.GetMethod(MethodName);
                    if (MI == null)
                        throw new MoodAnalyserException(State.NO_SUCH_METHOD_ERROR.ToString());

                    object Method = MI.Invoke(obj,null);
                    return Method;
                }
                
                return obj;
            }
            catch (ArgumentNullException)
            {
                ////throws NO_SUCH_CLASS_EROOR
                throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_CLASS_ERROR.ToString());
            }
            catch (MissingMethodException)
            {
                ////Throw when method or constructor is not proper
                throw new MoodAnalyserException(MoodAnalyserProject.State.NO_SUCH_METHOD_ERROR.ToString());
            }
            catch (MoodAnalyserException ex)
            {
                return ex.Message;
            }
        }
    }
}