using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        public int studentId {  get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public StudentInfo() {
            this.studentId = 0;
            this.first_name = "No Name";
            this.last_name = "No Name";
        }
        public StudentInfo(int studentId, string first_name, string last_name)
        {
            this.studentId = studentId;
            this.first_name = first_name;
            this.last_name = last_name;

        }
        public StudentInfo(int studentId, string first_name)
        {
            this.studentId = studentId;
            this.first_name = first_name;
            this.last_name = "No Name";

        }
        public StudentInfo(string first_name, string last_name)
        {
            this.studentId = 0;
            this.first_name = first_name;
            this.last_name = last_name;

        }

        /*        public int studentIdData{ 
                    get { return this.studentId; }
                    set { this.studentId = value; }
                }
                public string first_nameData
                {
                    get { return this.first_name; }
                    set { this.first_name = value; }
                }
                public string first_lastData
                {
                    get { return this.last_name; }
                    set { this.last_name = value; }
                }*/


    }
}
