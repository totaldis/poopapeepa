using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class Photo : Evidence
    {
        public string LocationDiscovered { get; set; }
        public string DeviceUsed { get; set; }
    }
}
