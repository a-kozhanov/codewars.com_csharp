
/*
https://www.codewars.com/kata/broken-counter/train/csharp
https://www.codewars.com/kata/526471539d52735c620000c6/solutions/csharp

8 kyu
Broken Counter

Our counter prototype is broken. Can you spot, what's wrong here?
Counter.Value must have manually defined getter/setter methods, according to our company's style guide.

*/

namespace CodeWars
{
    public class BrokenCounter
    {
        private int _value;
        public int Value
        {
            get => _value;
            private set => _value = value;
        }

        public void Increase() => Value++;
        public void Reset() => Value = 0;
    }
}


//public class Counter
//{
//    private int _Value;
//    public int Value
//    {
//        get
//        {
//            return _Value;
//        }
//        private set
//        {
//            _Value = value;
//        }
//    }

//    public Counter()
//    {
//        Value = 0;
//    }

//    public void Increase()
//    {
//        Value++;
//    }

//    public void Reset()
//    {
//        Value = 0;
//    }
//}




//public class Counter
//{
//    private int val = 0;

//    public int Value
//    {
//        get
//        {
//            return val;
//        }
//        private set
//        {
//            val = value;
//        }
//    }

//    public Counter()
//    {
//        Value = 0;
//    }

//    public void Increase()
//    {
//        ++Value;
//    }

//    public void Reset()
//    {
//        Value = 0;
//    }
//}






