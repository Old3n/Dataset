using CsvHelper.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataset
{
    public class translateprocess
    {
        List<Digikalamodel> Records;


        public translateprocess(List<Digikalamodel> Records)
        {
            this.Records = Records; 
        }

        public void  translatecity()
        {
            foreach(var record in Records)
            {
                string citynameinpersian = record.city_name_fa;
                
                string englishString = citynameinpersian.Replace("آ", "a").Replace("ا", "a").Replace("ب", "b").Replace("پ", "p").Replace("ت", "t").Replace("ث", "s").Replace("ج", "j").Replace("چ", "ch").Replace("ح", "h").Replace("خ", "kh").Replace("د", "d").Replace("ذ", "z").Replace("ر", "r").Replace("ز", "z").Replace("ژ", "zh").Replace("س", "s").Replace("ش", "sh").Replace("ص", "s").Replace("ض", "z").Replace("ط", "t").Replace("ظ", "z").Replace("ع", "'").Replace("غ", "gh").Replace("ف", "f").Replace("ق", "gh").Replace("ک", "k").Replace("گ", "g").Replace("ل", "l").Replace("م", "m").Replace("ن", "n").Replace("و", "v").Replace("هٔ", "e'").Replace("ه", "h").Replace("ی", "y");
                Fileandtext fp = new Fileandtext();
                fp.Fileandtextprocessor("CitynamesinEN",englishString);
            }
        }
    }
}
