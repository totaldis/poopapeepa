using poo.api.Repositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using poo.data;
using Newtonsoft.Json.Linq;
using poo.domain;
using System.ComponentModel.DataAnnotations;
using poo.api.Helpers;

namespace poo.api.Repositorys
{
    public class EntitiesRepository : IEntitiesRepository
    {
        readonly EFContextProvider<PooContext> contextProvider = new EFContextProvider<PooContext>();

        public string Metadata()
        {
            return contextProvider.Metadata();
        }
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return contextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<Researcher> Researchers
        {
            get
            {
                if (true)
                {
                    var error = new EntityError
                    {
                        EntityTypeName = "Reseaercher",
                        ErrorMessage = "What, you think you have access to this?",
                        ErrorName = "Authorization"
                    };
                    var errors = new List<EntityError>();
                    errors.Add(error);
                    throw new EntityErrorsException(errors);
                }
                return contextProvider.Context.Researchers;
            }
        }
        public IQueryable<Photo> Photos
        {
            get
            {
                return contextProvider.Context.Photos;
            }
        }
        public IQueryable<Lab> Labs
        {
            get
            {
                return contextProvider.Context.Labs;
            }
        }
        public IQueryable<Document> Documents
        {
            get
            {
                return contextProvider.Context.Documents;
            }
        }


        public object Lookups
        {
            get
            {
                return new
                {
                    Importance = DataHelpers.GetEnumDictionary<Priority>()
                };
            }
        }
    }
}
    


