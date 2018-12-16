using System;
using CCB.Data.Base;

namespace CCB.Data.Domain
{
    public partial class Project : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Description = "";
            Address = "";
            Telephone = "";
            Start = DateTimeOffset.Now;
            Deadline = DateTimeOffset.Now.AddDays(10);
            IsFinished = false;
        }

        public override int Key
        {
            get => Id;
            set => Id = value;
        }
    }
}