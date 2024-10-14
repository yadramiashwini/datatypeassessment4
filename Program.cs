namespace datatypeassessment4
{
public class Program
    {
        public static void Main(string[] args)
        {
            // Declare variables for each data type
            int intValue;
            float floatValue;
            double doubleValue;
            long longValue;
            string stringValue;

            // Get user input for each data type
            Console.Write("Enter an integer: ");
            intValue = int.Parse(Console.ReadLine());

            Console.Write("Enter a float: ");
            floatValue = float.Parse(Console.ReadLine());

            Console.Write("Enter a double: ");
            doubleValue = double.Parse(Console.ReadLine());

            Console.Write("Enter a long: ");
            longValue = long.Parse(Console.ReadLine());

            Console.Write("Enter a string: ");
            stringValue = Console.ReadLine();

            // Display the values
            Console.WriteLine(intValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(longValue);
            Console.WriteLine(stringValue);
        }
    }
}

