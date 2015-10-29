using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Assignment3PamPierce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructors
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            //Students
            Student Jane = new Student("Jane", 0, John);
            Student Joe = new Student("Joe", 0, John);
            Student Melissa = new Student("Melissa", 0, Mike);
            Student Matt = new Student("Matt", 0, Mike);

            //Assign Grades
            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            //Students Print
            Jane.Print();
            Joe.Print();
            Melissa.Print();
            Matt.Print();

        }
    }
}
