using System;
using System.Numerics;

namespace LeetCode.Outline;


/// <summary>
/// Simple ASC sorted array
/// </summary>
/// <typeparam name="T">Type of array's values</typeparam>
public class SortedArray<T> where T : IComparisonOperators<T, T, bool>
{
    public const int MAX_BUFFER = 10;
    public int Buffer { get; private set; } = MAX_BUFFER;
    public int Length { get; private set; } = 0;
    public T[] Data { get; private set; } = new T[MAX_BUFFER];

    /// <summary>
    /// Insert value into sorted array
    /// </summary>
    /// <param name="value">Value for insert</param>
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

    /// <summary>
    /// Search index in sorted array liner
    /// </summary>
    /// <param name="value">Value for search</param>
    /// <returns></returns>
    public int SearchIndexLiner(T value)
    {
        if (Length == 0) return -1;

        for (var i = 0; i < Length; i++)
        {
            if (Data[i] == value)
                return i;
        }

        return -1;
    }

    /// <summary>
    /// Search index in sorted array binary
    /// </summary>
    /// <param name="value">Value for search</param>
    /// <returns></returns>
    public int SearchIndexBinary(T value)
    {
        if (Length == 0) return -1;

        int left = 0;
        int right = Length - 1;

        while(right >= left)
        {
            var mid = (right + left) / 2;

            if (value == Data[mid])
                return mid;

            if (value > Data[mid])
            {
                left = mid + 1;
            }
            else if (value < Data[mid])
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}