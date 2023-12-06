using DigitalCathedral.Task2;

try
{
    IEqualityComparer<int> equalityComparer = new IntEqualityComparer();
    var values = new int [] { 1, 2, 3, 4, 5 };
    values.GetCombinations(3, equalityComparer);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}