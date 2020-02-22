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
           
            string excepted = "HAPPY";
            MoodAnalyser MA = new MoodAnalyser("I am in any mood");
            string match2 = MA.AnalyseMood();
            Assert.AreEqual(excepted, match2);
        } 
        
        [Test]
        public void GivennullMesage_WhenAnalyse_ShouldReturnHappy()
        {
            string expected = "HAPPY";
            MoodAnalyser MA = new MoodAnalyser();
            string match3 = MA.AnalyseMood();
            Assert.AreEqual(expected, match3);
        }
    }
}