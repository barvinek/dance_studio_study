namespace Dance_Studio_RZ_2024.Models;

public class Expense
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}