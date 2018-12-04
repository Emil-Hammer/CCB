namespace CCB.Data.Domain
{
    public partial class ItemAllocation
    {
        public int Id { get; set; }
        public int FkProjectId { get; set; }
        public int FkItemId { get; set; }
        public int Amount { get; set; }

        public Item FkItem { get; set; }
        public Project FkProject { get; set; }
    }
}
