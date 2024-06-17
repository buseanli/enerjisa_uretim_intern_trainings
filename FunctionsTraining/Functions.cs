using System;

public class Answer
{
    // Change these Boolean values to control whether you see
    // the expected result and/or hints.
    public static bool ShowExpectedResult = false;
    public static bool ShowHints = false;

    // Determine whether a string is a Palindrome
    public static bool IsPalindrome(string thestr)
    {
        // Your code goes here.
        thestr = thestr.Replace("!", "").Replace(" ", "").Replace(",", "").Replace("'", "").Replace(".", "");
        thestr = thestr.ToLower();

        for (int j = 0; j < thestr.Length; j++)
        {
            if (thestr[j] != thestr[thestr.Length - j - 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
        int palcount = 0;
        foreach (string str in teststrings)
        {
            bool learnerResult = Answer.IsPalindrome(str);
            if (learnerResult)
                palcount++;
        }
    }
}