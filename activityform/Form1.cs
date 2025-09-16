namespace StudentNamespace
{
    public partial class StudentInfoApp : Form
    {
        public StudentInfoApp()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(textBox1.Text);
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;


            StudentInfo student = new StudentInfo(student_id,firstname,lastname);
            /*student.first_name = fir*//*stname;
            student.last_name = lastname;*/




            listBox1.Items.Add(student.studentId);
            listBox2.Items.Add(student.first_name);
            listBox3.Items.Add(student.last_name);
        }
    }
}
