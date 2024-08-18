//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{

//    internal class Solve3
//    {
//        static int Callatz(int num)
//        {

//            Console.WriteLine($"입력한 숫자는{num}입니다. 작업을 시작합니다.");


//            while (num != 1)
//            {

//                num = num % 2 == 0 ? num / 2 : num * 3 + 1;
//                Console.WriteLine(num);
//            }
//            return num;

//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("숫자를 입력해주세요 >>");

//            Callatz(int.Parse(Console.ReadLine()));

//            Console.WriteLine("작업이 종료되었습니다.");






//            //while (num != 1)
//            //{

//            //    num = num % 2 == 0 ? num / 2 : num * 3 + 1;
//            //    Console.WriteLine(num);
//            //}
//            //Console.WriteLine("작업이 종료되었습니다.");

//            //int first = 0;
//            //int second = 1;

//            //while (second <= 20)
//            //{
//            //    Console.WriteLine(second);
//            //    int temp = first + second;
//            //    first = second;
//            //    second = temp;
//            //}

//        }
//    }
//}
