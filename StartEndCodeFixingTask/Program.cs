namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            Console.WriteLine("Enter start year: ");
            int startyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end year: ");
            int endyear = Convert.ToInt32(Console.ReadLine());

            if (startyear < endyear && 2000 > startyear) 
            { 
                int difference = endyear - startyear;
                Console.WriteLine("The differenc between the years are: " + difference);
            }

        }
    }
}
