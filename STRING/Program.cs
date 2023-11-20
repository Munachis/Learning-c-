using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Work
{
    
    static void Main(string[] args)
    {
        //var cities = new SortedSet<string>();

        //states();
        Console.WriteLine(ParrotTrouble(true, 7)); 
    }

    static string ParrotTrouble(bool options, int no)
    {
        for (int i = 0; i < no; i++)
        {
             
        }

        if (no > 23)
        {
            return "Hour should be in between 0 - 23";
        }
        else if (no < 7 || no > 20 && options == true) 
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }
    static void store()
    {
        Dictionary<string, int> receipt = new Dictionary<string, int>();

        Console.WriteLine("Welcome to the Supermarket!");
        bool option = true;
        while (option = true)
        {
            Console.Write("Enter the item name (or type 'n' to finish) ");
            string itemName = Console.ReadLine().ToLower();

            if (itemName == "n")
            {
                break;
            }

            
            int quantity = 1;

            
            if (receipt.ContainsKey(itemName))
            {
                receipt[itemName] += quantity;
            }
            else
            {
                receipt.Add(itemName, quantity);
            }
        }

        Console.WriteLine("\n The Receipt");


        foreach (var kvp in receipt)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }

        Console.WriteLine("Thank you for shopping with us!");
    }


static void LinkedList()
{
    var subjects = new LinkedList<string>();
    LinkedListNode<String> node = subjects.Find("Biology");
    subjects.AddAfter(node, "Mathematics");
    subjects.AddBefore(node, "Fishery");
    subjects.AddLast("Physics");
    subjects.AddLast("Biology");
    subjects.AddLast("Chemistry");

    foreach (var subject in subjects)
    {
        Console.WriteLine(subject);
    }
}
static void stack() 
    {
        var names = new Stack<string>();
        names.Push("Iwase");
        names.Push("Godrice");
        names.Push("Blessing");
        names.Push("Gaadi");
        names.Push("Munachi");
        names.Pop();
        names.Peek();

        foreach (var name in names)
        {
            Console.WriteLine(name);

        }
    }
    static void states()
    {
        Queue<string> states = new Queue<string>();
        states.Enqueue("Ibadan");
        states.Enqueue("Lagos");    
        states.Enqueue("Port Harcourt");
        states.Enqueue("Lokoja");
        states.Enqueue("Ibadan");
        states.Dequeue();

        foreach (var state in  states)
        {
            Console.WriteLine(state);
        }
    }
    static void products()
    {
        var Products = new HashSet<string>();
        Products.Add("Anambra");
        Products.Add("Osun");
        Products.Add("Cross River");
        Products.Add("Osun");
        Products.Remove("Anambra");

        for (int i = 0; i < Products.Count; i++)
        {
            if (Products.Contains("Anambra"))
            {
                Products.Remove("Anambra");
            }
            else
            {
                Console.WriteLine("Anambra is not there");
            }



        }
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
    }
    
    



    static void task()
    {
        bool options = true;
        var tasks = new List<string>();
        int i = 0;
        do
        {
            
            Console.WriteLine("Input your tasks");

                tasks.Add(Console.ReadLine());

            Console.WriteLine("Do you want to Continue (Y or N)");
            string name = Console.ReadLine();
            char Lowered = Convert.ToChar(name.ToLower());
            if (Lowered != 'y')
            {
               options = false;
            }
             
            

            

        } while(options==true);
        Console.WriteLine("Your tasks are below");
        

        foreach (var task in tasks)
        {
            
            i+=1;
            Console.WriteLine(i +". "+ task);
        }
    }


    
    

    static void TaskManager()
    {
        bool options = true;
        var tasks = new List<string>();
        int i = 0;

        do
        {
            Console.WriteLine("Input your tasks");
            tasks.Add(Console.ReadLine());

            Console.WriteLine("Do you want to Continue (Y or N)");
            string response = Console.ReadLine();
            char Lowered = Convert.ToChar(response.ToLower());
            if (Lowered != 'y')
            {
                options = false;
            }

        } while (options);

        Console.WriteLine("Your tasks are below");

        DisplayTasks(tasks);

        Console.WriteLine("Do you want to update or delete a task? (U for Update, D for Delete, any other key to exit)");
        char choice = Convert.ToChar(Console.ReadLine().ToLower());

        switch (choice)
        {
            case 'u':
                UpdateTask(tasks);
                break;
            case 'd':
                DeleteTask(tasks);
                break;
            default:
                break;
        }
    }

    static void DisplayTasks(List<string> tasks)
    {
        int i = 0;
        foreach (var task in tasks)
        {
            i++;
            Console.WriteLine(i + ". " + task);
        }
    }

    static void UpdateTask(List<string> tasks)
    {
        Console.WriteLine("Enter the number of the task you want to update:");
        int taskNumber = Convert.ToInt32(Console.ReadLine()) -1;

        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            Console.WriteLine("Current task: "+ tasks[taskNumber]);
            Console.WriteLine("Enter the updated task:");
            tasks[taskNumber] = Console.ReadLine();
            Console.WriteLine("Task updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }

        DisplayTasks(tasks);
    }

    static void DeleteTask(List<string> tasks)
    {
        Console.WriteLine("Enter the number of the task you want to delete:");
        int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            Console.WriteLine($"Deleted task: {tasks[taskNumber]}");
            tasks.RemoveAt(taskNumber);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }

        DisplayTasks(tasks);
    }
}

    

