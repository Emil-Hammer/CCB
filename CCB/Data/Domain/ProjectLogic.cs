using System;
using CCB.Data.Base;
using CCB.Models.App;

namespace CCB.Data.Domain
{
    public partial class Project : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Description = "(not set)";
            Address = "(not set)";
            Telephone = "(not set)";
            Start = new DateTime(1990, 1, 1);
            Deadline = new DateTime(1990, 1, 1);
            IsFinished = false;
        }

        public override int Key
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}