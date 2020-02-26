using NUnit.Framework;
using MoodAnalyserProject;
namespace NUnitTestProject
{
    public class Tests
    {       
        [Test]
        public void GivenMessage_ShouldReturnSad()
        {
            MoodAnalyser MA = new MoodAnalyser("i am in sade mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected = "SAD";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GivenMessage_ShoulReturnHappy()
        {
            MoodAnalyser ma = new MoodAnalyser("i am in any mood");
            var actual = MoodAnalyser.AnalyseMood();
            var expected="HAPPY";
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GivenNullMessage_shouldThrowException()
        {
            MoodAnalyser ma = new MoodAnalyser(null);         
            var actual = Assert.Throws<MoodAnalyserException>(()=> MoodAnalyser.AnalyseMood());
            var expected = "null message";
            Assert.AreEqual(expected,actual.Message);
        }
        [Test]
        public void GivenEmptyMessage_shouldReturnException()
        {
            MoodAnalyser ma = new MoodAnalyser("");
            var actual = Assert.Throws<MoodAnalyserException>(()=>MoodAnalyser.AnalyseMood());
            var expected = "empty message";
            Assert.AreEqual(expected, actual.Message);
        }
        [Test]
        public void GivenMoodAnalysisClassName_ShoulsReturn_MoodAnalysisObject()
        {
            var obj1 = CreateMoodFactory.CreateMoodAnalyserObject();
            var obj2 = CreateMoodFactory.CreateMoodAnalyserReflection("MoodAnalyserProject.MoodAnalyser");
            var expected = true;
            var actual = obj1.Equals(obj2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenImproperClassName_ShouldThreough_MoodAnalysisException()
        {
           // var obj1 = CreateMoodFactory.CreateMoodAnalyserObject();
            //var obj2 = CreateMoodFactory.CreateMoodAnalyserReflection("MoodAnalyser");
            var expected = "No Such Class Error";
            var actual = Assert.Throws<MoodAnalyserException>(()=> CreateMoodFactory.CreateMoodAnalyserReflection(""));
            Assert.AreEqual(expected, actual.Message);
        }
       
    }
}