using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    //ABSTRACTION AND ENCAPSULATION
    public class Student : Teacher
    {
        private int StudentId { get; set; }
        private string StudentName { get; set; }
        private string StudentType { get; set; }


        public override string TeacherName {  get;  }
        public override string Description { get; }


        public Student(int studentId, string studentName, string studentType)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentType = studentType;
        }

        public Student(string teacherName, string desp)
        {
            TeacherName = teacherName;
            Description = desp;
        }

        public void StudentClassDetails()
        {
            if (StudentType.ToUpper() == "HIGHER SECONDARY")
            {
                ClassDetails();
            }

            else if (StudentType.ToUpper() == "SENIOR SECONDARY")
            {
                ClassDetails();
            }

            else if (StudentType.ToUpper() == "PRIMARY") 
            {
                ClassDetails();
            }

            else
            {
                ClassDetails();
            }
        }

        public void ClassDetails()
        {
            if (StudentType.ToUpper() == "HIGHER SECONDARY")
            {
                Console.WriteLine("Class 9 to 12 belongs to Higher Secondary");
            }

            else if(StudentType.ToUpper() == "SENIOR SECONDARY")
            {
                Console.WriteLine("Class 6 to 8 belongs to Senior Secondary");
            }

            else if(StudentType.ToUpper() == "PRIMARY")
            {
                Console.WriteLine("Class 1 to 5 belongs to Primary");
            }
            else
            {
                Console.WriteLine("You are not a school student");
            }
               
        }

       
        public override void SchoolDetails()
        {
            Console.WriteLine($"The teacher's details are as follows \nTeacherName : {TeacherName} " +
                $"and Description : {Description}");
        }
    }
}
