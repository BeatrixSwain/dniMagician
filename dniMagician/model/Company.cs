using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dniMagician.model
{
    public class Company
    {
        public Company() { }
        public string CIF { get; set; }
        public Boolean isValid { get; set; }
        public string Province { get; set; }
        public string typeSociety { get; set; }
        public String letterType { get; set; }
        public String controlDigit { get; set; }
        public int numProvince { get; set; }
    }
}
