using System;
using CCB.Data.Base;
using CCB.Models.App;

namespace CCB.Data.Domain
{
    public partial class Staff : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Name = "(not set)";
            Telephone = "(not set)";
            Position = "(not set)";
            EmployedSince = DateTimeOffset.Now.Date;
        }

        public override int Key
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}