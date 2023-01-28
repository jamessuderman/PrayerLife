﻿namespace PrayerLife.Helpers;

public static class ListHelper
{
    public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> newItems, bool clearFirst = false)
    {
        if (clearFirst)
        {
            collection.Clear();
        }

        newItems.ForEach(newItem => collection.Add(newItem));
    }

    public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
    {
        Random random = new Random();
        return source.OrderBy<T, int>(item => random.Next());
    }

    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
        foreach (var item in enumeration)
        {
            action(item);
        }
    }
}

