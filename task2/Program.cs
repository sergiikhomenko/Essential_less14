namespace task2;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        Console.WriteLine($"Кількість елементів  {myList.Coloms}");
        Console.WriteLine($"Елемент за індексом {myList[1]}");
        foreach (var list in myList)
        {
            Console.WriteLine(list);
        }
    }
}