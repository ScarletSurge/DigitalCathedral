namespace DigitalCathedral.Task2;

public static class CombinatoricsExtensions
{

    #region Combinations
    
    private static IEnumerable<IEnumerable<T>> GetCombinations<T>(
        List<T> wereAdded,
        List<T> notAdded,
        int k,
        int lastAddedValueIndex,
        bool isUniqueValues)
    {
        if (wereAdded.Count == k)
        {
            yield return wereAdded;
            yield break;
        }

        for (var i = isUniqueValues ? lastAddedValueIndex + 1 : 0; i < notAdded.Count; i++)
        {
            wereAdded.Add(notAdded[i]);
            
            foreach (var combination in GetCombinations(wereAdded, notAdded, k, i, isUniqueValues))
            {
                yield return combination;
            }

            wereAdded.RemoveAt(wereAdded.Count - 1);
        }
    }
    
    public static IEnumerable<IEnumerable<T>> GetCombinations<T>(
        this IEnumerable<T> values,
        int k,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        
        var valuesArray = values.ToList();

        if (k < 0 || k > valuesArray.Count)
        {
            throw new ArgumentException("k must be GT or EQ 0 and LT or EQ values count", nameof(k));
        }

        if (k == 0)
        {
            yield return Enumerable.Empty<T>();
            yield break;
        }

        if (valuesArray.Count == k)
        {
            yield return valuesArray;
            yield break;
        }

        foreach (var combination in GetCombinations(new List<T>(k), valuesArray, k, -1, false))
        {
            yield return combination;
        }
    }
    
    public static IEnumerable<IEnumerable<T>> GetUniqueCombinations<T>(
        this IEnumerable<T> values,
        int k,
        IEqualityComparer<T> equalityComparer)
    {
        ThrowIfNotDistinctElements(values, equalityComparer);
        
        var valuesArray = values.ToList();

        if (k < 0 || k > valuesArray.Count)
        {
            throw new ArgumentException("k must be GT or EQ 0 and LT or EQ values count", nameof(k));
        }

        if (k == 0)
        {
            yield return Enumerable.Empty<T>();
            yield break;
        }

        if (valuesArray.Count == k)
        {
            yield return valuesArray;
            yield break;
        }

        foreach (var combination in GetCombinations(new List<T>(k), valuesArray, k, -1, true))
        {
            yield return combination;
        }
    }
    
    #endregion
    
    #region Subsets

    private static IEnumerable<IEnumerable<T>> GetSetOfAllSubsets<T>(
        T[] values,
        List<T> constructedSubset,
        int lastUsedValueIndex)
    {
        if (lastUsedValueIndex == values.Length - 1)
        {
            yield return constructedSubset.ToList();
            yield break;
        }

        foreach (var subset in GetSetOfAllSubsets(values, constructedSubset, lastUsedValueIndex + 1))
        {
            yield return subset.ToList();
        }

        constructedSubset.Add(values[lastUsedValueIndex + 1]);
        
        foreach (var subset in GetSetOfAllSubsets(values, constructedSubset, lastUsedValueIndex + 1))
        {
            yield return subset.ToList();
        }
        
        constructedSubset.RemoveAt(constructedSubset.Count - 1);
    }

    public static IEnumerable<IEnumerable<T>> GetSetOfAllSubsets<T>(
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
        
        foreach (var subset in GetSetOfAllSubsets(valuesArray, new List<T>(valuesArray.Length), -1))
        {
            yield return subset;
        }
    }
    
    #endregion
    
    #region Permutations

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
    
    #endregion
    
    #region Validation

    private static void ThrowIfNotDistinctElements<T>(
        IEnumerable<T> values,
        IEqualityComparer<T> equalityComparer)
    {
        if (values.Distinct(equalityComparer).Count() != values.Count())
        {
            throw new ArgumentException("Found equal elements in  collection.", nameof(values));
        }
    }
    
    #endregion
    
}