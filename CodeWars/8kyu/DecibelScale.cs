

//https://www.codewars.com/kata/decibel-scale/train/csharp
//https://www.codewars.com/kata/5612a42e746aa62de100001a/solutions/csharp

//Decibel Scale
//8 kyu

//The following formula is called the Decibel Scale:
//Decibel Scale Formula
//The Decibel Scale is used to determine the loudness of a sound, measured in dB:
//β is the result we want, defined in dB;
//We multiply the result of the logarithmic operation by 10, otherwise it'll be called "Bel Scale";
//We provide I, the intensity of the sound wave we need to find the loudness of, which is, for the purposes of this Kata, measured in 2D space and, hence, in Watts per square meter;
//Finally, we divide the intensity by the threshold of human hearing, also measured in Watts per square meter. This is the softest possible sound a human ear can hear;
//Since the threshold of human hearing involves an extremely small, long number, we need to utilize a logarithmic operation that will provide us the result in a convenient way.
//Your task is to simply calculate the loudness of a sound wave, given its intensity as a parameter to the dBScale/db_scale function.
//Results are automatically rounded to the nearest integer by the test cases.

using System;

namespace CodeWars
{
    public class DecibelScale
    {
        public static double DbScale(double intensity)
        {
            return 10 * Math.Log10(intensity / Math.Pow(10, -12));
        }

        //public static double DbScale(double intensity)
        //{
        //    double answer = 10 * Math.Log10(intensity/1e-12);
        //    return answer;
        //}


        //public static double DbScale(double intensity) => 120 + 10 * Log10(intensity);


        //public static double DbScale(double intensity)
        //{
        //    return  10 * (12 + Math.Log10(intensity));
        //}


        //public static double DbScale(double i) => 10 * Math.Log10(i * 1e12);



        //public static double DbScale(double intensity)
        //{
        //    return 10 * System.Math.Log10(intensity * 1000000000000d);
        //}


        //public static double DbScale(double intensity)
        //{
        //    return 10*Math.Log10(intensity/.000000000001);
        //}


        //public static double DbScale(double intensity)
        //{
        //    return 10 * Math.Log(intensity / 0.000000000001, 10);
        //}

        //public static double DbScale(double intensity)
        //{
        //    return 10.0 * Math.Log10(intensity) + 120.0;    
        //}

    }
}