using System;
using System.Linq;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }
}