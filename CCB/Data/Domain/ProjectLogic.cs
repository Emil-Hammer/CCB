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