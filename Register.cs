
namespace LinqStudies;

public class Register
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int OperationType { get; set; }
    public decimal Value { get; set; }
    public Register(int id, string? description, int operationType, decimal value)
    {
        Id = id;
        Description = description;
        OperationType = operationType;
        Value = value; 
    }
}