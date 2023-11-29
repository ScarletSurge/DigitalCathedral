using System.Text;

namespace DigitalCathedral
{
    public class Animal : IEquatable<Animal>
    {
        private const double Epsilon = 1e-9;
        
        private int _value1;
        private readonly double _value2;
        private readonly string _value3 = "My awesome string";

        public void ChangeValue1()
        {
            var randomSource = new Random();
            _value1 = randomSource.Next(-1000, 1001);
        }
        
        public Animal(
            int value1,
            double value2,
            string? value3)
        {
            _value1 = value1;
            _value2 = value2;
            _value3 = value3 == null
                ? _value3
                : value3;
        }

        // bool Equals(object obj);
        // int GetHashCode();
        // string ToString();
        // ~Object(); System.IDisposable
        // bool ReferenceEquals(object obj1, object obj2);
        // System.Type GetType();

        public int GetValue1()
        {
            return _value1;
        }

        public double GetValue2()
        {
            return _value2;
        }

        public string GetValue3()
        {
            return _value3;
        }

        public override int GetHashCode()
        {
            HashCode result = new HashCode();
            result.Add(_value2);
            result.Add(_value3);
            return result.ToHashCode();
        }

        public override bool Equals(
            object? obj)
        {
            if (obj is null)
            {
                return false;
            }
            
            if (obj is Animal animal)
            {
                return Equals(animal);
            }

            return false;
        }
        
        public bool Equals(
            Animal? animal)
        {
            if (animal == null)
            {
                return false;
            }
            
            return _value1.Equals(animal.GetValue1()) &&
                   Math.Abs(_value2 - animal.GetValue2()) < Epsilon &&
                   _value3.Equals(animal.GetValue3());
        }

        public override string ToString()
        {
            //return "_value1 == " + _value1 + ", _value2 == " + _value2 + ", _value3 == \"" + _value3 + "\"";

            //return $"_value1 == {_value1}, _value2 == {_value2}, _value3 == \"{_value3}\"";

            return new StringBuilder()
                .Append("_value1 == ")
                .Append(_value1)
                .Append(", _value2 == ")
                .Append(_value2)
                .Append(", _value3 == \"")
                .Append(_value3)
                .Append('"')
                .ToString();
        }
    }

    //public sealed class Cat : Animal
    //{
    //    public Cat(
    //        string name): base(name)
    //    {
    //       // logic
    //    }
    //    
    //    public override string Voice2()
    //    {
    //        return "meow";
    //    }
    //    public override string Voice()
    //    {
    //        return "meow";
    //    }
//
    //    public override string ToString()
    //    {
    //        return "Cat: name = \"" + _name + "\", meow!";
    //    }
    //}
//
    //public sealed class Dog : Animal
    //{
    //    public override string Voice()
    //    {
    //        return "woof";
    //    }
    //}
}