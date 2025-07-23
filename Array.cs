using System;
namespace TestDemo
{
	public class ArrayDemo
	{
		static void Main()
		{
			Console.WriteLine("Enter the Array Size : ");
			int size = int.Parse(Console.ReadLine());

			int sum = 0;
			int[] arr = new int[size];

			//Length of Array
			int len = arr.Length;
			Console.WriteLine("Size of Array : " + len);


			//Sum of Array
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
				sum += arr[i];
			}
			Console.WriteLine("Sum of Array : " + sum);



			//Sort the Array
			Array.Sort(arr);
			Console.Write("Sort the Array : ");
			foreach (int num in arr)
			{
				Console.Write(num);
			}
			Console.WriteLine("\n");



			//Reverse the Array
			Array.Reverse(arr);
			Console.Write("Reverse the Array : ");
			foreach (int num in arr)
			{
				Console.Write(num);
			}


			//Search the value in Array
			Console.WriteLine("\nEnter the value you want to search : ");
			int num1 = int.Parse(Console.ReadLine());
			bool found = false;

			for (int i = 0; i < arr.Length; i++)
			{
				if (num1 == arr[i])
				{
					Console.WriteLine("Element is found in the index : " + i);
					found = true;
					break;
				}

			}
			if (!found)
			{
				Console.WriteLine("Element is not Found");
			}
		}
	}
}
// Using String
using System;

namespace TestDemo
{
    public class ReverseSingleString
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert to char array and reverse
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            string reversed = new string(chars);

            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}



