
namespace LinqStudies;

public class Registers
{
    public List<Register> RegisterList { get; set; }

    public Registers()
    {
        RegisterList = new List<Register>
        {
           new(1, "Test1", 1, 1100.15M),
           new(2, "Test2", 2, 1200.15M),
           new(3, "Test3", 1, 1500.15M),
           new(4, "Test4", 2, 1000.15M)
        };
    }
}
