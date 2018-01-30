using System;

namespace Super_Reduced_String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //string result = SuperReduceString(s);
            //Console.WriteLine(result);
            Console.ReadLine();
        }

        public string SuperReduceString(string s)
        {
            string reducedString = "";

            FillReducedString(s, ref reducedString);
            
            if (reducedString.Length == 0)
                return "Empty String";

            return reducedString;
        }

        static bool IsEmpty(string s)
        {
            if (s.Length == 0)
                return true;

            return false;
        }
        static int CountChar(string s, string charactere, ref int count, int i)
        {
            for (int j = i; j < s.Length; j++)
            {
                if (charactere != s[j].ToString())
                {
                    break;
                }

                count++;
            }
            return count;

        }
        static string FillReducedString(string s, ref string reducedString)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (reducedString.Length != 0 && reducedString[reducedString.Length - 1] == s[j])
                {
                    reducedString = reducedString.Remove(reducedString.Length - 1);
                    continue;
                }

                reducedString += s[j];

            }


            return reducedString;
        }
    }
}
