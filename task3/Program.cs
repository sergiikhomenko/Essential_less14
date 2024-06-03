namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість
 * використання її екземпляра аналогічно екземпляру класу Dictionary.
 * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод
 * додавання елемента, індексатор для отримання значення елемента за вказаним
 * індексом і властивість тільки для читання для отримання загальної кількості
 * елементів. Реалізуйте можливість перебору елементів колекції у циклі наперед.
 */
class Program
{
    static void Main(string[] args)
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
        myDictionary.Add(1,"One");
        myDictionary.Add(2,"Two");
        Console.WriteLine(myDictionary.Coloms);
        Console.WriteLine(myDictionary[1]);
        foreach (var item in myDictionary)
        {
            Console.WriteLine(item);
        }
    }
}