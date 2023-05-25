using System;

namespace Text
{
    ///<summary>Str class</summary>
    public static class Str
    {
        ///<summary> Check if a string is a palindrome</summary>
        ///<param name="s">string to check</param>
        ///<return>True if palindrome, False if not</return>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s == "")
                return true;
            s = s.ToLower();
            s = s.Replace(" ", "").Replace(".", "").Replace(":", "").Replace(",", "").Replace("?", "").Replace("!", "");
            for (int i = 0; i < s.Length - (i + 1); i++)
            {
                if (s[i] != s[s.Length - (i + 1)])
                    return false;
            }
            return true;
        }

    }
}