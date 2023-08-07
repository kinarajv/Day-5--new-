namespace TrialProgram;

static class Program
{
	static void Main()
	{
		DaysOfWeek day1 = DaysOfWeek.Monday;
		Console.WriteLine(day1); // output:
		Console.WriteLine((int)day1);  // output:

		string userDays = "Monday";
		DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userDays);
		Console.WriteLine("Parsed enum value : " + day);
		Console.WriteLine("Parsed enum value : " + (int)day);

		Console.WriteLine((int)DaysOfWeek.Monday);
		DaysOfWeek y = (DaysOfWeek)0;
	}
}
public enum DaysOfWeek
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}