﻿using System.Collections.Generic;
using CCB.Data.Domain;
using CCB.Models.App;
using CCB.ViewModels.Base;
using Data.InMemory.Interfaces;
using CCB.ViewModels.Data;

namespace CCB.ViewModels.Page
{
    public class FrontPageViewModel : PageViewModelAppBase<Logbook>
    {
        public FrontPageViewModel()
            : base(DomainModel.Catalogs.LogbookCatalog,
                new List<string> { },
                new List<string> { })
        {
        }

        public override IDataWrapper<Logbook> CreateDataViewModel(Logbook obj)
        {
            return new FrontDataViewModel(obj);
        }

        
    }
}