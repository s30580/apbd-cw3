namespace cw3;

public class OverfillException: Exception
{
    public OverfillException() : base("Kontener przepelniony")
    {
    }
}