namespace DigitalCathedral;

public static class CombinatoricsExtensions
{

    public static IEnumerable<IEnumerable<T>> GetCombinations<T>(
        this IEnumerable<T> values,
        int k,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        throw new NotImplementedException();
    }
    
    public static IEnumerable<IEnumerable<T>> GetUniqueCombinations<T>(
        this IEnumerable<T> values,
        int k,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        throw new NotImplementedException();
    }

    public static IEnumerable<IEnumerable<T>> GetSetOfAllSubsets<T>(
        this IEnumerable<T> values,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        throw new NotImplementedException();
    }

    public static IEnumerable<IEnumerable<T>> GetAllPermutations<T>(
        this IEnumerable<T> values,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        throw new NotImplementedException();
    }

    private static void ThrowIfNotDistinctElements<T>(
        IEnumerable<T> values,
        IEqualityComparer<T> equalityComparer)
    {
        var distinctValues = values.Distinct(equalityComparer).ToArray();
        if (distinctValues.Length != values.Count())
        {
            throw new ArgumentException("Found equal elements in  collection.", nameof(values));
        }
    }
    
}