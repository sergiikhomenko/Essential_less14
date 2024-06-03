using System.Collections;
using System.Linq.Expressions;

namespace task4;
/*
   * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   * Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…}
   * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому
   * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який
   * повернув метод GetArray(), що розширює метод.
*/
public class MyList<T>: IEnumerable<T>
{
    private T[] _items;
    private int _colom;

    public MyList()
    {
        _items = new T[4];
        _colom = 0;
    }

    public int Coloms
    {
        get { return _colom; }
    }

    public void Add(T item)
    {
        if (_items.Length <= _colom)
        {
            Array.Resize(ref _items,_colom*2);
        }
        _items[_colom++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (0 > index || index >= _colom)
            {
                throw new IndexOutOfRangeException("Вихід за межі");
            }
            return _items[index];
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int  i = 0;  i < _colom;  i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}