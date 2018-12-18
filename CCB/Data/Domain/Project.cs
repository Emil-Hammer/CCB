using System;

namespace CCB.Data.Domain
{
    public partial class Project
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset? Deadline { get; set; }
        public bool IsFinished { get; set; }
    }
}
