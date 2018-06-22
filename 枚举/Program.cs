using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    //public enum Seasons
    //{
    //    春,
    //    夏,
    //    秋,
    //    冬
    //}

    enum State
    {
        在线 = 1,
        离线,
        离开,
        忙碌,
        Q我
    }

    class Program
    {
        static void Main(string[] args)
        {
            //String s = "asdas";
            //try
            //{
            //    Seasons season = (Seasons)Enum.Parse(typeof(Seasons), s);
            //    Console.WriteLine(season);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            Console.WriteLine("请选择您的QQ在线状态：1--在线 2--离线 3--离开 4--忙碌 5--Q我");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    print(input);
                    break;

                case "2":
                    print(input);
                    break;
                case "3":
                    print(input);
                    break;
                case "4":
                    print(input);
                    break;
                case "5":
                    print(input);
                    break;

                default:
                    break;
            }


        }

        static void print(string input)
        {
            try
            {
                State state = (State)Enum.Parse(typeof(State), input);
                Console.WriteLine("您选择的在线状态为：{0}", state);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
