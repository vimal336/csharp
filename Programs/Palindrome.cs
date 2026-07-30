using System;
using System.Linq;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }
}