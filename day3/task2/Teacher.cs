namespace task2;

public class Teacher : Person
{
    public string Job { get; set; }
    public string Speciality { get; set; }
    
    public Teacher(string name, string surname, int age, string job, string speciality) : base(name, surname, age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Job = job;
        Speciality = speciality;
    }
}