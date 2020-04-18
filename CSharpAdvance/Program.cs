using System;
using System.Collections;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] newArray = new string[10];
            // static length
            // hard to remove, add
            // Get via index


            //Collection
            // System.Collections
            // Dynamic array
            // difine length is not necessary
            // Can store a list of many data type
            // Support many methods: search, sort, reverse,...
            // Need to initial instance when declare.
            // Can get using index or key 
            // Array faster then collection except HashTable
            // Need a list  that update always then using arralist
            // Stack (LIFO), queue (FIFO)
            // Array using strongly-type: the data type that not surdenly change and not clear.

            //Collections:
            // ArrayList: Similar to Array but can add/remove items and update item index more efficient and 
            // HashTable: Store data using Key-Value, get value via Key
            // SortedList: similar to HashTable but the elements sorted by Key
            // Stack: LIFO
            // Queue: FIFO
            // BitArray: Store true false.

            //ArrayList
            // A collection store and manage a list of items, similar to Array but support dynamic length and some methods to add and remove
            // Need to initial via new keyword
            ArrayList arrayList = new ArrayList();
            // Or can point out the capacity
            ArrayList capacityArrayList = new ArrayList(10);
            // Or can create and copy from other arraylist, clone to other memory
            ArrayList copyArrayList = new ArrayList(capacityArrayList);
            // Why not using this way
            // Because this is reference type, using the same memory, one change => both change
            ArrayList referenceArrayList = capacityArrayList;
            //Properties
            // Count - How many number of elements
            // Capacity - How many can store

            //Methods
            // Add(object)
            // AddRange(ListObject)
            // BinarySearch(object)
            // Clear() - clear all elements
            // Clone() - make a copy from current arraylist
            // Contains(object) - true/false
            // GetRange(start Index, end Index)
            // IndexOf(object) get index of object
            // Insert(index, object) 
            // InsertRange(index, listObject)
            // LastIndexOf(object)
            // Remove(object)
            // Reverse()
            // Sort()
            // ToArray()

            //Sort with multiple value
            // Sort(Icomparer comparer)
            ArrayList personList = new ArrayList();
            personList.Add(new Person("Nguyen Van A", 20));
            personList.Add(new Person("Nguyen Van B", 30));
            personList.Add(new Person("Nguyen Van C", 35));

            Console.WriteLine("Person:");
            foreach(Person person in personList)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }

            personList.Sort(new PersonComparer());

            Console.WriteLine("Person:");
            foreach (Person person in personList)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
        }

        class Person {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }

        class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;

                if (p1.Age < p2.Age)
                    return 1;
                else if (p1.Age > p2.Age)
                    return -1;
                else
                    return 0;
            }
        }

    }
}
