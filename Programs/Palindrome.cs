using System.Linq;

public bool IsPalindrome(string s)
{
    // Reverses the string and compares it to the original sng
    return s.SequenceEqual(s.Reverse());
}
