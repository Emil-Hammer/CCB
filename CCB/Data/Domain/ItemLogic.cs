using System;
using CCB.Data.Base;
using CCB.Models.App;

namespace CCB.Data.Domain
{
    public partial class Item : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Name = "(not set)";
            AmountAvailable = 0;
            AmountAllocated = 0;
        }

        public override int Key
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}