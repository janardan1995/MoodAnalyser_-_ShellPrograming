using NUnit.Framework;
using Class1;
namespace NUnitTestMoodAnalyser
{
    public class Tests
    {       
        [Test]
        public static void Giving_IaminSadMood_whenAnalysis_should_return_sad()
        {
            //arrange
            string str = "I am in sad mood";
            string excepted = "Sad mood";

            //act
            string match1 = MoodAnalyser.AnalysisMoodFunction(str);

            //Assert
            Assert.AreEqual(excepted, match1);
        }
    }
}