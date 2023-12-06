using System.Collections;

namespace DigitalCathedral.Task2;

public class IEnumerableImpl:
    IEnumerable<int>
{
    
    private readonly int[] _values = new[] { 1, 2, 3, 7, 5 };

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _values.GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (var i = 0; i < _values.Length; i++)
        {
            yield return _values[i];
        }
    }
    
}