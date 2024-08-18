using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Classjemini
    {

struct Student
    {
        public int StudentId;
        public string Name;
        public string Major;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            int count = 0;

            while (true)
            {
                Console.WriteLine("1. 학생 등록, 2. 종료");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("학번: ");
                    int studentId = int.Parse(Console.ReadLine());
                    Console.Write("이름: ");
                    string name = Console.ReadLine();
                    Console.Write("전공: ");
                    string major = Console.ReadLine();

                    // 중복 확인
                    bool isDuplicate = false;
                    for (int i = 0; i < count; i++)
                    {
                        if (students[i].StudentId == studentId &&
                            students[i].Name == name &&
                            students[i].Major == major)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        students[count] = new Student { StudentId = studentId, Name = name, Major = major };
                        count++;
                        Console.WriteLine("학생 정보가 등록되었습니다.");
                    }
                    else
                    {
                        Console.WriteLine("중복된 학생 정보입니다. 다시 입력해주세요.");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("등록된 학생 목록");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"학번: {students[i].StudentId}, 이름: {students[i].Name}, 전공: {students[i].Major}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
    }
}
}
