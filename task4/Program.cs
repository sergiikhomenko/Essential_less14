namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…}
 * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому
 * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який
 * повернув метод GetArray(), що розширює метод.
 */
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
        int[] arrey = myList.GetArray<int>();
        for (int i = 0; i < arrey.Length; i++)
        {
            Console.WriteLine(arrey[i]);
        }
       
    }
}