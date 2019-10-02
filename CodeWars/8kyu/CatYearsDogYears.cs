
//https://www.codewars.com/kata/cat-years-dog-years/train/csharp
//https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b/solutions/csharp

//Cat years, Dog years
//8 kyu

//Kata Task
//I have a cat and a dog.
//I got them at the same time as kitten/puppy. That was humanYears years ago.
//Return their respective ages now as [humanYears,catYears,dogYears]


//NOTES:
//humanYears >= 1
//humanYears are whole numbers only

//Cat Years
//15 cat years for first year
//+9 cat years for second year
//+4 cat years for each year after that

//Dog Years
//15 dog years for first year
//+9 dog years for second year
//+5 dog years for each year after that

//References
//http://www.catster.com/cats-101/calculate-cat-age-in-cat-years
//http://www.slate.com/articles/news_and_politics/explainer/2009/05/a_dogs_life.html

//If you liked this Kata there is another related one here


using System.Linq;

namespace CodeWars
{
    public class CatYearsDogYears
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            var catYears = 0;
            var dogYears = 0;

            for (var i = 1; i < humanYears + 1; i++)
            {
                switch (i)
                {
                    case 1:
                        catYears += 15;
                        dogYears += 15;
                        break;
                    case 2:
                        catYears += 9;
                        dogYears += 9;
                        break;
                    default:
                        catYears += 4;
                        dogYears += 5;
                        break;
                }
            }

            return new int[] { humanYears, catYears, dogYears };
        }

        //public static int[] humanYearsCatYearsDogYears(int humanYears) {

        //    int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears-2): 0);
        //    int dogYear = 15+ (humanYears >= 2 ? 9 + 5 * (humanYears-2): 0);

        //    return new int[]{humanYears,catYear ,dogYear};
        //}


        //public static int[] humanYearsCatYearsDogYears(int humanYears) => humanYears < 2 ? new int[]{1,15,15} : humanYears < 3 ? new int[]{2,24,24} : new int[]{humanYears,24+(humanYears-2)*4,24+(humanYears-2)*5};


        //public static int[] humanYearsCatYearsDogYears(int y) => y < 2 ? new[]{1, 15, 15} : new[]{y, 16+4*y, 14+5*y};


        //public static int[] humanYearsCatYearsDogYears(int humanYears)
        //{
        //    switch (humanYears)
        //    {
        //        case 1: return new[] {1, 15, 15};
        //        case 2: return new[] {2, 24, 24};
        //        default: return new[] {humanYears, (humanYears - 2) * 4 + 15 + 9, (humanYears - 2) * 5 + 15 + 9};
        //    }
        //}



        //public static int[] humanYearsCatYearsDogYears(int humanYears) =>
        //    new int[]{humanYears,(humanYears + 3)*4 + (humanYears > 1 ? 5 : 0) -1 ,(humanYears + 2)*5 + (humanYears > 1 ? 4 : 0)};


        //public static int[] humanYearsCatYearsDogYears(int humanYears)
        //{
        //    int catAge = (humanYears == 1) ? 15 : (humanYears == 2) ? 24 : 24 + ((humanYears - 2) * 4);
        //    int dogAge = (humanYears == 1) ? 15 : (humanYears == 2) ? 24 : 24 + ((humanYears - 2) * 5);

        //    return new int[] { humanYears, catAge, dogAge };
        //}


        //public static int[] humanYearsCatYearsDogYears(int humanYears)
        //{
        //    return new[]
        //    {
        //        humanYears,
        //        new[] {15,9}.Concat(Enumerable.Repeat(4, humanYears - 1)).Take(humanYears).Sum(),
        //        new[] {15,9}.Concat(Enumerable.Repeat(5, humanYears - 1)).Take(humanYears).Sum()
        //    };
        //}



    }
}