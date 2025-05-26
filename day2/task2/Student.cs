namespace task2;

public class Student : Person
{
    public string Speciality { get; set; }
    public string Course { get; set; }
        
    public Student(string name, string surname, int age, string course, string speciality) : base(name, surname, age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Course = course;
        Speciality = speciality;
    }
}