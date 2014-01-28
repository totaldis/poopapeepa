using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public abstract class Evidence
    {
        public int Id { get; set; }
        public int LabId { get; set; }
        public string Name { get; set; } // name of evidence
        public string Description { get; set; } // description of evidence
        public string ImageURL { get; set; } // location of image
        public Priority Importance { get; set; } // importance level
        public DateTime? DateAdded { get; set; } // date uploaded
    }
}
