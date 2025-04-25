namespace ILTU3621.Model
{
    public class AccountResponse
    {
        public int UserID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}
