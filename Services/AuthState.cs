namespace SAMS.Services
{
    public class AuthState
    {
        public bool isLoggedIn { get; set; }
        public Guid? authId { get; set; }
        public Guid id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool isApproved { get; set; }
        public string accessLevel { get; set; }
    }
}
