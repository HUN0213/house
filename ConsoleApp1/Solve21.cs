//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;

//namespace eteverse
//{
//    internal class Solve2
//    {
//        struct student
//        {
//            public int sid;
//            public string name;
//            public string major;

//            public student(int sid, string name, string major)
//            {
//                this.sid = sid;
//                this.name = name;
//                this.major = major;
//            }
//        }
//        static void Main(string[] args)
//        {
//            student[] student = new student[5];
//            bool isRight = false;
            
//            for (int i = 0; i <= 4; i++)
//            {
//                Console.WriteLine("학생의 학번,이름,전공을 순서대로 입력해주세요.");
//                string sid = Console.ReadLine();
//                string name = Console.ReadLine();
//                string major = Console.ReadLine();
//                for (int j = 0; j <= 4; j++)
//                {
//                    if (Console.ReadLine() == "종료")
//                    {
//                        isRight = true;
//                        break;
//                        Console.WriteLine(new student());
//                    }
//                    //else if (input == new student[i])
//                    //{
//                    //    Console.WriteLine("잘못된 입력입니다.");
//                        i--;      
//                    //}
//                    isRight = false;
//                }
              
//            }

//        }
//    }
//}
