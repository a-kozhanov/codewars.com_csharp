/*
https://www.codewars.com/kata/5a6d3bd238f80014a2000187/csharp

7 kyu
Cat Years, Dog Years (2)

This is related to my other Kata about cats and dogs.

Kata Task
I have a cat and a dog which I got as kitten / puppy.
I forget when that was, but I do know their current ages as catYears and dogYears.
Find how long I have owned each of my pets and return as a list [ownedCat, ownedDog]

NOTES:

Results are truncated whole numbers of "human" years
Cat Years
15 cat years for first year
+9 cat years for second year
+4 cat years for each year after that
Dog Years
15 dog years for first year
+9 dog years for second year
+5 dog years for each year after that
References

http://www.catster.com/cats-101/calculate-cat-age-in-cat-years
http://www.slate.com/articles/news_and_politics/explainer/2009/05/a_dogs_life.html

*/

using System;

namespace CodeWars
{
    public class CatYearsDogYears2
    {
        public static (int, int) OwnedCatAndDog(int catYears, int dogYears)
        {
            // var cat = catYears >= 15 ? 1 : 0;
            // cat += catYears - 15 >= 9 ? 1 : 0;
            // cat += catYears - 15 - 9 >= 4 ? (catYears - 15 - 9) / 4 : 0;
            // var dog = dogYears >= 15 ? 1 : 0;
            // dog += dogYears - 15 >= 9 ? 1 : 0;
            // dog += dogYears - 15 - 9 >= 5 ? (dogYears - 15 - 9) / 5 : 0;
            // return (cat, dog);

            // var ownedCat = catYears < 15 ? 0 : catYears < 24 ? 1 : (catYears - 24) / 4 + 2;
            // var ownedDog = dogYears < 15 ? 0 : dogYears < 24 ? 1 : (dogYears - 24) / 5 + 2;
            // return (ownedCat, ownedDog);

            return (catYears < 15 ? 0 : catYears < 24 ? 1 : (catYears - 24) / 4 + 2,
                dogYears < 15 ? 0 : dogYears < 24 ? 1 : (dogYears - 24) / 5 + 2);
        }
    }
}