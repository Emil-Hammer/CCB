namespace CCB.Data.Domain
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountAllocated { get; set; }
    }
}
