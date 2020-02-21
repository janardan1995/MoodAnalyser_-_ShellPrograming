using NUnit.Framework;
using Class1;
namespace NUnitTestMoodAnalyser
{
    public class Tests
    {
        [Test]
        public static void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            //arrange
            string str = "I am in sad mood";
            string excepted = "Sad mood";

            //act
            string match1 = MoodAnalyser.AnalysisMoodFunction(str);

            //Assert
            Assert.AreEqual(excepted, match1);
        }
         
        [Test]
        public static void GivienAnyMesageExceptSad_WhenAnalyse_ShouldReturnHappy()
        {
            ////arrange
            string str = "I am in any mood";
            string excepted = "Happy";
            //act
            string match2 = MoodAnalyser.AnalysisMoodFunction(str);
            //Assert
            Assert.AreEqual(excepted, match2);
        }
    }
}