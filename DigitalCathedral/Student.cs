namespace DigitalCathedral;

public sealed class Student:
    IEquatable<Student>
{

    private readonly string _surname;
    private readonly string _name;
    private readonly string _patronymic;
    private readonly string _group;
    private readonly string _zachetka;
    private readonly int _course;

    public Student(
        string? surname,
        string? name,
        string? patronymic,
        string? group,
        string? zachetka,
        int course)
    {
        if (surname is null)
        {
            throw new ArgumentNullException(nameof(surname));
        }
        _surname = surname;

        _name = name ?? throw new ArgumentNullException(nameof(name));
        _patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
        _group = group ?? throw new ArgumentNullException(nameof(group));
        _zachetka = zachetka ?? throw new ArgumentNullException(nameof(zachetka));
        // if (!(course >= 1 && course <= 4))
        if (course < 1 || course > 4)
        {
            throw new ArgumentException("Course must be GTEQ 1 and LTEQ 4", nameof(course));
        }
        _course = course;
    }

    public string Name =>
        _name;

    public string Surname =>
        _surname;

    public string Patronymic =>
        _patronymic;

    public string Group =>
        _group;

    public string Zachetka =>
        _zachetka;

    public int Course =>
        _course;

    public override string ToString()
    {
        return "";
    }

    public override int GetHashCode()
    {
        var result = new HashCode();
        result.Add(_surname);
        result.Add(_name);
        result.Add(_patronymic);
        result.Add(_group);
        result.Add(_zachetka);
        result.Add(_course);
        return result.ToHashCode();
    }

    public override bool Equals(
        object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is Student student)
        {
            return Equals(student);
        }

        return false;
    }

    public bool Equals(
        Student? student)
    {
        if (student is null)
        {
            return false;
        }

        return _surname.Equals(student._surname) &&
               _name.Equals(student._name) &&
               _patronymic.Equals(student._patronymic) &&
               _group.Equals(student._group) &&
               _zachetka.Equals(student._zachetka) &&
               _course.Equals(student._course);
    }
    
}