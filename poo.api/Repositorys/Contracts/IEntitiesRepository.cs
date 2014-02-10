using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using poo.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.api.Repositorys.Contracts
{
    public interface IEntitiesRepository
    {
        string Metadata();
        SaveResult SaveChanges(JObject saveBundle);

        IQueryable<Researcher> Researchers { get; }
        IQueryable<Photo> Photos { get; }
        IQueryable<Lab> Labs { get; }
        IQueryable<Document> Documents { get; }
        Object Lookups { get; }
    }
}
