using BookingWebSite.Entities.Abstract;

namespace BookingWebSite.Entities.Concrete
{
    public partial class User : IEntity
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? JobTitle { get; set; }
        public string? JobType { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public int? OnboardingCompletion { get; set; }
    }
}
