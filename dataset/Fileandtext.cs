using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataset
{
    public class Fileandtext
    {
        public void Fileandtextprocessor(string filename,int num)
        {
            string path = @"C:\Users\ho3in\source\repos\dataset\data\" + filename+".txt";
            
            using(StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine(num);
            }
        }
        public void Fileandtextprocessor(string filename, string citynameinfa)
        {
            string path = @"C:\Users\ho3in\source\repos\dataset\data\" + filename + ".txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(citynameinfa);
            }
        }
    }
}
