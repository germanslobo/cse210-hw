// Assignment.cs
namespace Homework
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

        // Constructor accepting common fields
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Getter method so derived classes can read _studentName if needed
        public string GetStudentName()
        {
            return _studentName;
        }

        // Returns summary formatted as "Student - Topic"
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}