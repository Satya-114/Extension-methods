using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_methods
{
    static class Stat_class
    {
        public static void Test3(this Program p, int i)
        {
            Console.WriteLine("Method 3:" +i);
        }
        public static long Factorial(this Int32 x)
        {
            if(x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);

        }
        public static string ToProper(this string Oldstr)
        {
            if(Oldstr.Trim().Length > 0)
            {
                string Newstr = null;
                Oldstr = Oldstr.ToLower();
                string[] sarr = Oldstr.Split(' ');
                foreach(string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = char.ToUpper(carr[0]);
                    if (Newstr == null)

                        Newstr = new string(carr);
                    else
                        Newstr += " " +new string(carr);

                }
                return Newstr;

            }
            return Oldstr;
        }
    }
}
