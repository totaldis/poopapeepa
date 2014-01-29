using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class Lab
    {
        private ICollection<Photo> _photos;
        private ICollection<Document> _documents;
        private ICollection<Researcher> _researchers;

        public Lab()
        {
            _photos = new List<Photo>();
            _documents = new List<Document>();
            _researchers = new List<Researcher>();
        }

        public int Id { get; set; } // id of lab
        public string Name { get; set; } // name of lab
        public string City { get; set; } // city lab located
        public string State { get; set; } // state lab located
        public string PostalCode { get; set; } // postal code lab located
        public string Country { get; set; } // country lab located
        public string ImageURL { get; set; } // location of avatar 

        public virtual ICollection<Photo> Photos
        {
            get { return _photos; }
            set { _photos = value; }
        }

        public virtual ICollection<Document> Documents
        {
            get { return _documents; }
            set { _documents = value; }
        }

        public virtual ICollection<Researcher> Researchers
        {
            get { return _researchers; }
            set { _researchers = value; }
        }

    }
}
