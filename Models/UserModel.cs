namespace ProjectCDN_API.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? EmailAddress { get; set; }
        public long PhoneNumber { get; set; }
        public string? SkillSets { get; set; }
        public string? Hobbies { get; set; }
    }
}
