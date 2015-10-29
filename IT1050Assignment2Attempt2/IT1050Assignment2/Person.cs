namespace IT1050Assignment2
{
    class Person
    {
        public static int PersonCount;
        public static double AgeSum = 0;
        public int Age;
        public string FirstName;
        public string LastName;
        public string FullName;
        public bool IsMarried;
        public string Spouse;
        public int SpouseAge;
        public void GatherData()
        {
            PersonCount++;
            System.Console.WriteLine("Please answer the following about the next person:");
            FirstName = Question.AskForString("First Name");
            LastName = Question.AskForString("Last Name");
            Age = Question.AskForInt("Age");
            IsMarried = Question.AskForBool("Is this person married? (y/n)");
            AgeSum += this.Age;
            GetFullName();
        }
        public void GatherDataSpouse()
        {
            PersonCount++;
            FirstName = Question.AskForString("First Name");
            LastName = Question.AskForString("Last Name");
            Age = Question.AskForInt("Age");
            IsMarried = true;
            AgeSum += Age;
        }
        public string GetFullName()   // why do you want a string? why not void?  why write it when not used?
        {
            FullName = FirstName + " " + LastName;
            return FullName;                  
        }

    }
}
