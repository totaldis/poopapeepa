using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class Researcher
    {
        private ICollection<Photo> _photos;
        private ICollection<Document> _documents;
        private ICollection<Lab> _labs;

        public Researcher()
        {
            _photos = new List<Photo>();
            _documents = new List<Document>();
        }

        public int Id { get; set; } // id of researcher
        public string Name { get; set; } // user name of researcher
        public int? Age { get; set; } // age of researcher
        public string ImageURL { get; set; } // location of image

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

        public virtual ICollection<Lab> Labs
        {
            get { return _labs; }
            set { _labs = value; }
        }
    }
}
