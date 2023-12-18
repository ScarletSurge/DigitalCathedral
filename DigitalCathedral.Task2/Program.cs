using DigitalCathedral.Task2;

try
{
    IEqualityComparer<int> equalityComparer = new IntEqualityComparer();
    var i = 0;
    foreach (var permutation in new [] { 1, 2, 3 }.GetSetOfAllSubsets(EqualityComparer<int>.Default))
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