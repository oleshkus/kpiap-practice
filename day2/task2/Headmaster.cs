namespace task2;

public class Headmaster : Teacher
{
    public Headmaster(string name, string surname, int age, string job, string speciality) : base(name, surname, age, job, speciality)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Job = job;
        Speciality = speciality;
    }
}