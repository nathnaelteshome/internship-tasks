
using System.Text.Json;

public class Student
{
    public string Name {get; set;}
    public int Age {get; set;}
    public int  RollNumber {get; init;}
    public double Grade {get; set;}
}

// Implement a generic class called "StudentList<T>" to manage a list of Student objects.
public class StudentList<T>
{
    private List<Student> _students = new List<Student>();

    
    public List<Student> GetClass(){
        return _students;
    }
    public void Add(Student student)
    {
        _students.Add(student);
    }

    public void Remove(Student student)
    {
        _students.Remove(student);
    }

    public void Display()
    {
        Console.WriteLine("List of Students");
        foreach (var student in _students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, RollNumber: {student.RollNumber}, Grade: {student.Grade}");
        }
    }

// Use LINQ to search for students by name or ID.
    public void Search(string name)
    {
        var students = from s in _students
                        where s.Name == name
                        select s;

        if (students != null)
        {
            foreach(Student student in students )
                Console.WriteLine(student.Name);
        }
    }

    public void Search(int rollNumber)
    {
        var student = from s in _students
                    where s.RollNumber == rollNumber
                    select s;
        if (student != null)
        {
            Console.WriteLine(student);
        }
    }

}

class Program {
    static void Main(string[] args)
    {
        StudentList<Student> classA = new StudentList<Student>();
        classA.Add(new Student { Name = "Nate", Age = 20, RollNumber = 1, Grade = 83.5 });
        classA.Add(new Student { Name = "John", Age = 21, RollNumber = 2, Grade = 93.7 });
        classA.Add(new Student { Name = "Bob", Age = 22, RollNumber = 3, Grade = 53.9 });
        classA.Add(new Student { Name = "Jill", Age = 23, RollNumber = 4, Grade = 74.0 });

        //Serialization to Json and read the JSON file.
        string fileName = "classroom.json";
        string jsonString = JsonSerializer.Serialize(classA.GetClass());
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine(File.ReadAllText(fileName));

        // deserialize json file
        string deserializedjson = File.ReadAllText(fileName);
        List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(deserializedjson);
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine($"Name from Json: {student.Name}, Age: {student.Age}, RollNumber: {student.RollNumber}, Grade: {student.Grade}");
        }


        Console.WriteLine("class A has the following students:");
        classA.Display();

        classA.Search("John");
    }
}