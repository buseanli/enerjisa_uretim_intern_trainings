using System;

class Program
{
    static void Main(string[] args)
    {
        string outstr;
        string str1 = "The quick brown fox jumps over the lazy dog.";
        string str2 = "banana";
        string str3 = "apple";
        string[] strs = { "one", "two", "three", "four" };
            outstr = String.Join("--", strs);
            Console.WriteLine(outstr);
            int result = String.Compare(str2, "a");
            Console.WriteLine(result);
            int result2 = String.Compare(str3, "i");
            Console.WriteLine(result2);
    }
    }