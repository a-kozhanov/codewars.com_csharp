/*
https://www.codewars.com/kata/597770e98b4b340e5b000071/csharp

6 kyu
extract file name

You have to extract a portion of the file name as follows:

Assume it will start with date represented as long number
Followed by an underscore
You'll have then a filename with an extension
it will always have an extra extension at the end
Inputs:
1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION

1_This_is_an_otherExample.mpg.OTHEREXTENSIONadasdassdassds34

1231231223123131_myFile.tar.gz2
Outputs
FILE_NAME.EXTENSION

This_is_an_otherExample.mpg

myFile.tar
Acceptable characters for random tests:

abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-0123456789

The recommended way to solve it is using RegEx and specifically groups.
*/

using System.IO;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataExtractFileName
    {
        public static string ExtractFileName(string dirtFileName)
        {
            //return dirtFileName.Substring(dirtFileName.IndexOf("_") + 1, dirtFileName.LastIndexOf(".") - dirtFileName.IndexOf("_") - 1);
            //return Regex.Match(dirtFileName, @"\d+_([a-zA-Z_-]+\.[a-zA-Z_-]+)").Groups[1].Value;
            //return Path.GetFileNameWithoutExtension(dirtFileName).Split('_', 2)[1];
            //return Regex.Match(dirtFileName, "[_](.+)[.]").Groups[1].Value;
            //return Regex.Match(dirtFileName, @"(?<=_).+(?=\.)").Value;
            //return Regex.Replace(dirtFileName, @"\d*_(.*)\..*", "$1");
            //return Regex.Replace(dirtFileName, @"\d*_(.+)\..*", "$1");
            //return Regex.Split(dirtFileName, @"^\d+_|\.\w+$")[1];
            //return Regex.Split(dirtFileName, @"\d*_(.*)\..*")[1];
            //return Regex.Split(dirtFileName, @"\d*_(.+)\..*")[1];
            //return Regex.Split(dirtFileName, @"_(.*)\.")[1];
            //return Regex.Match(dirtFileName, @"\\_(.*)\.").Value;

            return dirtFileName[(dirtFileName.IndexOf('_') + 1) .. dirtFileName.LastIndexOf('.')];
        }
    }
}