using System;
using CCB.Data.Base;
using CCB.Models.App;

namespace CCB.Data.Domain
{
    public partial class Staff : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Name = "";
            Position = "";
            Address = "";
            Telephone = "";
            EmployedSince = DateTimeOffset.Now.Date;
        }

        public override int Key
        {
            get => Id;
            set => Id = value;
        }
    }
}