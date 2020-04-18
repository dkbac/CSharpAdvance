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

            //HashTable
            // a collection store and manage a list of items using Key-Value
            // Empty
            Hashtable hashTable = new Hashtable();
            // With Capacity
            Hashtable capacityHashTable = new Hashtable(10);
            // Example
            hashTable.Add("Bac", "Dau Khac Bac");
            hashTable.Add("Nam", "Dau Khac Nam");
            hashTable.Add("Dong", "Dau Khac Dong");
            // A Key-Value in HashTable is a dictionary entry.
            Console.WriteLine("Hash Table");
            // If the Key is not add yet then return null, not through exception.
            Console.WriteLine("Access a no existing value: " + hashTable["Tay"]);
            // Update the element
            hashTable["Bac"] = "Awsome";
            // If the Key is not exist yet then add ann assign the value.
            hashTable["Tay"] = "Dau Khac Tay";
            // Id we add a key already exist, it will through the exception.
            if (!hashTable.ContainsKey("Tay"))
                hashTable.Add("Tay", "Tay Doc");
            // Access each hash table element via DictionaryEntry
            foreach(DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
                Console.WriteLine(hashTable[item.Key]);
            }

            //SortedList
            // A collection store by Key-Value
            // Similar with HasTable but sorted by Key
            // Need new
            SortedList sortedList = new SortedList();
            // Capacity
            SortedList capacitySortedList = new SortedList(10);
            // Copy from other sortedList
            SortedList copySortedList = new SortedList(sortedList);
            // Can define how to sort via the interface IComparer
            SortedList customSortedList = new SortedList(new PersonComparer());
            // Can copy from other sorted list and define how to sort
            SortedList copyCustomSortedList = new SortedList(capacitySortedList, new PersonComparer());
            //Example
            SortedList exampleSortedList = new SortedList(new PersonComparer());
            exampleSortedList.Add(new Person("Dau Khac Bac", 25), "Developer");
            exampleSortedList.Add(new Person("Dau Khac Linh", 38), "Teacher");
            exampleSortedList.Add(new Person("Dau Khac Manh", 34), "Developer");
            exampleSortedList.Add(new Person("Dau Khac Ngoc", 35), "Farmer");

            Console.WriteLine("Sorted List");
            foreach (DictionaryEntry item in exampleSortedList)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            //Stack
            // LIFO
            // Store a list of item
            // Push = add first
            // Pop = remove first
            // Peek = get first
            // Example
            Stack stack = new Stack();
            // Capacity
            Stack capacityStack = new Stack(10);
            // Can convert ArrayList to Stack
            ArrayList arrayStack1 = new ArrayList();
            arrayStack1.Add(1);
            arrayStack1.Add(2);
            arrayStack1.Add(3);
            arrayStack1.Add(4);
            arrayStack1.Add(5);
            arrayStack1.Add(6);

            Stack arrayStack2 = new Stack(arrayStack1);
            //
            Stack exampleStack = new Stack();
            exampleStack.Push("Bac");
            exampleStack.Push("Nam");
            exampleStack.Push("Dong");
            exampleStack.Push("Tay");

            foreach(var item in exampleStack)
            {
                Console.WriteLine(item.ToString());
            }
            //Count
            Console.WriteLine("Count Stack:" + exampleStack.Count);
            // Peek
            Console.WriteLine("Peek:" + exampleStack.Peek());
            // Pop
            Console.WriteLine("Popping");
            exampleStack.Pop();
            Console.WriteLine("Count: " + exampleStack.Count);

            //Queue
            // FIFO
            // Store a list of item
            // Enqueue
            // Dequeue
            // Peek
            // Example
            Queue queue = new Queue();
            // Capacity
            Queue capacityQueue = new Queue(10);
            // Can convert from an arraylist
            ArrayList arrayQueue1 = new ArrayList();
            arrayStack1.Add(1);
            arrayStack1.Add(2);
            arrayStack1.Add(3);
            arrayStack1.Add(4);
            arrayStack1.Add(5);
            arrayStack1.Add(6);

            Queue arrayQueue2 = new Queue(arrayQueue1);
            //
            Queue exampleQueue = new Queue();
            exampleQueue.Enqueue("Bac");
            exampleQueue.Enqueue("Nam");
            exampleQueue.Enqueue("Dong");
            exampleQueue.Enqueue("Tay");

            foreach (var item in exampleQueue)
            {
                Console.WriteLine(item.ToString());
            }
            //Count
            Console.WriteLine("Count Stack:" + exampleQueue.Count);
            // Peek
            Console.WriteLine("Peek:" + exampleQueue.Peek());
            // Pop
            Console.WriteLine("Popping");
            exampleQueue.Dequeue();
            Console.WriteLine("Count: " + exampleQueue.Count);

            //BitArray
            // Store a list of bit by true/false
            // Using this instead of bool[] because it save the memory
            // Canot define a BitArray empty
            BitArray bitArray = new BitArray(10);
            // Change the default value to true
            BitArray trueBitArray = new BitArray(10, true);

        }

        class Person {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                return this.Name + "-" + this.Age;
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
