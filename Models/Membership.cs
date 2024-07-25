namespace Dance_Studio_RZ_2024.Models;

public class Membership
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal Price { get; set; }
    public List<Member>? Members { get; set; }
}