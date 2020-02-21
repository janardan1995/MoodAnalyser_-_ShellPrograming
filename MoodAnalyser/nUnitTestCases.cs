// --------------------------------------------------------------------------------------------------------------------
// <copyright file="nUnitTestCase.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// this is the the nunit testing 
/// </summary>
namespace NUnitTestMoodAnalyser
{
    using NUnit.Framework;
    using Class1;

    /// <summary>
    /// a Tests class is created
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// this is the first method to test for analysis mood should return sad
        /// </summary>
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
         
        /// <summary>
        /// this method should return happy if the string message has no sad word
        /// </summary>
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

        /// <summary>
        /// created a constructor in origin program 
        /// here we have testing for sad 
        /// </summary>
        [Test]
        public void GivenSadMessaageInConstructor_WhenAnalysis_ShouldReturnSad()
        {
            string expected = "sad";
            MoodAnalyser ma =new MoodAnalyser("I am in sad Mood");

            string x1 = ma.AnalysisMoodFunctionWithConstructor();
            Assert.AreEqual(expected, x1);

        }
        
        /// <summary>
        /// created a constructor and should pass happy
        /// </summary>
        [Test]
        public void GivenExceptSadMessaageInConstructor_WhenAnalysis_ShouldReturnHappy()
        {
            string expected = "Happy";

            MoodAnalyser ma =new MoodAnalyser("I am in Happy Mood");
            string x2 = ma.AnalysisMoodFunctionWithConstructor();
            Assert.AreEqual(expected, x2);

        }
    }
}