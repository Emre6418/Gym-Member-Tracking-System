namespace Gym_Member_Tracking_System.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string? ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool Status { get; set; }

    }
}
