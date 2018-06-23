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
        }
    }
}
