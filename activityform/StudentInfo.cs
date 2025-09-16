using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        public int studentId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public StudentInfo()
        {
            studentId = 0;
            first_name = "No Name";
            last_name = "No Name";
        }
        public StudentInfo(int studentId)
        {
            this.studentId = studentId;
            first_name = "No Name";
            last_name = "No Name";
        }

        public StudentInfo(int studentId, string first_name)
        {
            this.studentId = studentId;
            this.first_name = string.IsNullOrWhiteSpace(first_name) ? "No Name" : first_name;
            last_name = "No Name";
        }

        public StudentInfo(string first_name, string last_name)
        {
            studentId = 0;
            this.first_name = string.IsNullOrWhiteSpace(first_name) ? "No Name" : first_name;
            this.last_name = string.IsNullOrWhiteSpace(last_name) ? "No Name" : last_name;
        }
        public StudentInfo(int studentId, string first_name, string last_name)
        {
            this.studentId = studentId;
            this.first_name = string.IsNullOrWhiteSpace(first_name) ? "No Name" : first_name;
            this.last_name = string.IsNullOrWhiteSpace(last_name) ? "No Name" : last_name;
        }
    }

}
