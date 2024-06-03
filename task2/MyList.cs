using System.Collections;
using System.Linq.Expressions;

namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть колекцію MyList. Реалізуйте у найпростішому наближенні можливість
 * використання її екземпляра аналогічно екземпляру класу List. Мінімально
 * необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання
 * елемента, індексатор для отримання значення елемента за вказаним індексом і
 * властивість тільки для читання для отримання загальної кількості елементів.
 * Реалізуйте можливість перебору елементів колекції у циклі наперед
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