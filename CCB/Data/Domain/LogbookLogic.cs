using CCB.Data.Base;

namespace CCB.Data.Domain
{
    public partial class Logbook : DomainClassAppBase
    {
        public override void SetDefaultValues()
        {
            Name = "(not set)";
            Type = "(not set)";
            Action = "(not set)";
        }

        public override int Key
        {
            get => Id;
            set => Id = value;
        }
    }
}