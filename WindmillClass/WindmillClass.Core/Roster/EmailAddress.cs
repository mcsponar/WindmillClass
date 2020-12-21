namespace WindmillClass.Core.Roster
{
    public class EmailAddress
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public bool IsPublic { get; set; }

        public bool IsPrimary { get; set; }
    }
}