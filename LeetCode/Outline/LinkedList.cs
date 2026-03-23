using System;
using System.Collections;
using System.Numerics;

namespace LeetCode.Outline;

/// <summary>
/// Simple linked list
/// </summary>
/// <typeparam name="T"></typeparam>
public class LinkedList<T> : IEnumerable<T> where T : IEqualityOperators<T, T, bool>
{
    private Node? Head { get; set; }

    public void InsertBack(T value)
    {
        var newNode = new Node { Value = value, Next = null };
        if (Head is null)
        {
            Head = newNode;
            return;
        }

        var current = Head;
        while (current!.HasNext())
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public void InsertFront(T value)
    {
        var next = Head;
        Head = new Node { Value = value, Next = next };
    }

    public void Delete(T value)
    {
        if (Head is null) return;

        if (Head.Value == value)
        {
            Head = Head.Next;
            return;
        }

        var current = Head.Next;
        var previus = Head;
        while (current is not null)
        {
            var next = current.Next;

            if (current.Value == value)
            {
                previus.Next = next;
                return;
            }

            previus = current;
            current = next;
        }


    }

    private Node? Search(T value)
    {
        if (Head is null) return null;

        var current = Head;
        while (current is not null)
        {
            if (current.Value == value) return current;
            current = current.Next!;
        }

        return null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        while(current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class Node
    {
        public required T Value { get; set; }
        public Node? Next { get; set; }

        public bool HasNext()
        {
            return Next is not null;
        }
    }
}
