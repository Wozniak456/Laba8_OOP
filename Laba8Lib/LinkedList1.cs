using Laba8Lib;
using System.Collections;
using System.Collections.Generic;
 
namespace SimpleAlgorithmsApp
{
    public class LinkedList1 : IEnumerable<float>  // односвязный список
    {
        Node head; // головной/первый элемент
        Node tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке
        public void Add(float data)//добавляє в кінець(в tail)
        {
            Node newEl = new Node(data);

            if (head == null)
                head = newEl;
            else
                tail.Next = newEl;
            tail = newEl;

            count++;
        }
        // видалення елементів
        public void Remove(float data)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (current.Data.Equals(FindElsThatLess(data)))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                }
                previous = current;
                current = current.Next;
            }
        }
        public int FindNumOfElsThatMore(float data)//знайти кількість елементів, які більші за data
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Data > data)
                    count++;
                current = current.Next;
            }
            return count;
        }
        public float FindElsThatLess(float data)//знайти елемент, який менший за data
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data < data)
                    return current.Data;
                current = current.Next;
            }
            return 0;
        }
        //для перебору списка
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<float> IEnumerable<float>.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}