namespace Dance_Studio_RZ_2024.Models;

public class Member
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int MembershipId { get; set; }
    public Membership? Membership { get; set; }
    public List<Attendance>? Attendances { get; set; }
}