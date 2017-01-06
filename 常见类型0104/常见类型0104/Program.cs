using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常见类型0104
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rs = Console.ReadLine();//ReadLine读取一行字符串（读取输入）;Read
            //float n = Convert.ToSingle(rs);转换其他类型变量 ;Convert
            //string aa = Console.ReadLine();
            //float v = Convert.ToSingle(aa); 
            //小数相加 float单精度浮点数
            //string rs = Console.ReadLine();//ReadLine读取一行字符串（读取输入）Read
            //double n = Convert.ToDouble(rs);
            //string aa = Console.ReadLine();
            //double v = Convert.ToDouble(aa);
            //双精度浮点数  
            //string rs = Console.ReadLine();//ReadLine读取一行字符串（读取输入）Read
            //int n = Convert.ToInt32(rs);
            //string aa = Console.ReadLine();
            //int v = Convert.ToInt32(aa); 
            //整数相加 int
            //short long;
            //string rs = Console.ReadLine();//ReadLine读取一行字符串（读取输入）Read
            //decimal n = Convert.ToDecimal(rs);
            //string aa = Console.ReadLine();
            //decimal v = Convert.ToDecimal(aa);
            //无误差  decimal 
            //Console.WriteLine(v+n);
            //     显示内容Write;自动换行Line


            //float ff = Convert.ToSingle("12.3");
            //decimal  dd = Convert.ToDecimal("12.3");
            //Console.WriteLine(ff);
            //Console.WriteLine(dd);
            
            //Console.Read();

            //一个变量不能被重复定义
           // string s = "abc";//字符串类型
            //列；string s = "bcd";这样就会报错
            //s = "bcd"不叫定义叫使用 一定要用"bcd"变量这个就是正确
             //字符串 
            //int i = 3;  int 整数类型
            //float f = 1.3f;//大小写都可以 在小数后还要加个f（F）才是float类型
            //直接写的小数默认是   双精度  double类型；后也要加个d；
            //float 单精度浮点数（Single）单独对应单精度 double  双精度浮点数  
            //decimal r = 1.3M;
            //没有误差 需要消耗更多性能
            //decimal>double>float
           // 精度比较

            //decimal<float<double  表示的数据范围却比float和double类型小
           // Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(float));
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine(sizeof(decimal));
            //                占用电脑多少内存
            //Console.WriteLine("Size of int: {0}", sizeof(int));
            //Console.WriteLine("Size of int: {0}", sizeof(float));
            //Console.WriteLine("Size of int: {0}", sizeof(double));
            //Console.WriteLine("Size of int: {0}", sizeof(decimal));

            
            //Console.Read();
           //范围比较
           // bool b = true;//布尔类型
            //char c = 'A';//只能表示一个字符并引用 字符类型  字符串是由字符组成 
            //char[]
            //List<int>arr = new List<int>();
            //for(int i = 0;i<1024*1024*1024;i++)
            //{
            //    arr.Add(i);
            //    // Add 加到里面去 arr名字
                
            //}



            //string s1 = "abc";
            //string s2 = "123";
            //int b1 = s1[0] + 1;//    ASCII码98     s1[0] + s1[1] 195
            //Console.WriteLine(b1);
           // Console.WriteLine(("" + s1[0] + s2[1] )+ " " + ("" + s1[2] + s2[2]));
            //Console.WriteLine("" + s1[0] + s1[2]);
           // Console.Read();



            //Console.WriteLine("abcd");
            //Console.WriteLine("1234");
            //string s2 = "1234";
            //string s1 = "abcd";
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.Write("" + s1[i - 1] + s2[i]);
      
            //}
            //Console.Read();


            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();
            xy(l1, l2);//函数调用

            if (l1.Length < l2.Length)
            {
                int dis = l2.Length - l1.Length;
                for (int i = 0; i < dis; i++)
                {
                    l1 += " ";
                }
            }
            else
            {
                int dis = l1.Length - l2.Length;
                for (int i = 0; i < dis; i++)
                {
                    l2 += " ";
                }
            }
            string s = "";
            for (int i = 0; i < l1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (l1[i] != ' ')
                        s = s + l1[i];
                }
                else
                {
                    if (l2[i] != ' ')
                        s = s + l2[i];
                }
            }
            Console.WriteLine(s);
            Console.Read();
        }
        //返回值类型 函数名 （括号里的内容）参数列表
        static void xy(string s1, string s2) //声明函数
        {
            //函数体 {}
            string  s="";
            int len = s1.Length > s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < len; i++) 
            {
                if (i % 2 == 0)
                {
                    if (i < s1.Length)
                        s = s + s1[i];
                }
                 else
                {
                    if(i<s2.Length)
                        s = s + s2[i];
                }
            }
            Console.WriteLine(s);
        
        }
    }
}
//c#常见类型网站http://www.runoob.com/csharp/csharp-data-types.html
//byte字节 一个字节用8个二进制数表示
//1024byte ==1kb 2的10次方进一位1Mb
//1024kb   ==1Mb（1兆）2的10次方进一位1Gb
//1024     ==1Gb
//1024==2的10次方

 //显示内容Write;Line一行
//Read 读取输入
//Console.Write 把内容打印到控制台
// Console.ReadLine()读取输入一行内容 ；在控制台输入
//列；
// string l1 = Console.ReadLine();
// string l2 = Console.ReadLine();
//结果是输入任意数  l1=abcd   l2=1234

//转换为其他类型变量 ;Convert
//string   "" 双引号 字符串
//char    ''  单引号 字符  'a'+1 98   'a'+'b'  ascii相加 “”+a+b
//int    整数类型
//long   长整数类型
//short  短整数类型
//bool   布尔类型
//float  单精度浮点数
//double 双精度浮点数
//decimal  无误差
//值类型
                              
//sizeof (int)   4  int32   单位；字节byte     B=字节
//sizeof (long)  8  int64
//sizeof (short) 2  int16
//sizeof (float）4
//sizeof (double）8
//sizeof (decimal）16
//sizeof (byte）1
//sizeof (boll）1
//sizeof (char）2

//引用类型

//string ""
 