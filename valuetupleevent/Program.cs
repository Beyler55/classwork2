using System;
namespace valuetupleevent
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lb = new Library();
            Console.WriteLine("1-Add employee  3-Add book  3-Remove employee  4-Remove book");
            string result = Console.ReadLine();
            while (true)
            {
                switch (result)
                {
                    case "1":
                        Employee emp = new Employee();
                        Console.Write("Enter employee name :  ");
                        string name = Console.ReadLine();
                        emp.Name = name;
                        Console.Write("Enter employee surname :  ");
                        string surname = Console.ReadLine();
                        emp.Surname = surname;
                        Console.Write("Enter employee age :  ");
                    INPUTAGE:
                        string age = Console.ReadLine();
                        bool isStAge = int.TryParse(result, out int employeerage);
                        if (!isStAge)
                        {
                            Console.WriteLine("Enter age correctly!!");
                            goto INPUTAGE;
                        }
                        emp.Age = employeerage;
                        lb.employees.Add(emp);
                        break;
                    case "2":
                        Book bk = new Book();
                        name = Console.ReadLine();
                        bk.Name = name;
                        Console.Write("Enter book type:");
                        string booktype = Console.ReadLine();
                        bk.Type = booktype;
                        break;
                    case "3":
                        Console.WriteLine("Enter employeer id which you want to remove :  ");
                        string remId = Console.ReadLine();
                        bool isremId = int.TryParse(result, out int employeerId);
                        if (!isremId)
                        {
                            Console.WriteLine("Enter age correctly!!");
                            goto case "3";
                        }
                        foreach (var item in lb.employees)
                        {
                            if (item.ID == employeerId)
                            {
                                lb.employees.Remove(item);
                                Console.WriteLine($"{item} is removed from employees.");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter book id which you want to remove :  ");
                        string empId = Console.ReadLine();
                        bool isemId = int.TryParse(result, out int bookId);
                        if (!isemId)
                        {
                            Console.WriteLine("Enter id correctly!!");
                            goto case "3";
                        }
                        foreach (var item in lb.books)
                        {
                            if (item.ID == bookId)
                            {
                                lb.books.Remove(item);
                                Console.WriteLine($"{item} is removed from employees.");
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

        }

    }

}
