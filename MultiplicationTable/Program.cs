//Kyson Hensley
//RCET2265
//Fall 2025
//Mulitplication Table Program
//https://github.com/kysonhensley/MultiplicationTable.git


namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 12; // default size of table

            Console.Write("Enter table size: ");

            string input = Console.ReadLine();

            if (input != "") // check for no input
            {
                size = int.Parse(input);
            }

            Console.WriteLine("Enjoy your " + size + " x " + size + " Multiplication Table:");

            PrintTable(size);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static void PrintTable(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    Console.Write("{0,4}", row * col); // aligns numbers
                }
                Console.WriteLine();
            }
        }
    }
}
