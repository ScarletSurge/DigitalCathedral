namespace DigitalCathedral.Task2;

public sealed class IntEqualityComparer : IEqualityComparer<int>
{
    
    private const int EventIntHashCode = 0;
    
    public bool Equals(
        int x,
        int y)
    {
        if (x % 2 == 0 && y % 2 == 0)
        {
            return true;
        }

        return x.Equals(y);
    }

    public int GetHashCode(
        int obj)
    {
        if (obj % 2 == 0)
        {
            return EventIntHashCode;
        }
        return obj.GetHashCode();
    }
    
}