using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDataStructure
{
    public class MyArrayList
    {
        // Internal array to hold the elements of the list
        int[] _list;
        // Tracks the current number of elements in the list
        int _size = 0;
        // Public property to get the current number of elements
        public int Size { get { return _size; } }
        // Public property to get the internal array (not recommended for modification outside the class)
        public int[] List { get { return _list; } }

        // Default constructor initializing the internal array with a capacity of 10
        public MyArrayList()
        {
            _list = new int[10];
        }

        // Constructor initializing the internal array with a given size
        public MyArrayList(int size)
        {
            _list = new int[size];
        }

        /// <summary>
        /// Will add the incoming value to the end of the list
        /// </summary>
        public void Append(int value) 
        {
            // Ensure there is enough capacity to add the new element
            IncreaseCapacity();
            // Add the new value at the end of the list
            _list[_size++] = value;
        }

        /// <summary>
        /// Adds the incoming value to the start of the list
        /// </summary>
        public void AddStart(int value)
        {
            // Ensure there is enough capacity to add the new element
            IncreaseCapacity();
            // Shift all elements to the right to make room for the new element at the start
            for (int i = _size; i >= 0; i--)
            {
                // _list[i + 1] = i; method contains a logical error where it
                // incorrectly assigns the index values instead of the element values
                _list[i + 1] = _list[i];
            }

            // Insert the new value at the start of the list
            _list[0] = value;
            ++_size;
        }

        public void Insert(int value, int indexToInsertAt)
        {
            if (indexToInsertAt < 0 || indexToInsertAt > _size)
            {
                throw new IndexOutOfRangeException($"Index {indexToInsertAt} is invalid");
            }
            // Ensure there is enough capacity to add the new element
            IncreaseCapacity();
            for (int i = _size -1; i >= indexToInsertAt; i--)
            {
                // _list[i + 1] = i; method contains a logical error where it
                // incorrectly assigns the index values instead of the element values
                _list[i + 1] = _list[i];
            }

            _list[indexToInsertAt] = value;
            ++_size;
        }

        public void DeleteStart()
        {
            DeleteFromIndex(0); // Called DeleteFromIndex() method
        }

        public void DeleteEnd()
        {
            if ((_size - 1) == 0) return;   // This is not refractor, size not index
            _list[--_size] = 0;
        }

        public void DeleteFromIndex(int index)
        {
            // If the size of the list is less than or equal to 0, return immediately
            if (_size <= 0) return;
            for (int i = index; i < _size; i++)
            {
                if (i + 1 == _size)
                {
                    _list[i] = 0;
                    break;
                }
                _list[i] = _list[i + 1];
            }

            --_size;
        }

        // Private method to increase the capacity of the internal array when needed
        private void IncreaseCapacity()
        {
            // If the array has not reached its capacity, do nothing
            if (_size != _list.Length) return;
            // Double the size of the internal array
            int[] newArray = new int[_size * 2];
            // Copy existing elements to the new array
            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _list[i];
            }

            // Replace the old array with the new array
            _list = newArray;
        }
    }
}
