using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    struct Person
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }

    enum Gender
    {
        男,
        女
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyColor myColor;
            myColor._blue = 0;
            myColor._green = 0;
            myColor._red = 255;
            //showColor(myColor);

            Person zhangsan;
            zhangsan._name = "张三";
            zhangsan._gender = Gender.男;
            zhangsan._age = 18;
            Console.WriteLine("{0} {1} {2}岁", zhangsan._name, zhangsan._gender, zhangsan._age);


            Person xiaolan;
            xiaolan._name = "小兰";
            xiaolan._gender = Gender.女;
            xiaolan._age = 16;
            Console.WriteLine("{0} {1} {2}岁", xiaolan._name, xiaolan._gender, xiaolan._age);
        }

        static void showColor(MyColor myColor)
        {
            if (myColor._red == 255 && myColor._green == 0 && myColor._blue == 0)
            {
                Console.WriteLine("当前颜色为红色");
            }
        }
    }
}
