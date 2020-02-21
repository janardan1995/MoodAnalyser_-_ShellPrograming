using NUnit.Framework;
using Class1;
namespace NUnitTestMoodAnalyser
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
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
        public void GivenAnyMesageExceptSad_WhenAnalyse_ShouldReturnHappy()
        {
            ////arrange
            string str = "I am in any mood";
            string excepted = "Happy";
            //act
            string match2 = MoodAnalyser.AnalysisMoodFunction(str);
            //Assert
            Assert.AreEqual(excepted, match2);
        }

        [Test]
        public void GivenAnyMessaageInConstructor_WhenAnalysis_ShouldReturnSad()
        {
           // string str = "any sad meaasage";
            string expected = "sad";

            MoodAnalyser ma =new MoodAnalyser("I am in sad Mood");
            string x = ma.AnalysisMoodFunctionWithConstructor();
            Assert.AreEqual(expected, x);

        }
    }
}