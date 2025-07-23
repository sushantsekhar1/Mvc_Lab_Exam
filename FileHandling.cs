using System;
namespace TestDemo
{
	public class FileHandling2
	{
		static void Main()
		{
			String filepath = "output1.txt";
			try
			{
				//Writing data Option 1
				using (StreamWriter writer = new StreamWriter(filepath))
				{
					writer.WriteLine("101,133,Sushant");
					writer.WriteLine("102,134,Sekhar");
					writer.WriteLine("103,136,Raj");
				}

				//Writing data Option 2
				Console.WriteLine("Enter the text you want to save : ");
				string input = Console.ReadLine();
				File.WriteAllText(filepath, input);
				Console.WriteLine("Data is entered sucessfully\n");

				//Read data Options 1

				Console.WriteLine("Writing Data");
				string[] content = File.ReadAllLines(filepath);
				foreach (var line in content)
				{
					Console.WriteLine(line);
				}

				// Read Data Options 2
				Console.WriteLine("\nWrititng Data");
				string contents = File.ReadAllText(filepath);
				Console.WriteLine(contents);
			}
			catch (Exception e)
			{
				Console.WriteLine("An error :" + e.Message);
			}
		}
	}
}

