namespace IT1050Assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            Person individual1 = new Person();
            individual1.GatherData();
            if (individual1.IsMarried == true)
            {
                System.Console.WriteLine("Please answer the following about the Spouse:");
                Person spouse1 = new Person();
                spouse1.GatherDataSpouse();
                individual1.Spouse = spouse1.FirstName;
                individual1.SpouseAge = spouse1.Age;
            }

            Person individual2 = new Person();
            individual2.GatherData();
            if (individual2.IsMarried == true)
            {
                System.Console.WriteLine("Please answer the following about the Spouse:");
                Person spouse2 = new Person();
                spouse2.GatherDataSpouse();
                individual2.Spouse = spouse2.FirstName;
                individual2.SpouseAge = spouse2.Age;
            }
            Person individual3 = new Person();
            individual3.GatherData();
            if (individual3.IsMarried == true)
            {
                System.Console.WriteLine("Please answer the following about the Spouse:");
                Person spouse3 = new Person();
                spouse3.GatherDataSpouse();
                individual3.Spouse = spouse3.FirstName;
                individual3.SpouseAge = spouse3.Age;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Person #1 First Name    : " + individual1.FirstName);
            System.Console.WriteLine("Person #1 Last Name     : " + individual1.LastName);
            System.Console.WriteLine("Person #1 Age           : " + individual1.Age);
            System.Console.WriteLine("Person #1 Married?      : " + individual1.IsMarried);
            if (individual1.IsMarried == true)
            {
                System.Console.WriteLine("Person #1 Spouse        : " + individual1.Spouse);
                System.Console.WriteLine("Person #1 Spouse Age    : " + individual1.SpouseAge);  //why didn't it like spouse1.Age?
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Person #2 First Name    : " + individual2.FirstName);
            System.Console.WriteLine("Person #2 Last Name     : " + individual2.LastName);
            System.Console.WriteLine("Person #2 Age           : " + individual2.Age);
            System.Console.WriteLine("Person #2 Married?      : " + individual2.IsMarried);
            if (individual2.IsMarried == true)
            {
                System.Console.WriteLine("Person #2 Spouse        : " + individual2.Spouse);
                System.Console.WriteLine("Person #2 Spouse Age    : " + individual2.SpouseAge);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Person #3 First Name    : " + individual3.FirstName);
            System.Console.WriteLine("Person #3 Last Name     : " + individual3.LastName);
            System.Console.WriteLine("Person #3 Age           : " + individual3.Age);
            System.Console.WriteLine("Person #2 Married?      : " + individual3.IsMarried);
            if (individual3.IsMarried == true)
            {
                System.Console.WriteLine("Person #3 Spouse        : " + individual3.Spouse);
                System.Console.WriteLine("Person #3 Spouse Age    : " + individual3.SpouseAge);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Average Age: " + (Person.AgeSum / Person.PersonCount));

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
        //public void PrintNameAndAge()
        //{

        //}
        //public int GetAverageAge()  //This is the average of ALL individuals and spouses
        //{
        //        
        //}
        //public int GetIndividualAverageAge()  // This is the average age of only the individuals, not spouses.
        //{

    }
}
