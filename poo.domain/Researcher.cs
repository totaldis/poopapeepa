using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class Researcher
    {
        public int Id { get; set; } // id of researcher
        public string UserName { get; set; } // user name of researcher
        public int? Age { get; set; } // age of researcher
        public string ImageURL { get; set; } // location of image
        public virtual ICollection<Photo> EvidencePhoto { get; set; } // collection of photos produced by researcher
        public virtual ICollection<Document> EvidenceDocument { get; set; } // collection of documents produced by researcher

        public int PhotoCount
        {
            get
            {
                if (EvidencePhoto != null)
                    return EvidencePhoto.Count;
                else
                    return 0;
            }
        }
        public int DocumentCount
        {
            get
            {
                if (EvidenceDocument != null)
                    return EvidenceDocument.Count;
                else
                    return 0;
            }
        }
    }
}
