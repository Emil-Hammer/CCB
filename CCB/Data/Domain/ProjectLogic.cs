using System;
using Windows.UI.Xaml.Controls;
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
            Start = DateTime.Now;
            Deadline = DateTime.Now.AddDays(10);
            IsFinished = false;
        }

        public override int Key
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}