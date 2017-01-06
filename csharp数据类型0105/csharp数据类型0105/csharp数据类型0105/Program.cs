using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp数据类型0105
{
    class Program
    {
        static void Main(string[] args)
        {
            //float i = 0.5f;
            //string s = i.ToString();
            //string s2 = @"a\nb";
            //Console.WriteLine                                                                                

           

            ////1 数组
            //int[] a = new int[8];
            ////2
            //int[] b = new int[] { 1, 2, 3, 4, 5, };
            //int[] b1 = { 1, 2, 3, 4, 5 };
            ////二维数组 声明1
            //int[][]aa = new int[8][];
            ////二维数组 声明2
            //int[][] bb = new int[][]
            //{
            //   new int []{1,2,3,4,5},
            //   new int []{1,2,3,4,5},
            //   new int []{1,2,3,4,5}
            //};
            //int[][] bb1 =
            //{
            //    new int []{1,2,3,4,5},
            //    new int []{1,2,3,4,5},
            //    new int []{1,2,3,4,5}
            //};
          
            int[] b = new int[] { 1, 2, 3, 4, 5};
            int m = 0;
            for (int i = 0; i < b.Length; i++) 
            {
                m = m + b[i];
                
            }
            Console.WriteLine(m);
            Console.Read();
            


        }
    }
}
//值类型
//struct  
//enum
//引用类型
//其他（class .....之类）
//
//
//