namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John", "Doe", 30);
        Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
        
        Student student = new Student("Alice", "Smith", 20, "Computer Science", "Bachelor");
        Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, Course: {student.Course}, Speciality: {student.Speciality}");
        
        Teacher teacher = new Teacher("Michael", "Johnson", 35, "Mathematics", "Master");
        Console.WriteLine($"Name: {teacher.Name}, Surname: {teacher.Surname}, Age: {teacher.Age}, Speciality: {teacher.Speciality}");
        
        Headmaster headmaster = new Headmaster("Emily", "Brown", 40, "Teacher", "Master");
        Console.WriteLine($"Name: {headmaster.Name}, Surname: {headmaster.Surname}, Age: {headmaster.Age}, Job: {headmaster.Job}, Speciality: {headmaster.Speciality}");
    }
}