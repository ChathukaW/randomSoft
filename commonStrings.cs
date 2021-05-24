using System;
using System.Linq;  

public class Program
{
	public static void Main()
	{
		string[] arr1 ={"cat", "monkey", "car", "house", "computer"};  
        string[] arr2 ={"cat", "car", "computer"};  

		//linq function 'Intersect' is used to intersect the two arrays to get the common values to another array
        var intersect = arr1.Intersect(arr2);  
  
        foreach (string common in intersect)  
        {  
            Console.WriteLine(common);  
        } 
	}
}