/*
https://www.codewars.com/kata/55b75fcf67e558d3750000a3/csharp

7 kyu
Building blocks

Write a class Block that creates a block (Duh..)

##Requirements

The constructor should take an array as an argument, 
this will contain 3 integers of the form [width, length, height] from which the Block should be created.

Define these methods:

`GetWidth()` return the width of the `Block`

`GetLength()` return the length of the `Block`

`GetHeight()` return the height of the `Block`

`GetVolume()` return the volume of the `Block`

`GetSurfaceArea()` return the surface area of the `Block`
##Examples

    Block b = new Block(new int[]{2,4,6}) -> creates a `Block` object with a width of `2` a length of `4` and a height of `6`
    b.GetWidth() // -> 2
    
    b.GetLength() // -> 4
    
    b.GetHeight() // -> 6
    
    b.GetVolume() // -> 48
    
    b.GetSurfaceArea() // -> 88
Note: no error checking is needed

Any feedback would be much appreciated
*/

using System;

//using System.Collections.Generic;

namespace CodeWars
{
    public class BuildingBlocks
    {
        public class Block
        {
            private readonly int _width;
            private readonly int _length;
            private readonly int _height;

            public Block(int[] args)
            {
                _width = args[0];
                _length = args[1];
                _height = args[2];
            }

            public int GetWidth() => _width;
            public int GetLength() => _length;
            public int GetHeight() => _height;
            public int GetVolume() => _width * _length * _height;
            public int GetSurfaceArea() => 2 * (_width * _length + _length * _height + _height * _width);
        }
    }
}