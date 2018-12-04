using System;

namespace CCB.Data.Domain
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Position { get; set; }
        public DateTime EmployedSince { get; set; }
    }
}
