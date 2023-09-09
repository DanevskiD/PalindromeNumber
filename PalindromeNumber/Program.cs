using System;
using System.Runtime.InteropServices;

namespace PalindromeNumber
{
    public class Solution
    {
        //public bool IsPalindrome(int x)
        //{
        //    if (x < 0) 
        //        return false;
        //    string s = x.ToString();
        //    int l = 0;
        //    int t = s.Length - 1;
        //    while (l< t) 
        //    {
        //        if (s[l++] != s[t--]) 
        //            return false;
        //    }
        //    return true;
        //}

        public bool IsPalindrome(int x)
        {
            return x < 0 ? false : Reverse(x) == x;
        }

        public int Reverse(int x)
        {
            int ret = 0;
            while(x!=0) 
            {
                int digit =x % 10;
                int tmp = ret * 10;
                if (tmp / 10 != ret)
                    return 0;

                tmp += digit;
                ret = tmp;
                x = x / 10;
            }
            return ret;
        }
    }
}