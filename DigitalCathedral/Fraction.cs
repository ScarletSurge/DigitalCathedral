using System;

namespace DigitalCathedral;

/// <summary>
/// Class, represents fraction instance.
/// </summary>
public sealed class Fraction:
    IEquatable<Fraction>,
    IComparable,
    IComparable<Fraction>
{
    
    #region Fields
    
    /// <summary>
    /// Fraction numerator.
    /// </summary>
    private readonly ulong _numerator;
    
    /// <summary>
    /// Fraction denominator.
    /// </summary>
    private readonly long _denominator;
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// description
    /// </summary>
    /// <param name="numerator">param1</param>
    /// <param name="denominator">param2</param>
    /// <exception cref="ArgumentException">exception!!1!1</exception>
    public Fraction(
        ulong numerator,
        long denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator can't be EQ to 0", nameof(denominator));
        }
        _denominator = denominator;

        if (numerator == 0)
        {
            _denominator = 1;
            return;
        }
        _numerator = numerator;
        
        var gcd = EuclideanAlgorithm(numerator, (ulong)Math.Abs(denominator));
        _numerator /= gcd;
        _denominator /= (long)gcd;
    }
    
    #endregion
    
    #region Methods
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
    private ulong EuclideanAlgorithm(
        ulong firstValue,
        ulong secondValue)
    {
        if (firstValue == 0)
        {
            return secondValue;
        }

        if (secondValue == 0)
        {
            return firstValue;
        }

        if (firstValue == 1 || secondValue == 1)
        {
            return 1;
        }

        if (firstValue.Equals(secondValue))
        {
            return firstValue;
        }

        if (firstValue > secondValue)
        {
            return EuclideanAlgorithm(firstValue % secondValue, secondValue);
        }

        return EuclideanAlgorithm(secondValue % firstValue, firstValue);
    }
    
    #endregion
    
    #region System.Object overrides
    
    /// <inheritdoc cref="Object.GetHashCode" />
    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(_numerator);
        hashCode.Add(_denominator);
        return hashCode.ToHashCode();
    }
    
    /// <inheritdoc cref="Object.Equals(object?)" />
    public override bool Equals(
        object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is Fraction fraction)
        {
            return Equals(fraction);
        }

        return false;
    }
    
    /// <inheritdoc cref="Object.ToString" />
    public override string ToString()
    {
        return $"{{{(Math.Sign(_denominator) == -1 ? "-" : string.Empty)}{_numerator}/{Math.Abs(_denominator)}}}";
    }

    #endregion
    
    #region System.IEquatable<Fraction> implementation
    
    /// <inheritdoc cref="IEquatable{T}.Equals(T?)" />
    public bool Equals(
        Fraction? other)
    {
        if (other is null)
        {
            return false;
        }

        return _numerator.Equals(other._numerator)
            && _denominator.Equals(other._denominator);
    }

    #endregion
    
    #region Arithmetic operations
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstMultiplier"></param>
    /// <param name="secondMultiplier"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static Fraction Multiplication(
        Fraction? firstMultiplier,
        Fraction? secondMultiplier)
    {
        if (firstMultiplier == null)
        {
            throw new ArgumentNullException(nameof(firstMultiplier));
        }

        if (secondMultiplier == null)
        {
            throw new ArgumentNullException(nameof(secondMultiplier));
        }
        
        return new Fraction(firstMultiplier._numerator * secondMultiplier._numerator, firstMultiplier._denominator * secondMultiplier._denominator);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstMultiplier"></param>
    /// <param name="secondMultiplier"></param>
    /// <returns></returns>
    public static Fraction operator *(
        Fraction? firstMultiplier,
        Fraction? secondMultiplier)
    {
        return Multiplication(firstMultiplier, secondMultiplier);
    }
    
    #endregion
    
    #region System.IComparable implementation

    public int CompareTo(
        object? obj)
    {
        if (obj is null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        if (obj is Fraction fraction)
        {
            return CompareTo(fraction);
        }

        throw new InvalidOperationException("Can't compare fraction with object of unknown type.");
    }

    #endregion
    
    #region System.IComparable<in T> implementation

    public int CompareTo(
        Fraction? other)
    {
        if (other is null)
        {
            throw new ArgumentNullException(nameof(other));
        }

        var part1 = (long)_numerator * other._denominator;
        var part2 = (long)other._numerator * _denominator;
        return part1.CompareTo(part2);
    }

    #endregion

}