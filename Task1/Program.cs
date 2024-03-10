
Console.WriteLine("Enter your name: ");
string studentName = Console.ReadLine();

Console.WriteLine("Enter the number of subject have taken: ");
int numberOfSubjects = Convert.ToInt32(Console.ReadLine());

//Creating a method to find the average  
static double getAverage(Dictionary<string,double> subjectGradePair){
    double summation = 0;

    foreach(KeyValuePair<string, double> entry in subjectGradePair){
        summation += entry.Value;
    }

    return summation/(subjectGradePair.Count);
}
// Creating a dictionary to store subject-grade pairs
Dictionary<string, double>  subjectGradePair = new Dictionary<string, double>();

string suffix;

for (int subjectNumber = 1; subjectNumber < numberOfSubjects + 1; subjectNumber++)
{   
    if (subjectNumber == 1){
        suffix = "st";
    }
    else if (subjectNumber == 2){
        suffix = "nd";
    }
    else if (subjectNumber == 3){
        suffix = "rd";
    }
    else{
        suffix = "th";
    }

    Console.WriteLine($"What is the name of {subjectNumber}{suffix}: ");
    string subjectName = Console.ReadLine();

    Console.WriteLine($"What grade did you receive in {subjectName}? ");
    double subjectGrade = Convert.ToDouble(Console.ReadLine());

    while (subjectGrade < 0 || subjectGrade  > 100){
        Console.WriteLine("Invalid Grade!! Your subject Grade has to be in range 0-100, Enter a valid Grade");
        subjectGrade = Convert.ToDouble(Console.ReadLine());
    }

    subjectGradePair.Add(subjectName, subjectGrade);
    
    
}

Console.WriteLine($"Hello {studentName}!");

foreach(KeyValuePair<string, double> entry in subjectGradePair){
    Console.WriteLine($"On {entry.Key} your grade is: {entry.Value}"); 
}

Console.WriteLine($"Your calculated average is: {getAverage(subjectGradePair)}"); 











