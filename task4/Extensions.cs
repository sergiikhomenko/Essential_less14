using System.Collections;

namespace task4;
/*
   * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   * Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…}
   * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому
   * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який
   * повернув метод GetArray(), що розширює метод.
*/
public static class Extensions
{
    public static T[] GetArray<T>(this IEnumerable list)
    {
        List<T> result = new List<T>();
        foreach (T item in list)
        {
            result.Add(item);
        }
        return result.ToArray();
    }
}