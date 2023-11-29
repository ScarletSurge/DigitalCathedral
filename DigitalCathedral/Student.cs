namespace DigitalCathedral;

public sealed class Student
{

    private string _surname;
    private string _name;
    private string _patronymic;
    private string _group;
    private string _zachetka;
    private int _course;

    public Student(
        string surname,
        string name,
        string patronymic,
        string group,
        string zachetka,
        int course)
    {
        if (surname == null)
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
        return base.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    
}