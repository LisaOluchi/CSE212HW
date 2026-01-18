/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _list = new();

    public int Length => _list.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _list.Add(person);
    }

    public Person Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidCastException("Queue is empty.");

        var person = _list[0];
        _list.RemoveAt(0);
        return person;
    }

    public bool IsEmpty() => _list.Count == 0;


    public override string ToString() => string.Join(", ", _list);

}
