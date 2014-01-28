using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class Lab
    {
        public int Id { get; set; } // id of lab
        public string Name { get; set; } // name of lab
        public string ImageURL { get; set; } // location of avatar 
        public string City { get; set; } // city lab located
        public string State { get; set; } // state lab located
        public string PostalCode { get; set; } // postal code lab located
        public string Country { get; set; } // country lab located
        public virtual ICollection<Photo> EvidencePhotos { get; set; } // collection of photos in lab
        public virtual ICollection<Document> EvidenceDocuments { get; set; } // collection of documents in lab
        public virtual ICollection<Researcher> Researchers { get; set; } // collection of reserachers in lab
    }
}
