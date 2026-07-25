// WritingAssignment.cs
namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        // Pass studentName and topic up to base class constructor
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            // Call GetStudentName() from the base class
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }
    }
}