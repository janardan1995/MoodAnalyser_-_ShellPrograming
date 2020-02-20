using System;
using Xunit;
using ClassLibrary2;

namespace XUnitTestRegistration
{
    public class UnitTest1
    {
        /// <summary>
        /// created test method for true cases in Name method
        /// </summary>
        [Fact]
        public void Name_Test2_forFalseValue()
        {
            //arrange
            var x1 = "";

            //act
            var y1 = Registration.Name(x1);

            //assert
            Assert.False(y1);
        }

        /// <summary>
        /// created false case for Name method
        /// </summary>        
        [Fact]
        public void NameTest2ForTrueValue()
        {
            var a = "Janardan";
            var b = Registration.Name(a);
            Assert.True(b);
        }

        /// <summary>
        /// creadted mobile method for true case
        /// </summary>
        [Fact]
        public void mobileNoforTruecase()
        {
            var x = 7578933815;
            var y = Registration.Mobile(x);
            Assert.True(y);
        }

        /// <summary>
        /// false cases for mobile no method
        /// </summary>
        [Fact]
        public void MobileNoforFalsecase()
        {
            double x = 1;
            var y = Registration.Mobile(x);
            Assert.False(y);
        }

        /// <summary>
        /// email address false cases
        /// </summary>
        [Fact]
        public void EmailAddressForFalseCase()
        {
            var x = "das#@!";
            var y = Registration.Email(x);
            Assert.False(y);
        }

         /// <summary>
        /// email address true cases
        /// </summary>
        [Fact]
        public void EmailforTruecase()
        {
           var x = "dasjanardan1995@gmail.com";
            var y = Registration.Email(x);
            Assert.True(y);
        }
        
        /// <summary>
        /// Password method Unit testing false case
        /// </summary>
        [Fact]
        public void PasswordForFalseCase()
        {
            var x = "das#@!";
            var y = Registration.Password(x);
            Assert.False(y);
        }

         /// <summary>
        /// true method for password true cases
        /// </summary>
        [Fact]
        public void PasswordforTruecase()
        {
           var x = "Janardan@11ergwewf@!@#$@@qqqq";
           var y = Registration.Password(x);
           Assert.True(y);
        }
    }
}
