﻿using System;
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
                _list[i + 1] = i;
            }

            // Insert the new value at the start of the list
            _list[0] = value;
            ++_size;
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
