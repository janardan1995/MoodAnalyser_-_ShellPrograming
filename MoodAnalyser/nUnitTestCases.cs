// --------------------------------------------------------------------------------------------------------------------
// <copyright file="nUnitTestCase.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace NUnitTestMoodAnalyser
{
    using NUnit.Framework;
    using Class1;

    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string excepted = "SAD";
            MoodAnalyser MA = new MoodAnalyser("I am in sad mood");
            string match1 = MA.AnalyseMood();
            Assert.AreEqual(excepted, match1);
        }

        [Test]
        public void GivenAnyMesageExceptSad_WhenAnalyse_ShouldReturnHappy()
        {

            string expected = "HAPPY";
            MoodAnalyser MA = new MoodAnalyser("I am in any mood");
            string match2 = MA.AnalyseMood();
            Assert.AreEqual(expected, match2);
        }

        //[Test]
        //public void GivenNullMesage_WhenAnalyse_ShouldReturnHappy()
        //{
        //    string expected = "HAPPY";
        //    MoodAnalyser MA = new MoodAnalyser(null);
        //    string match3 = MA.AnalyseMood();
        //    Assert.AreEqual(expected, match3);
        //}

        [Test]
        public void GivenNullMessage_WhenAnalysis_ShouldThrowMoodAnalysisException()
        {
            MoodAnalyser MA = new MoodAnalyser(null);
            var ex = Assert.Throws<MoodAnalysisException>(() => MA.AnalyseMood());
            Assert.That(ex.Message, Is.EqualTo("null message"));
            //Assert.AreEqual("null message", ex.Message);         

        }

         [Test]
        public void GivenEmptyMessage_WhenAnalysis_ShouldThrowMoodAnalysisException()
        {
            MoodAnalyser MA = new MoodAnalyser("");
            var ex = Assert.Throws<MoodAnalysisException>(() => MA.AnalyseMood());
            Assert.That(ex.Message, Is.EqualTo("empty message"));
            //Assert.AreEqual("null message", ex.Message);         

        }

        [Test]
        public void ReflectionTest()
        {
           MoodAnalyser obj1 = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser");
            object obj2 = MoodAnalyser.ReflectionMethod();
            Assert.AreEqual(obj1.GetType().ToString(),obj2);
        }


    }
}