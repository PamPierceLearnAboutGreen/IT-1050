namespace IT1050Assignment2
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }
        public static int AskForInt(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return int.Parse(System.Console.ReadLine());
        }
        public static bool AskForBool(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }
    }
}
