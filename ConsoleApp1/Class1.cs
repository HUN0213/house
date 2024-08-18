//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class1
//    {
//       //로그인 구현
//    //1. 기존에 아이디와 비밀번호가 별도로 저장이 되어있음.
//    //2. 입력을 통해서 아이디와 비밀번호로 로그인을 시도합니다.
//    //3. 아이디가 틀렸을 경우 "해당 아이디는 없습니다."를 출력합니다.
//    //4. 비밀번호가 틀렸을 경우에는 "비밀번호가 틀렸습니다."를 출력합니다.
//    //5. 아이디와 비밀번호가 모두 일치하는 경우 "로그인 성공"를 출력합니다.

//        //멘트는 자유롭게
//        static void Main(string[] args)
//        {
//            string id = "nks1214", pw = "asdf";



//            Console.WriteLine("아이디를 입력하세요");
//            string nks1214 = Console.ReadLine();
//            Console.WriteLine("비밀번호를 입력하세요");
//            string asdf = Console.ReadLine();

//            if (nks1214 == id && asdf == pw)
//            Console.WriteLine("로그인 성공!");
            
//            else if (nks1214 != id && asdf == pw)
//            Console.WriteLine("해당 아이디는 없습니다.");


//            else if (nks1214 == id && asdf != pw) 
//            Console.WriteLine("비밀번호가 틀렸습니다.");

//        }
//    }
//}
