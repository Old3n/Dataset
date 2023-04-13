using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataset
{
    public class Digikalamodel
    {
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; }
        public int ID_Item { get; set; }
        public DateTime DateTime_CartFinalize { get; set; }
        public float Amount_Gross_Order { get; set; }
        public string city_name_fa { get; set; }
        public float Quantity_item { get; set; }
    }
}
