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
            var expected = MoodAnalyserProject.State.NULL.ToString();
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
        /// proper className should return true 
        /// </summary>
        [Test]
        public void GivenMoodAnalysisClassName_ShoulsReturn_MoodAnalysisObject()
        {
            var Object1 = CreateMoodFactory.CreateMoodAnalyserReflection("MoodAnalyser");
            var Object2 = CreateMoodFactory.CreateMoodAnalyserObject();
            var actual = Object1.Equals(Object2);
            var excepted = true;
            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// Improper class name should throw MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenImproperClassName_ShouldThreough_MoodAnalysisException()
        {
            var Object1 = CreateMoodFactory.CreateMoodAnalyserObject();
            var Object2 = CreateMoodFactory.CreateMoodAnalyserReflection("Improper class name");
            var actual = Object1.Equals(Object2);
            var excepted = false;
            Assert.AreEqual(excepted, actual);
            //var x = Assert.Throws<MoodAnalyserException>(() => CreateMoodFactory.CreateMoodAnalyserReflection("jdtf"));
            //Assert.AreEqual("NO_SUCH_CLASS_ERROR", x.ToString());
        }

        /// <summary>
        /// here the class name is proper but the constructor is improper
        /// </summary>
        [Test]
        public void GivenImproperConstructor_shouldThrowException()
        {
            var object1 = CreateMoodFactory.CreateMoodAnalyserObject();
            var object2 = CreateMoodFactory.CreateMoodAnalyserImproperConstructor("MoodAnalyser");
            var actual = object1.Equals(object2);
            var excepted = false;
            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// using reflection for parameter constructor should return mood analyser object
        /// </summary>
        [Test]
        public void GivenMoodSAnalyserWhenProper_ReturnMoodAnalyserObject()
        {
            MoodAnalyser MA = new MoodAnalyser("I am in sad mood");
            var object1 = CreateMoodFactory.CreateMoodAnalyserReflectionParameter("MoodAnalyser");
            var actual = MA.Equals(object1);            
            Assert.IsTrue(actual);
        }

      
    }
}