// See https://aka.ms/new-console-template for more information

class Employee
{
    public string name;
    public int salary;

    public void printUserImput()
    {
        foreach (Employee emp in Employee) // här vill jag loopa igenom objektets egenskaper men vet inte hur man gör.
        {
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.salary);
        }

    }
    public void getUserImput()
    {
        string endProgram = string.Empty;

        do
        {
            Console.WriteLine("Skriv den anställdes namn: ");
            name = Console.ReadLine();
            Console.WriteLine("Skriv den anställdes lön: ");
            salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("När du vill avsluta, tryck på X, Vill du registrera en ny anställd tryck valfri tangent förutom X. ");
            endProgram = Console.ReadLine(); 
        }
        while (endProgram != "x");
    }
}

class PersonalRegister
{

    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.getUserImput();
        emp.printUserImput(); 
    }
}