using System;
					
public class Program
{
	public static bool isInShift(TimeSpan shiftStart,TimeSpan shiftEnd, DateTime currentTime){
		
		bool isShift = false;
		
		if ((shiftEnd > shiftStart && (currentTime.TimeOfDay > shiftStart || currentTime.TimeOfDay < shiftEnd))
   			|| (currentTime.TimeOfDay > shiftStart && currentTime.TimeOfDay < shiftEnd)){
			isShift = true;
		}
		
		return isShift;
	}
	
	public static void Main()
	{
		TimeSpan start = new TimeSpan(9,0,0);
		TimeSpan end = new TimeSpan(18,30,0);
		DateTime currentTime = DateTime.Now;
		
		bool isShift = isInShift(start,end,currentTime);
		
		Console.WriteLine(isShift);
	}
	
	
}