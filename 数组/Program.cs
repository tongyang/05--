using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一个练习
            int[] nums = {1, 2, 3, 4, 5, 0, 6, 2, 55};
            int max = nums[0];
            int min = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
                if (min > nums[i])
                {
                    min = nums[i];
                }
                sum += nums[i];
            }

            int avg = sum / nums.Length;

            Console.WriteLine("最小值：{0}  最大值：{1}  总和：{2}  平局值：{3}", min, max, sum, avg);
            #endregion

            #region 第二个练习

            string[] strs = {"我", "是", "好人"};
            // 注意不要循环那么多次，循环数组长度/2就可以了，循环Length，会又交换回来
            for (int i = 0; i < strs.Length / 2; i++)
            {
                string temp = strs[i];
                strs[i] = strs[strs.Length - 1 - i];
                strs[strs.Length - 1 - i] = temp;
            }


            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i]);
            }

            #endregion
        }
    }
}
