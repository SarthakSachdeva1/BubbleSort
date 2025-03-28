
while (true) // Infinite loop to keep the program running until the user chooses to exit

{
   // Display menu options to the user

  Console.WriteLine("Choose an option:");
   Console.WriteLine("1. Use a prefilled array of 10 items");
   Console.WriteLine("2. Enter your own array");
   Console.WriteLine("3. Exit program");
   Console.Write("Enter your choice (1, 2, or 3): ");
   int choice = int.Parse(Console.ReadLine()); // Read and parse the user's choice

   int[] array; // Declare an array to hold the integers
 
   if (choice == 3) // If the user chooses to exit
   {
       Console.WriteLine("Exiting the program. Goodbye!");
       break; // Exit the loop and end the program
   }
 
   if (choice == 1) // If the user chooses the prefilled array
   {
       // Prefilled array of 10 items
       array = new int[] { 45, 23, 78, 12, 89, 34, 67, 91, 10, 56 };
       Console.WriteLine("Using prefilled array.");
   }


   else if (choice == 2) // If the user chooses to enter their own array
      {
       // Input-based array
       Console.Write("Enter the size of the array: ");
       int size = int.Parse(Console.ReadLine()); // Read and parse the size of the array
       array = new int[size]; // Initialize the array with the specified size
 
       Console.WriteLine("Enter the elements of the array:");

       for (int i = 0; i < size; i++) // Loop to read each element of the array
       {
         Console.Write($"Element {i + 1}: ");
         array[i] = int.Parse(Console.ReadLine()); // Read and parse each element
       }

   }

   else // If the user enters an invalid choice
   {
      Console.WriteLine("Invalid choice. Please try again.");
       return; // Exit the current iteration and prompt the user again
   }
 
   Console.WriteLine("\nArray before sorting:");


   DisplayArray(array); // Display the array before sorting
 
   // Bubble Sort


   BubbleSort(array); // Sort the array using Bubble Sort
 
   Console.WriteLine("\nArray after sorting:");


   DisplayArray(array); // Display the array after sorting


}
 
// Method to perform Bubble Sort on an array


static void BubbleSort(int[] array)
{

   int n = array.Length;

   for (int i = 0; i < n - 1; i++) // Outer loop for each pass
   {
     for (int j = 0; j < n - i - 1; j++) // Inner loop for each comparison
       {
           if (array[j] > array[j + 1]) // If the current element is greater than the next elemen

           {


               // Swap array[j] and array[j + 1]


               int temp = array[j];


               array[j] = array[j + 1];


               array[j + 1] = temp;


           }


       }


   }


}
 
// Method to display the elements of an array


static void DisplayArray(int[] array)


{


   foreach (var item in array) // Loop through each element in the array


   {


       Console.Write(item + " "); // Print each element followed by a space


   }


   Console.WriteLine(); // Print a newline at the end


}
 