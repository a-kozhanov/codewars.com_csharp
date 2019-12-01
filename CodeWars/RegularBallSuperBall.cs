/*
https://www.codewars.com/kata/regular-ball-super-ball/csharp
https://www.codewars.com/kata/regular-ball-super-ball/solutions/csharp

8 kyu
Regular Ball Super Ball

Create a class Ball.

Ball objects should accept one argument for "ball type" when instantiated.

If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

ball1 = new Ball();
ball2 = new Ball("super");

ball1.ballType     //=> "regular"
ball2.ballType     //=> "super"
*/

namespace CodeWars
{
    public class RegularBallSuperBall
    {
        public string ballType { get; }
        public RegularBallSuperBall(string ballType = "regular") => this.ballType = ballType;
    }

    //public class Ball
    //{
    //    public string ballType { get; private set; }

    //    public Ball(string ballType = "regular")
    //    {
    //        this.ballType = ballType;
    //    }
    //}



    //public class Ball {
    //    public string ballType { get; set; }

    //    public Ball(string ballType = "regular") {
    //        this.ballType = ballType;
    //    }
    //}


    //public class Ball {
    //    public string ballType { get; set; }

    //    public Ball(string ballType) {
    //        this.ballType = ballType;
    //    }

    //    public Ball(): this("regular"){}
    //}


}