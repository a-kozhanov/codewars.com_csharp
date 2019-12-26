/*
https://www.codewars.com/kata/playing-with-cubes-ii/train/csharp
https://www.codewars.com/kata/55c0ac142326fdf18d0000af/solutions/csharp

8 kyu
Playing with cubes II

Hey Codewarrior!
You already implemented a Cube class, but now we need your help again! I'm talking about constructors. 
We don't have one. Let's code two: One taking an integer and one handling no given arguments!
Also we got a problem with negative values. Correct the code so negative values will be switched to positive ones!
The constructor taking no arguments should assign 0 to Cube's Side property.
*/

using System;

namespace CodeWars
{
    public class PlayingWithCubesII
    {
        private int _side;
        public int GetSide() => _side;
        public void SetSide(int s) => _side = Math.Abs(s);
        //public Cube(int side = 0) => _side = Math.Abs(side);
        public PlayingWithCubesII(int side = 0) => _side = Math.Abs(side);
    }
}


//public class Cube
//{
//    private int Side;

//    //This cube needs your help. 
//    //Define a constructor which takes one integer and assignes its value to 'Side'
//    public Cube(int s)
//    {
//        SetSide(s);
//    }

//    public Cube()
//        : this(0)
//    {

//    }
//    public int GetSide()
//    {
//        return Side;
//    }

//    public void SetSide(int s)
//    {
//        Side = System.Math.Abs(s);
//    }
//}


//public class Cube {
//    private int Side;
//    public Cube() {}
//    public Cube(int s) {
//        SetSide(s);
//    }
//    public int GetSide() {
//        return Side;
//    }
//    public void SetSide(int s) {
//        Side = Abs(s);
//    }
//}


//public class Cube
//{
//    private int Side;
//    public Cube()
//    {
//        this.Side = 0;
//    }
//    public Cube(int s)
//    {
//        this.Side = Math.Abs(s);
//    }
//    public int GetSide() => this.Side;
//    public void SetSide(int s) => this.Side = Math.Abs(s);
//}


//public class Cube
//{
//    private Int32 _side;

//    public Cube(Int32 Side = 0){
//        SetSide(Side);
//    }

//    public Int32 GetSide()
//    {
//        return this._side;
//    }

//    public void SetSide(Int32 Side)
//    {
//        this._side = Math.Abs(Side);
//    }
//}


//public class Cube {
//    private int Side;
//    public Cube(int s = 0) => this.Side = s < 0 ? -s : s;
//    public int GetSide() => this.Side;
//    public void SetSide(int s) => this.Side = s < 0 ? -s : s;
//}

