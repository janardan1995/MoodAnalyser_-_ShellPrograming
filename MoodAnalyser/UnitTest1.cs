// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// testing project for mood analyser
/// </summary>
namespace NUnitTestProject
{
    using NUnit.Framework;
    using MoodAnalyserProject;

    /// <summary>
    /// this is our test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Given a message that contains sad should return sad
        /// </summary>
        [Test]
        public void GivenMessage_ShouldReturnSad()
        {
            MoodAnalyser MA = new MoodAnalyser("i am in sad mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected = "SAD";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given any message except the word sad should return happy
        /// </summary>
        [Test]
        public void GivenMessage_ShoulReturnHappy()
        {
            MoodAnalyser ma = new MoodAnalyser("i am in any mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected = "HAPPY";
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// if our message is null then it throw caustom exception
        /// </summary>
        [Test]
        public void GivenNullMessage_shouldThrowException()
        {
            MoodAnalyser ma = new MoodAnalyser(null);
            var actual = Assert.Throws<MoodAnalyserException>(() => MoodAnalyser.AnalyseMood());
            var expected = MoodAnalyserProject.State.NULL_REFERENCE_ERROR.ToString();
            Assert.AreEqual(expected, actual.Message);
        }

        /// <summary>
        /// if the given message is empty it throw custom exception
        /// </summary>
        [Test]
        public void GivenEmptyMessage_shouldReturnException()
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
        public void GivenMoodAnalysisClassName_ShouldReturn_MoodAnalysisObject()
        {
            MoodAnalyser ma = new MoodAnalyser();
            var obj= MoodAnalyserFactory.MoodAnalyserReflection("MoodAnalyser");           
            var actual = ma.Equals(obj);
            var excepted = true;
            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// test case 4.2
        /// Improper class name should return custom exception
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_shouldThrowException()
        {
           // var actual = MoodAnalyserFactory.MoodAnalyserReflection("improper class name");
            var actual = Assert.Throws<MoodAnalyserException>(() => MoodAnalyserFactory.MoodAnalyserReflection("improper"));
            var expected =State.NO_SUCH_CLASS_ERROR.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 5.1
        /// proper className with parameter constructor should return true 
        /// </summary>
        [Test]
        public void GivenMoodAnalysisWhenProper_ShouldReturn_MoodAnalysisObject()
        {
            MoodAnalyser ma = new MoodAnalyser();
            var obj = MoodAnalyserFactory.MoodAnalyserReflection("MoodAnalyser","I am in Happy mood");
            var actual = ma.Equals(obj);
            var excepted = true;
            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// test case 5.2
        /// Improper class name with proper constructor should return custom exception
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_shouldThrowCustomException()
        {            
            var actual = Assert.Throws<MoodAnalyserException>(() => MoodAnalyserFactory.MoodAnalyserReflection("improper","I am in sad mood"));
            var expected = State.NO_SUCH_CLASS_ERROR.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// when constructor parameter is improper , it returns exception 
        /// </summary>
        [Test]
        public void GivenClassWhenConstructorNotProper_ShouldThrowException()
        {
            var actual =Assert.Throws<MoodAnalyserException>(()=> MoodAnalyserFactory.MoodAnalyserReflection("MoodAnalyser",123));           
            var expected = State.NO_SUCH_METHOD_ERROR.ToString();
            Assert.AreEqual(actual.Message, expected);
        }       
    }
}