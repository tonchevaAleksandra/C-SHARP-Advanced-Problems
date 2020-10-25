using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> data;
        public int Capacity { get; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (this.data.Any(s => s.FirstName == firstName && s.LastName == lastName))
            {
                Student studentToRemove = this.data.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                this.data.Remove(studentToRemove);

                return $"Dismissed student {studentToRemove.FirstName} {studentToRemove.LastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            Student[] studentsBySubject = this.data.Where(s => s.Subject == subject).ToArray();
            if (studentsBySubject.Any())
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (Student student in studentsBySubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().Trim();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.data.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return student;
        }
    }
}
