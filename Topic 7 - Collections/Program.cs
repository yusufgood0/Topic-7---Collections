
using System.Collections.Generic;

namespace Topic_7_collections
{
    internal class Program
    {
        static readonly (string Option, string Question)[] Options =
        {
            ("1 – Remove a vegetable by index", "Enter an index of an item to remove"),
            ("2 – Remove a vegetable by value", "Enter a vegetable of an item to remove"),
            ("3 – Search for a vegetable", "Enter a vegetable to search for"),
            ("4 – Add a vegetable", "Enter a vegetable to add to the list"),
            ("5 – Sort list", "List Sorted"),
            ("6 – Clear the list", "List Cleared"),
        };
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            string stringInput;
            int intInput;



            myList.Add("CARROT");
            myList.Add("BEET");
            myList.Add("CELERY");
            myList.Add("RADISH");
            myList.Add("CABBAGE");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nCurrent List:");
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine($"{i}: {myList[i]}");
                }

                Console.WriteLine("\nOptions:");
                foreach ((string Option, string Question) option in Options)
                {
                    Console.WriteLine(option.Option);
                }
                Console.Write("Select an option: ");



                while (!int.TryParse(Console.ReadLine(), out intInput) || intInput < 0 || intInput > Options.Length)
                {
                    Console.WriteLine("Invalid Menu Option. Try again: ");
                }

                Console.WriteLine(Options[intInput - 1].Question);

                switch (intInput)
                {
                    case 1:
                        if (int.TryParse(Console.ReadLine(), out intInput))
                        {
                            if (intInput >= 0 && intInput < myList.Count)
                            {
                                myList.RemoveAt(intInput);
                                Console.WriteLine($"Item at index {intInput} removed.");
                            }
                            else
                            {
                                Console.WriteLine("Index out of range. No item removed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index input.");
                        }
                        break;
                    case 2:
                        stringInput = Console.ReadLine().ToUpper();
                        if (myList.Contains(stringInput))
                        {
                            myList.Remove(stringInput);
                            Console.WriteLine($"Item {stringInput} was removed.");
                        }
                        else
                        {
                            Console.WriteLine($"The list does not contain {stringInput}");
                        }
                        break;
                    case 3:
                        stringInput = Console.ReadLine().ToUpper();
                        if (myList.Contains(stringInput))
                        {
                            intInput = myList.IndexOf(stringInput);
                            Console.WriteLine($"Item {stringInput} found at index {intInput}.");
                        }
                        else
                        {
                            Console.WriteLine($"The list does not contain {stringInput}");
                        }
                        break;
                    case 4:
                        stringInput = Console.ReadLine().ToUpper();
                        if (!myList.Contains(stringInput))
                        {
                            myList.Add(stringInput);
                        }
                        else
                        {
                            Console.WriteLine($"The list already contains {stringInput}");
                        }
                        break;
                    case 5:
                        myList.Sort();
                        break;
                    case 6:
                        myList.Clear();
                        break;
                }

                Console.WriteLine("\nCurrent List:");
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine($"{i}: {myList[i]}");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
