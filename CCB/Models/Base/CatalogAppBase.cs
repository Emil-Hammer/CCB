using CCB.Data.Persistent;
using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;

namespace CCB.Models.Base
{
    // File-based persistency
    //
    //public class CatalogAppBase<T> : FileCatalog<T>
    //    where T : class, IStorable, ICopyable, new()
    //{
    //    public CatalogAppBase() : base()
    //    {
    //    }
    //}

    // EFCore2.0-based persistency
    //
    public class CatalogAppBase<T> : EFCoreCatalog<CCBDBContext, T>
        where T : class, IStorable, ICopyable, new()
    {
        public CatalogAppBase() : base(KeyManagementStrategyType.CollectionDecides)
        {
        }
    }
}