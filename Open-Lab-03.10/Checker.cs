using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int b = 0;
            foreach (char a in str)
            {
                if (a == letter)
                    b = b + 1;
               

            }
            return b;
             
        }
    }
}
