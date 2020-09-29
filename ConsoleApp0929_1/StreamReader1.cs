using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929_1
{
    class StreamReader1
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader("test.log.txt", Encoding.UTF8))
            {
                //string content = sr.ReadLine();    //ReadLine()은 1 Line을 읽어 string으로 반환 -->> 끝일 경우 null 반환
                string content;
                do
                {
                    content = sr.ReadLine();
                    Console.WriteLine(content);
                } while (content != null);
            }
            /*
            using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
            {
                string content = sr.ReadToEnd();    //처음부터 끝까지 전부 읽음
                Console.WriteLine(content);
            }
             */
        }
    }
}
