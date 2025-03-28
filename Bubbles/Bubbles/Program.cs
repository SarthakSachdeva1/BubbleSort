bool exit = false;
while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Array");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayArray(array);
                    break;
                case 2:
                    BubbleSort(array);
                    Console.WriteLine("Array sorted using Bubble Sort.");
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }




