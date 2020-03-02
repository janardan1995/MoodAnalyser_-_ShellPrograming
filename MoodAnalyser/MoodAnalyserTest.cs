// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyserTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// testing project for mood analyser
/// </summary>
namespace NUnitTestProject
{
    //using System;
    using NUnit.Framework;
    using MoodAnalyserProject;
   

    /// <summary>
    /// this is our test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// test case 1.1/2.1
        /// Given a message that contains sad should return sad
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser MA = new MoodAnalyser("i am in sad mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected = "SAD";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1.2/2.2
        /// Given any message except the word sad should return happy
        /// </summary>
        [Test]
        public void GivenAnyyMessage_Except_SadMessage_WhenAnalyse_ShoulReturnHappy()
        {
            MoodAnalyser ma = new MoodAnalyser("i am in any mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected = "HAPPY";
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// test case 3.1
        /// if our message is null then it throw caustom exception
        /// </summary>
        [Test]
        public void GivenNullMessage_WhenAnalyse_shouldThrowException()
        {
            MoodAnalyser ma = new MoodAnalyser(null);
            var actual = Assert.Throws<MoodAnalyserException>(() => MoodAnalyser.AnalyseMood());
            var expected = MoodAnalyserProject.State.NULL_REFERENCE_ERROR.ToString();
            Assert.AreEqual(expected, actual.Message);
        }

        /// <summary>
        /// test case 3.2
        /// if the given message is empty it throw custom exception
        /// </summary>
        [Test]
        public void GivenEmptyMessage_WhenAnalyse_shouldReturnException()
        {
            MoodAnalyser MA = new MoodAnalyser("");
            var actual = Assert.Throws<MoodAnalyserException>(() => MoodAnalyser.AnalyseMood());
            var expected = MoodAnalyserProject.State.EMPTY.ToString();
            Assert.AreEqual(expected, actual.Message);
        }

        /// <summary>
        /// test case 4.1
        /// proper className should return true 
        /// </summary>
        [Test]
        public void GivenMoodAnalysisClassName_WhenAnalyse_ShouldReturn_MoodAnalysisObject()
        {
            MoodAnalyser ma = new MoodAnalyser();      
            var obj= MoodAnalyzerReflection.MoodAnalyserReflection("MoodAnalyser");   
            var actual = ma.Equals(obj);            
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// test case 4.2
        /// Improper class name should return custom exception
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_shouldThrowException()
        {            
            object actual = MoodAnalyzerReflection.MoodAnalyserReflection("improper");
            object expected = State.NO_SUCH_CLASS_ERROR.ToString();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.3
        /// wrong constructor parameter
        /// </summary>
        [Test]
        public void GivenClassWhenConstructorNotProper_WhenAnalysis_ThrowException()
        {
            var actual = Assert.Throws<MoodAnalyserException>(()=>MoodAnalyzerReflection.MoodAnalyserReflection("MoodAnalyser", new object[] { 123 }));
            object expected = State.NO_SUCH_METHOD_ERROR.ToString();
            Assert.AreEqual(expected,actual.Message);
        }

        /// <summary>
        /// test case 5.1
        /// proper className with parameter constructor should return true 
        /// </summary>
        [Test]
        public void GivenMoodAnalysis_WhenProper_ShouldReturn_MoodAnalysisObject()
        {
            MoodAnalyser Ma = new MoodAnalyser("I am in happy mood");
            object obj=MoodAnalyzerReflection.MoodAnalyserReflection("MoodAnalyser", new object[] { "I am in happy mood" });
            var actual = Ma.Equals(obj);
            Assert.IsTrue(actual);
        }
    }
}