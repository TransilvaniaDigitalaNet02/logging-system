using LoggingSystem.Library;

namespace LoggingSystem.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // app startup
            ApplicationLog.Initialize(new FileLogger(@"D:\FastTrackIT\TransDigitala\logging-system"));

            // app codebase
            int n = ConsoleHelper.ReadNumber("No. of elements=", 3, 0);
            if (n <= 0)
            {
                ApplicationLog.Write(LogLevel.High, $"Array size ({n}) is negative, or zero");
                return;
            }

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"Element at index {i}=", 3, 0);
                if (element < 0)
                {
                    ApplicationLog.Write(LogLevel.Warning, $"Element at index {i} has a negative value: {element}");
                }

                array[i] = element;
            }

            ConsoleHelper.PrintArray("Array=", array);
        }
    }
}