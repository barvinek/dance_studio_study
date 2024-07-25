namespace Dance_Studio_RZ_2024.Models;

public class Attendance
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public Member? Member { get; set; }
    public DateTime Date { get; set; }
}