namespace HelloCSharp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Happy new year!!");
	double bmi = BMICalculator.GetBMI(63, 1.68);
	Console.WriteLine("And your BMI is: " + bmi);
	Console.WriteLine("Press any key to exit!!!");
	Console.ReadLine();
    }
}
