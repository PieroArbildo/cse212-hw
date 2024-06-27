public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
        _queue.Sort((x, y) => x.Priority.CompareTo(y.Priority)); // Sort by priority
    }

    public String Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            //Console.WriteLine("The queue is empty.");
            throw new InvalidOperationException("No one in the queue.");
            //return null;
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++)
        { // _queue.Count -1 The "-1" was removed so that it does not take the penultimate highest priority, but rather the last highest
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex); // RemoveAt method was added that takes the last index
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}