// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine(Math.Abs(2.0 - Math.Pow(Math.Sqrt(2.0), 2)) < 1e-8);

double Foo(double x)
{
    return x * x - 3 * x + Math.Sin(x / 2);
}

interface IIntegralSolver
{

    double Solve(Func<double, double> integrand, double leftBound, double rightBound, double epsilon);

    string Name { get; }

}

abstract class IntegralSolverBase : IIntegralSolver
{

    public double Solve(Func<double, double> integrand, double leftBound, double rightBound, double epsilon)
    {
        if (integrand == null)
        {
            throw new ArgumentNullException(nameof(integrand));
        }

        if (epsilon <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(epsilon));
        }

        if (rightBound - leftBound < epsilon)
        {
            throw new ArgumentOutOfRangeException(nameof(leftBound));
        }

        return SolveInner(integrand, leftBound, rightBound, epsilon);
    }

    protected abstract double SolveInner(Func<double, double> integrand, double leftBound, double rightBound, double epsilon);

    public abstract string Name { get; }

}

sealed class LeftRectanglesIntegralSolver : IntegralSolverBase
{

    protected override double SolveInner(Func<double, double> integrand, double leftBound, double rightBound,
        double epsilon)
    {
        // TODO: implement logic

        throw new NotImplementedException();
    }

    public override string Name =>
        "Left rectangles method";

}