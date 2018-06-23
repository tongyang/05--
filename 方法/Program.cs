using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = GetMax(1, 11);
            Console.WriteLine(max);
        }

        /// <summary>
        /// 比较传入的两个整数的最大值，并返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回最大值</returns>
        static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
