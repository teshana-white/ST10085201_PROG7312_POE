using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class MinHeap<T> where T : IComparable<T>
    {
        private readonly List<T> heap = new List<T>();

        public void Insert(T item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        public T ExtractMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty");

            T min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return min;
        }

        public int Count => heap.Count;

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;

                if (heap[index].CompareTo(heap[parent]) >= 0) break;

                Swap(index, parent);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index * 2 + 1 < heap.Count)
            {
                int left = index * 2 + 1;
                int right = index * 2 + 2;
                int smallest = left;

                if (right < heap.Count && heap[right].CompareTo(heap[left]) < 0)
                    smallest = right;

                if (heap[index].CompareTo(heap[smallest]) <= 0) break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int i, int j)
        {
            T temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
