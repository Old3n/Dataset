using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dataset
{
    public class Csvfileprocess
    {
       public List<Digikalamodel> Readcsvfile(string path)
        {
            using (var reader = new StreamReader(path,Encoding.Default))
            {

                using (var Csvreader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = Csvreader.GetRecords<Digikalamodel>().ToList();
                    return records;
                }

            }
        }
    }
}
