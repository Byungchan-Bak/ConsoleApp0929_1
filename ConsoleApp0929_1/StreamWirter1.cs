using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp0929_1
{
    class StreamWirter1
    {
        [STAThreadAttribute]
        static void Main()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))   //블럭이 끝나면 자동으로 해지, true -->> Append, false -->> Override
                {
                    sw.WriteLine("안녕하세요. {0}님", "홍길동");
                    sw.WriteLine(123456);
                    sw.WriteLine("ABCabc");
                    sw.Flush(); //버퍼를 비움
                    //sw.Close(); //사용한 자원을 해지(using미사용 시)
                }
            }
        }
    }
}
