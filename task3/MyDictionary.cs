using System.Collections;

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

public class MyDictionary<TKey,KValue>:IEnumerable<KeyValuePair<TKey,KValue>>
{
    private List<TKey> _keys;
    private List<KValue> _values;
    private int _coloms;

    public MyDictionary()
    {
        _keys = new List<TKey>();
        _values = new List<KValue>();
        _coloms = 0;
    }

    public int Coloms
    {
        get { return _coloms; }
    }

    public KValue this[TKey key]
    {
        get
        {
            int index = _keys.IndexOf(key);
            return _values[index];
        }
    }

    public void Add(TKey key, KValue value)
    {
        if (_keys.Contains(key))
        {
            throw new ArgumentException("Такий ключ існує");
        }

        _coloms++;
        _keys.Add(key);
        _values.Add(value);
    }

    public IEnumerator<KeyValuePair<TKey, KValue>> GetEnumerator()
    {
        for (int  i = 0;  i < _keys.Count;  i++)
        {
            yield return new KeyValuePair<TKey, KValue>(_keys[i],_values[i]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}