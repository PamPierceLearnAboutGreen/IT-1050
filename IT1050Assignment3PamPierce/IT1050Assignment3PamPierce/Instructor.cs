namespace IT1050Assignment3PamPierce
{
    public class Instructor
    {
        #region Member Variables
        private string InstructorName;
        private string CourseName;
        #endregion

        #region Constructors
        public Instructor(string instructorName, string courseName)
        {
            InstructorName = instructorName;
            CourseName = courseName;
        }
        #endregion

        #region Get and set member variables
        public string GetCourseName()
        {
            return CourseName;
        }
        public string GetInstructorName()
        {
            return InstructorName;
        }
        #endregion

        #region Instructor Public Methods
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }
        //print student firstname, lastname, and coursename
        public void Print()  //NOT USED
        {
            System.Console.WriteLine(GetInstructorName(), GetCourseName());
        }
        #endregion

    }

}
