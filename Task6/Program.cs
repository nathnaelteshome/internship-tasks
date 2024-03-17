using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

TaskManager manager1 = new TaskManager();

manager1.AddTask(new Task { Name = "Clean Room", Description = "Description 1", Catagory = TaskCatagory.Personal, IsComplete = false });
manager1.AddTask(new Task { Name = "Go to Work", Description = "Description 2", Catagory = TaskCatagory.Work, IsComplete = false });
manager1.AddTask(new Task { Name = "Get Groccery", Description = "Description 3", Catagory = TaskCatagory.Errands, IsComplete = true });

manager1.ListTasks();
manager1.FilterTasks(TaskCatagory.Personal);
manager1.updateTask("Task 1", true);
manager1.ListTasks();

// create a filepath  and store in csv file
var csvPath = Path.Combine(Environment.CurrentDirectory, "tasks.csv");
StoreTasks(csvPath, manager1.ListTasks());
ReadTasks(csvPath);

/// Stores the list of tasks in a CSV file.
static void StoreTasks(string filePath, List<Task> tasks)
{
    try
    {
        if (!File.Exists(filePath))
        {
            using (File.Create(filePath)) { }
        }

        var configTasks = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
        };

        using (var writer = new StreamWriter(filePath))
        using (CsvWriter csvWriter = new CsvWriter(writer, configTasks))
        {
            csvWriter.WriteRecords(tasks);
            Console.WriteLine("Tasks have been stored in the file");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}


/// Reads the list of tasks from a CSV file.
static void ReadTasks(string filePath)
{
    try
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Task>().ToList();
            foreach (var task in records)
            {
                Console.WriteLine($"Name : {task.Name}, Description: {task.Description}, Catagory: {task.Catagory}, IsComplete: {task.IsComplete} ");
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");

    }
}

// enum TaskCatagory
public enum TaskCatagory
{
    Personal,
    Work,
    Errands
}

// Task class with object initializer
public class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskCatagory Catagory { get; set; }
    public bool IsComplete { get; set; }
}

/// <summary>
/// Task manager class with adding, listing, filtering, and updating functionality.
/// </summary>
public class TaskManager
{
    private List<Task> tasks = new List<Task>();
    private List<Task> FilteredTasks = new List<Task>();

    /// <summary>
    /// Adds a task to the task manager.
    /// </summary>
    /// <param name="task">The task to be added.</param>
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    /// <summary>
    /// Lists all the tasks in the task manager.
    /// </summary>
    /// <returns>The list of tasks.</returns>
    public List<Task> ListTasks()
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine(
                $"Name : {task.Name}, Description: {task.Description}, Catagory: {task.Catagory}, IsComplete: {task.IsComplete} ");
        }
        return tasks;
    }

    /// <summary>
    /// Filters the tasks based on the specified category.
    /// </summary>
    /// <param name="catagory">The category to filter the tasks by.</param>
    public void FilterTasks(TaskCatagory catagory)
    {
        FilteredTasks = tasks.Where(t => t.Catagory == catagory).ToList();

        foreach (var task in FilteredTasks)
        {
            Console.WriteLine($"Name : {task.Name}, Description: {task.Description}, Catagory: {task.Catagory}, IsComplete: {task.IsComplete} ");
        }
    }

    /// <summary>
    /// Updates the completion status of a task.
    /// </summary>
    /// <param name="name">The name of the task to update.</param>
    /// <param name="IsComplete">The new completion status of the task.</param>
    public void updateTask(string name, bool IsComplete)
    {
        foreach (var task in tasks)
        {
            if (name == task.Name)
            {
                task.IsComplete = IsComplete;
            }
        }
    }

    /// <summary>
    /// Reads the list of tasks from a CSV file.
    /// </summary>
    /// <param name="filePath">The file path of the CSV file.</param>
    public async void ReadTasks(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Task>().ToList();
                Console.WriteLine(records);
                // return the list of records read from the csv file

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");

        }
    }

}


