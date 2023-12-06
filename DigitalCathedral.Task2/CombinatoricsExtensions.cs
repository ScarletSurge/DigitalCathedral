namespace DigitalCathedral.Task2;

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
        var valuesArray = values.ToArray();

        if (valuesArray.Length == 0)
        {
            yield return Enumerable.Empty<T>();
            yield break;
        }
        
        foreach (var permutation in GetAllPermutations(new List<T>(valuesArray.Length), valuesArray.ToList()))
        {
            yield return permutation;
        }
    }

    private static IEnumerable<IEnumerable<T>> GetAllPermutations<T>(
        List<T> wereAdded,
        List<T> notAdded)
    {
        if (notAdded.Count == 0)
        {
            yield return wereAdded.ToList();
        }

        for (var i = 0; i < notAdded.Count; i++)
        {
            wereAdded.Add(notAdded[i]);
            notAdded.RemoveAt(i);

            foreach (var permutation in GetAllPermutations(wereAdded, notAdded))
            {
                yield return permutation;
            }

            notAdded.Insert(i, wereAdded.Last());
            wereAdded.RemoveAt(wereAdded.Count - 1);
        }
    }

    private static void ThrowIfNotDistinctElements<T>(
        IEnumerable<T> values,
        IEqualityComparer<T> equalityComparer)
    {
        if (values.Distinct(equalityComparer).Count() != values.Count())
        {
            throw new ArgumentException("Found equal elements in  collection.", nameof(values));
        }
    }
    
}