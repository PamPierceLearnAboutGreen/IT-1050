namespace IT1050Assignment3PamPierce
{
    class Student
    {
        #region member variables
        private string StudentName;
        private int StudentGrade = 0;
        private Instructor Teacher;
        #endregion

        #region constructors
        public Student(string studentName, int studentGrade, Instructor teacher)
        {
            StudentName = studentName;
            StudentGrade = studentGrade;
            Teacher = teacher;
        }
        #endregion

        #region get and set member variables
        public string GetStudentName()
        {
            return StudentName;
        }
        public int GetStudentGrade()
        {
            return StudentGrade;
        }

        public string GetTeacher()
        {
            return Teacher.GetInstructorName();
        }
        #endregion

        #region public methods
        public void SetGrade(int grade)  
        {
            StudentGrade = grade;
        }
        public void Print()
        {
            System.Console.WriteLine("Student: " + GetStudentName() + " Grade: " + GetStudentGrade() + " Teacher: " + GetTeacher());
        }
        #endregion
    }
}
