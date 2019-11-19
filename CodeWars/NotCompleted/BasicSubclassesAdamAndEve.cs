/*
https://www.codewars.com/kata/basic-subclasses-adam-and-eve/train/csharp


8 kyu
Basic subclasses - Adam and Eve

According to the creation myths of the Abrahamic religions, Adam and Eve were the first Humans to wander the Earth.
You have to do God's job. The creation method must return an array of length 2 containing objects (representing Adam and Eve). 
The first object in the array should be an instance of the class Man. The second should be an instance of the class Woman. 
Both objects have to be subclasses of Human. Your job is to implement the Human, Man and Woman classes.
*/

using System;

namespace CodeWars
{

    public abstract class BasicSubclassesAdamAndEve
    {

        public class Human
        {
            public static explicit operator Human(Man v)
            {
                throw new NotImplementedException();
            }

            public static explicit operator Human(Woman v)
            {
                throw new NotImplementedException();
            }
        }

        public class Man { }

        public class Woman { }

        public static Human[] Create()
        {
            // TODO: Return an array containing a Man and Woman
            Man man = new Man();
            Woman woman = new Woman();

            return new[] { (Human)new Man(), (Human)new Woman() };
        }
    }

}