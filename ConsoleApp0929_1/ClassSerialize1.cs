using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp0929_1
{
    [Serializable]  //객체 직렬화 사용

    class PersonS
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public PersonS(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            //return $"Name : {Name}   Phone : {Phone}   Age : {Age}";
            return $"{Name} | {Phone} | {Age}";
        }
    }
        class ClassSerialize1
    {
        static void Main()
        {
            PersonS[] arr = new PersonS[3];

            arr[0] = new PersonS("김연아", "010-1111", 30);
            arr[1] = new PersonS("류현진", "010-2222", 35);
            arr[2] = new PersonS("손흥민", "010-3333", 32);

            FileStream fs = new FileStream("a.dat", FileMode.Create);   //FileStream생성 -->> 파일 생성 설정(생성)
            BinaryFormatter serializer = new BinaryFormatter(); //File Type
            serializer.Serialize(fs, arr);  //객체 데이터 입력
            fs.Close();
            Console.WriteLine("객체 직렬화 성공");

            FileStream rs = new FileStream("a.dat", FileMode.Open);   //FileStream생성 -->> 파일 생성 설정(열기)
            arr = (PersonS[])serializer.Deserialize(rs);
            Console.WriteLine("객체 역질렬화 성공");
            foreach (PersonS item in arr)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
