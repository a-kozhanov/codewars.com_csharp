/*
https://www.codewars.com/kata/basic-subclasses-adam-and-eve/train/csharp
https://www.codewars.com/kata/547274e24481cfc469000416/solutions/csharp

8 kyu
Basic subclasses - Adam and Eve

According to the creation myths of the Abrahamic religions, Adam and Eve were the first Humans to wander the Earth.
You have to do God's job. The creation method must return an array of length 2 containing objects (representing Adam and Eve). 
The first object in the array should be an instance of the class Man. The second should be an instance of the class Woman. 
Both objects have to be subclasses of Human. Your job is to implement the Human, Man and Woman classes.
*/

namespace CodeWars
{
    public class Human { }
    public class Man : Human { }
    public class Woman : Human { }

    public class God
    {
        public static Human[] Create()
        {
            return new Human[] { new Man(), new Woman() };
        }
    }
}


//public class God
//{
//    public static Human[] Create() => new Human[] {new Man(), new Woman()};
//}
//public class Human {}
//public class Man : Human {}
//public class Woman : Human {}



//public class God
//{
//    public static Human[] Create()
//    {
//        Human Eva = new Woman();
//        Human Adam = new Man();
//        return new Human[2] { Adam, Eva };
//    }
//}

//public class Human
//{
//}

//class Woman : Human
//{ 
//}

//class Man : Human
//{ 
//}






//public class God
//{
//    public static Human[] Create()
//    {
//        // TODO: Return an array containing a Man and Woman
//        Human[] people = new Human[2] {new Man(), new Woman()};
//        return people;
//    }
//}

//public class Human
//{
//}

//public class Man : Human
//{
//}

//public class Woman : Human
//{
//}




//public class Human{}
//public class Man:Human{}
//public class Woman:Human{}
//public class God
//{

//    public static Human[] Create()
//    {
//        Human Adam = new Man();
//        Human Eve = new Woman();
//        Human[] Array = {Adam, Eve};
//        return Array;
//        // TODO: Return an array containing a Man and Woman
//    }
//}




//public class Human {}
//public interface Man {}
//public interface Woman {}
//public class Intersex : Human, Man, Woman { }

//public class God
//{
//    public static Human[] Create() => Creation;
//    private static readonly Human[] Creation = { new Intersex(), new Intersex() } ;
//}






