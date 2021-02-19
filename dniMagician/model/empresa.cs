using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dniMagician.model
{
    public class empresa
    {
        public empresa() { }
        public string CIF { get; set; }
        public Boolean isValid { get; set; }
        public string Province { get; set; }
        public string typeSociety { get; set; }
    }
}
