using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Solve2
    {
        struct student
        {
            public int sid;
            public string name;
            public string major;

            public student(int sid, string name, string major)
            {
                this.sid = sid;
                this.name = name;
                this.major = major;
            }
        }
        static void PrintTable(student[] c)
        {

        }
        static void Main(string[] args)
        {
            student[] student = new student[5];
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("학번,이름,전공을 순서대로 입력해주세요");
                int sid = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string major = Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("학생 목록");
                for (int i = 0; i <= 5; i++)
                {

                }
            }
























            //Console.WriteLine("학생의 순번 이름 전공순으로 입력해주세요.");
            //for (int i = 0; i <= 4; i++)
            //{

            //    string sid = Console.ReadLine();
            //    string name = Console.ReadLine();
            //    string major = Console.ReadLine();








        }
    }
}
