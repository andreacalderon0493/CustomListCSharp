using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable 
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;
        //other way of using => is
        //public object MyProperty { get; set; }
        //property and then tab twice 
        public int Count => count;
        public int Capacity => count;
        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }
        

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];

        }




        //Member Methods (CAN DO)
        //Single Principle - creates code that does one thing which for loops the objects 
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        //Open-Close Principle
        //Allows the user to continuously add new arrays if capacity maxamixes and doubles it and creates a new array with old items
        //Allows for open for extension but closed for modification. 
        public void Add(T item)
        {
            

            //'item' parameter should be added to internal 'items' array
            if ( count == capacity)
            {
                
                capacity *= 2;
               
                T[] temporaryArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = items[i];
                }

                items = temporaryArray;

            }

            items[Count] = item;

            count++;


            //transfer all items to new array
        }
        //Open-Close Principle
        //Allows user to remove item from list and shift everything backwards. 
        //Allows for open for extension but closed for modification. 
        public bool Remove(T item)
        {

            for (int i = 0; i < count; i++)
            {
                if (Equals(item, items[i])) 
                {
                    items[i] = default (T);
                    
                    for (int j = i; j < count; j++)
                    {
                        if (j == count - 1)
                        {
                            items[j] = default(T);
                        }
                        else
                        {
                            items[j] = items[j + 1];
                        }
                    }
                    count--;
                    return true;
                } 
               
            }
            //If 'item' exists in the 'items' array, remove its first instance

            //Any items coming after the removed item should be shifted down so there is no empty index.

            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }
        //Single Responsibility - this ToString method does one thing only, allows to string what is in the custom list, int, string etc. 
        public override string ToString()
        {
            bool first = true;
            string list = "";
            for (int i = 0; i < count; i++)
            {
                if (!first)
                {
                    list += ", ";
                }
                else
                {
                    first = false;
                }
                list += $"{items[i]}";
            }
                
            //returns a single string that contains all items from array
            return list;
        }

        

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> totalList = new CustomList<T>();

            for (int i = 0; i < firstList.count; i++)
            {
                totalList.Add(secondList.items[i]);
            }
            for (int i = 0; i < secondList.count; i++)
            {
                totalList.Add(firstList.items[i]);
                     
            }
            totalList = firstList + secondList;
           

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return totalList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }

      
    }
}
