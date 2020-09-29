using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s = " Hello, World! ";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);

            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6, 7));
            Console.WriteLine(s.Replace('l', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');
            Console.WriteLine('/' + s.Substring(8, 5) + '/');

            Console.WriteLine(s.Contains("ll"));
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.LastIndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~", s));
            Console.WriteLine(String.Compare("abc", s));
            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(", ", val);
            Console.WriteLine(result);

            //문제1  주문번호 : yyyyMMdd일련번호5자리 (2020092900005) 를 출력하시오.

            //문제2  입력받은 아이디가 6자리 이상인지 체크하시오.

            //문제3  파일명 : yyyyMMddHHmmss + 랜덤3자리(영문대문자 + 숫자)
            */

            //문제1 : 주문번호를 입력받아 yyyyMMdd + 주문번호 5자리를 출력
            string oderNum = "";
            string date = "";

            while (true)
            {
                date = DateTime.Now.ToShortDateString().Replace("-", "");
                Console.Write("주문번호 입력 : ");
                oderNum = Console.ReadLine();
                if (oderNum.Length < 6)
                { break; }

                Console.WriteLine("최대 5자리까지만 입력하시오.");
            }
            date += oderNum.PadLeft(5, '0');
            Console.WriteLine(date);

            //문제2 : 아이디를 입력받아 자릿 수 확인
            string id;
            Console.Write("아이디 입력 : ");
            id = Console.ReadLine();
            if (id.Length >= 6)
            { Console.WriteLine("6자리 이상"); }
            else
            { Console.WriteLine("5자리 이하"); }

            //문제3 : 파일명 : yyyyMMddHHmmss + 랜덤 3자리(영문대문자 + 숫자)
            string fileName, dateday, datetime;

            byte[] str = new byte[3];
            string randomID;

            dateday = DateTime.Now.ToShortDateString().Replace("-", "");
            datetime = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            fileName = dateday + datetime;

            Random rnum = new Random();

            for (int i = 0; i < str.Length; i++)
            {
                int select = rnum.Next(1, 4);
                switch (select)
                {
                    case 1:
                        str[i] = Convert.ToByte(rnum.Next(48, 58));    //0~9
                        break;
                    case 2:
                        str[i] = Convert.ToByte(rnum.Next(65, 91));    //A ~ Z
                        break;
                    case 3:
                        str[i] = Convert.ToByte(rnum.Next(97, 123));    //a ~ z
                        break;
                }
            }
            randomID = Encoding.ASCII.GetString(str);
            fileName += randomID;
            Console.WriteLine(fileName);
        }
    }
}
