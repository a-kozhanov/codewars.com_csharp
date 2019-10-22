

//https://www.codewars.com/kata/sleigh-authentication/train/csharp
//https://www.codewars.com/kata/52adc142b2651f25a8000643/solutions/csharp

//8 kyu
//Sleigh Authentication


//Christmas is coming and many people dreamed of having a ride with Santa's sleigh.
//But, of course, only Santa himself is allowed to use this wonderful transportation.
//And in order to make sure, that only he can board the sleigh, there's an authentication mechanism.

//Your task is to implement the authenticate() method of the sleigh,
//which takes the name of the person, who wants to board the sleigh and a secret password.
//If, and only if, the name equals "Santa Claus" and the password is "Ho Ho Ho!"
//(yes, even Santa has a secret password with uppercase and lowercase letters and special characters :D),
//the return value must be true. Otherwise it should return false.

//Examples:

//var sleigh = new Sleigh();
//sleigh.authenticate("Santa Claus", "Ho Ho Ho!"); // must return TRUE

//sleigh.authenticate("Santa", "Ho Ho Ho!"); // must return FALSE
//sleigh.authenticate("Santa Claus", "Ho Ho!"); // must return FALSE
//sleigh.authenticate("jhoffner", "CodeWars"); // Nope, even Jake is not allowed to use the sleigh ;)

namespace CodeWars
{
    public class SleighAuthentication
    {
        public static bool Authenticate(string name, string password)
        {
            return name == "Santa Claus" && password == "Ho Ho Ho!";
        }


        //public static bool Authenticate(string name, string password) => name == @"Santa Claus" && password == @"Ho Ho Ho!";

        //public static bool Authenticate(string name, string password)
        //{
        //    return Equals(name, "Santa Claus") & Equals(password, "Ho Ho Ho!");
        //}


    }
}