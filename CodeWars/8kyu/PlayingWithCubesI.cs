

//https://www.codewars.com/kata/playing-with-cubes-i/train/csharp
//https://www.codewars.com/kata/55c0a79e20be94c91400014b/solutions/csharp

//Playing with cubes I
//8 kyu

//Create a public class called Cube without a constructor which gets one single private Integer variable Side,
//a getter GetSide() and a setter SetSide(int num) method for this property. Actually,
//getter and setter methods are not the common way to write this code in C#. In the next kata of this series,
//we gonna refactor the code and make it a bit more professional... Note: There's no need to check for negative values!

namespace CodeWars
{
    public class Cube
    {
        private int Side { get; set; } = 0;

        public int GetSide()
        {
            return Side;
        }

        public void SetSide(int value)
        {
            Side = value;
        }
    }


    //public class Cube
    //{

    //    private int side = 0;

    //    public int GetSide() { return side; }

    //    public void SetSide(int num) { side = num; }

    //}


    //public class Cube
    //{
    //    private int m_side = 0;

    //    public int GetSide() => m_side;
    //    public void SetSide(int value) => m_side = value;
    //}


    //public class Cube
    //{
    //    private int _side = 0;

    //    public int GetSide()
    //    {
    //        return this._side;
    //    }

    //    public void SetSide(int side)
    //    {
    //        this._side = side;
    //    }
    //}


    //public class Cube{
    //    public int side=0;
    //    public void SetSide(int s) {side=s;}
    //    public int GetSide() {return side;}
    //}



}