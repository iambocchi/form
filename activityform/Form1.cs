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
            int student_id;
            string firstname = textBox2.Text.Trim();
            string lastname = textBox3.Text.Trim();

            // If ID is invalid → set to 0
            if (!int.TryParse(textBox1.Text, out student_id))
            {
                student_id = 0;
            }

            
           StudentInfo student = new StudentInfo(
                student_id,
                string.IsNullOrWhiteSpace(firstname) ? "No Name" : firstname,
                string.IsNullOrWhiteSpace(lastname) ? "No Name" : lastname
            );
            
            listBox1.Items.Add(student.studentId);
            listBox2.Items.Add(student.first_name);
            listBox3.Items.Add(student.last_name);
        }

    }
}
