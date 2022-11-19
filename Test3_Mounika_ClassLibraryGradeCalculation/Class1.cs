namespace Test3_Mounika_ClassLibraryGradeCalculation
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int Standard { get; set; }



        public class Student_Info
        {
            public int StudentID { get; set; }
            public string? StudentName { get; set; }
            public int Standard { get; set; }



            public void SetStudentDetails()
            {
                Console.WriteLine("Enter Student ID");
                StudentID = int.Parse(Console.ReadLine());



                Console.WriteLine("Enter Student Nme");
                StudentName = Console.ReadLine();



                Console.WriteLine("Enter Student Standard");
                Standard = int.Parse(Console.ReadLine());
            }



            public void DisplayStudentDetails()
            {
                Console.WriteLine("Student ID : " + StudentID);
                Console.WriteLine("Student Nme : " + StudentName);
                Console.WriteLine("Student Standard : " + Standard);
            }
        }
    }