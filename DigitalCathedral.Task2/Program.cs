using DigitalCathedral.Task2;

try
{
    IEqualityComparer<int> equalityComparer = new IntEqualityComparer();
    var i = 0;
    foreach (var permutation in new IEnumerableImpl().Prepend(8).Append(15).GetAllPermutations(EqualityComparer<int>.Default).Take(1000))
    {
        // Console.Write("[ ");
        // foreach (var permutationComponent in permutation)
        // {
        //     Console.Write($"{permutationComponent} ");
        // }
        // Console.WriteLine("]");
        
        Console.WriteLine($"{++i}: [ {string.Join(" ", permutation)} ]");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}