using System;
using System.Linq;
namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int a = 0;
            for (int i = 1; i < 11; i++)
            {
                if (nums.Contains(i))
                {

                }
                else
                {
                    a = i;
                }
                

            }
            return a;
        }
    }
}
