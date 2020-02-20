using System;
using System.Text.RegularExpressions;

namespace ClassLibrary2
{   
        public class Registration
        {
            public static bool Name(string str)
            {                
                string pattern = @"^[A-Z]{1}[a-z]{2,}$";
                Regex rg = new Regex(pattern);
                if (rg.IsMatch(str))
                {
                    return true;
                }
                    return false; 
                    
            }
            public static bool Mobile(double x)
            {       
                string pattern = @"^[6-9]{1}[0-9]{9}$";
                Regex rg = new Regex(pattern);
                if (rg.IsMatch(x.ToString()))
                {
                    Console.WriteLine("valid");
                    return true;
                }
                        return false; 
                    
            }
            public static bool Email(string str)
            {
                string pattern = @"^([A-Za-z0-9]+)@([a-zA-z]+)\.([a-zA-Z]{2,5})$";
                Regex re = new Regex(pattern);
                if (re.IsMatch(str))
                {
                    return true;
                }
                   return false;
            }
            public static bool Password(string str)
            {
                string pattern=@"^.*(?=.{8,})(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?!.\s).*$";
                Regex reg = new Regex(pattern);
                if (reg.IsMatch(str))
                {
                    return true;
                }

                return false;
            }

        }

}
   

