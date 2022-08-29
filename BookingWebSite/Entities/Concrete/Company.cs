using BookingWebSite.Entities.Abstract;

namespace BookingWebSite.Entities.Concrete
{
    public partial class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public float? Salary { get; set; }
    }
}
