using poo.data.contracts;
using poo.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.data
{
    public class ResearcherRepository : EFRepository<Researcher>, IResearcherRepository
    {
        public ResearcherRepository(DbContext context) : base(context) { }

    }
}
