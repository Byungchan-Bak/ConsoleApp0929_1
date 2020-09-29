using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929_1
{
    [Serializable]
    class ClassSerialize2
    {
        static void Main()
        {
            BinaryFormatter serializer = new BinaryFormatter(); //File Type

            //파일을 읽어서 배열에 저장
            PersonS[] arr = new PersonS[3];
            if (File.Exists("b.dat"))
            {
                FileStream rs = new FileStream("b.dat", FileMode.Open);   //FileStream생성 -->> 파일 생성 설정(열기)
                arr = (PersonS[])serializer.Deserialize(rs);
                Console.WriteLine("객체 역질렬화 성공");
                //저장된 배열을 출력
                foreach (PersonS item in arr)
                {
                    Console.WriteLine(item.Name);
                }
                rs.Close();
                Console.WriteLine();
            }
            
            int readCnt = arr.Length;

            PersonS[] arr2 = new PersonS[readCnt+3];
            Array.Copy(arr, arr2, readCnt);
            arr2[readCnt] = new PersonS("아이유", "010-4444", 28);
            arr2[readCnt + 1] = new PersonS("유인나", "010-5555", 32);
            arr2[readCnt + 2] = new PersonS("이승기", "010-6666", 36);
            if (File.Exists("b.dat"))
            {
                FileStream fs = new FileStream("b.dat", FileMode.Create);   //FileStream생성 -->> 파일 생성 설정(생성)
                serializer.Serialize(fs, arr2);  //객체 데이터 입력
                fs.Close();
                FileStream rs = new FileStream("b.dat", FileMode.Open);
                arr2 = (PersonS[])serializer.Deserialize(rs);
                Console.WriteLine("객체 직렬화 성공");
                foreach (PersonS item in arr2)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine();
        }
    }
}
