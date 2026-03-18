using System;
using System.Numerics;

namespace LeetCode.Outline;

public class SortedArray<T> where T : IComparisonOperators<T, T, bool>
{
    public const int MAX_BUFFER = 10;
    public int Buffer { get; private set; } = MAX_BUFFER;
    public int Length { get; private set; } = 0;
    public T[] Data { get; private set; } = new T[MAX_BUFFER];

    public void Insert(T value)
    {

        if (Buffer < MAX_BUFFER / 2)
        {
            var diff = MAX_BUFFER - Buffer;
            var newData = new T[Data.Length + diff];
            Data.CopyTo(newData, 0);
            Data = newData;

            Buffer = MAX_BUFFER;

        }

        Data[Length] = value;
        for (int i = Length - 1; i >= 0; i--)
        {
            if (Data[i] > Data[i + 1])
            {
                (Data[i + 1], Data[i]) = (Data[i], Data[i + 1]);
            } else
                break;
        }

        Length++;
        Buffer--;
    }
}