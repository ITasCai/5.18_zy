using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._18_zy
{
    //定义一个构造,第一题
    struct MyCollor {
        public string Red;
        public string green;
        public string Blue;

    }
    //定义一个构造,第二题
    struct Person {
        public string name;
        public string sex;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region 1.	定义一个结构叫MyCollor，有三个成员，分别为Red,green,Blue声明一个MyColor类型的变量，并对其成员赋值，使MyColor可以表示成一个红色。

            //MyCollor mc;
            //mc.Red = "红色";
            //mc.green = "绿色";
            //mc.Blue = "蓝色";
            //Console.WriteLine("{0},{1},{2}",mc.Red,mc.green,mc.Blue);
            //Console.ReadKey(); 
            #endregion
            #region 2.	定义一个结构类型Person。有三个成员，分别为姓名,性别，年龄。声明两个Person类型的变量，分别表示张三 男 18岁/小兰 女 16岁

            //Person p;
            //p.name = "张三";
            //p.sex = "男";
            //p.age = 18;

            //Person p2;
            //p2.name = "小兰";
            //p2.sex = "女";
            //p2.age = 16;

            //Console.WriteLine("姓名:{0},性别:{1},年龄:{2}",p.name,p.sex,p.age);
            //Console.WriteLine("姓名:{0},性别:{1},年龄:{2}", p2.name, p2.sex, p2.age);
            //Console.ReadKey();

            #endregion
            #region 3.	写一个交换两个数的函数void Swap(ref int a,ref int b)

            //Console.WriteLine("请输入第一个数：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Swap(ref num1, ref num2);
            //Console.ReadLine();
            #endregion

            #region 4.	写一个判断闰年的函数，在主函数中调用该方法，年份由控制台输入！（(year%4==0&&year%100!=0) ||year%400==0）

            //Console.WriteLine("请输入一个年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //GetYear(year);
            //Console.ReadLine();

            #endregion
            #region 5.	重复让用户输入一个数,判断该数是否是质（素）数,输入q结束?    质数的判断用函数来实现
            //while (true)
            //{

            //    Console.WriteLine("输入一个数字：");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    PrimeNumber(num);
            //    Console.ReadLine();

            //}

            #endregion

            #region 6.	用函数实现找出一个int类型数组中最大值和最小值

            //Console.WriteLine("你想输入几个数：");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[k];
            //GetArr(arr);
            //Console.ReadLine();
            #endregion

            #region 7.	将一个字符串数组输出为|分割的形式，比如“李小龙|成龙|释小龙|史泰龙”(用方法来实现此功能)

            //Console.WriteLine("输入字符串的个数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //string []str = new string[count];
            //GetJoin(str);

            //Console.ReadLine();
            #endregion


            #region 

            #endregion
            #region 9.	已知一个数组 int [] arryNumber={29,30,12,9,40,78,90};要求创建一个方法,打印数组的所有元素和最小值，返回数组所有元素之和。

            // int[] arryNumber = { 29, 30, 12, 9, 40, 78, 90 };

            //int sum = GetSum(arryNumber);
            //Console.WriteLine("数组之和为：{0}",sum);
            //Console.ReadKey();

            #endregion
            #region 10.	创建一个方法，用来统计输入字符串中字母的个数。  提示：使用字符串的方法ToCharArray()将字符串输出一个数组类型的字符数组。

            Console.WriteLine("请输入一个字符串");
            string str = Console.ReadLine();
            int count = GetCount(str);
            Console.WriteLine("字符串中的字母个数为{0}：", count);
            Console.ReadLine();

            #endregion
        }

        /// <summary>
        /// 计算字符串字母的格式
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>返回字符串中字母的个数</returns>
        private static int GetCount(string str)
        {
            int count = 0;
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch[i] >= 'a' && ch[i] <= 'z') || (ch[i] >= 'A' && ch[i] <= 'Z'))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 数组的和，最大最小值
        /// </summary>
        /// <param name="arryNumber">数组</param>
        /// <returns>返回数组的和</returns>
        private static int GetSum(int[] arryNumber)
        {

            int max = arryNumber[0];
            int min = arryNumber[0];
            int sum = 0;
            for (int i = 0; i < arryNumber.Length; i++)
            {
                if (arryNumber[i] > max)
                {
                    max = arryNumber[i];
                }
                if (arryNumber[i] < min)
                {
                    min = arryNumber[i];
                }
                sum += arryNumber[i];
            }
            Console.WriteLine("最大值为：{0},最小值为:{1}", max, min);
            return sum;
        }

        /// <summary>
        /// 数组的拼接
        /// </summary>
        private static void GetJoin(string[]str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("请输入第{0}个字符串：",i+1);
                str[i] = Console.ReadLine();
            }
            string s = string.Empty;
            foreach (string item in str)
            {
                s += item + "|";
            }

           s= s.Remove(s.LastIndexOf("|"),1);

            Console.WriteLine(s);
        }


        /// <summary>
        /// 判读数组中的最大值和最小值
        /// </summary>
        private static void GetArr(int[]arr)
        {
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("请输入第{0}个数", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
                
            
            Console.WriteLine("最大值为：{0},最小值为:{1}",max,min);
        }


        /// <summary>
        /// 判断是否是素数
        /// </summary>
        /// <param name="num">输入的数字</param>
        private static void PrimeNumber(int num)
        {
            if (num > 1)
            {
                bool flag = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("{0}不是素数",num);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("{0}是素数", num);
                }

            }
            else
            {
                throw new ArgumentException("数字小于1不是质数！");
            }
        }


        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year">年份</param>
        private static void GetYear(int year)
        {
            if ((year%4 == 0 && year %100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0}年是闰年",year);
            }
            else
            {
                Console.WriteLine("{0}年不是闰年",year);
            }
        }

        /// <summary>
        /// 交换两个数字
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        private static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a={0},b={1}",a,b);

        }
    }
}
