using Lab_1.Models;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private List<StudentVm> _students;

        public Form1()
        {
            InitializeComponent();
            _students = new List<StudentVm>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _students.Clear();
            // ��������� ����� �� ����� �� ��������� ���������� ���� ������ �����
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultsListBox.Items.Clear();

                // ���������� ����� � ����� �� ��������� ����� �������� �� ������ � ListBox
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');
                        StudentVm student = new StudentVm()
                        {
                            LastName = data[0],
                            FirstName = data[1],
                            Address = data[2],
                            Phone = data[3]
                        };
                        _students.Add(student);
                        resultsListBox.Items.Add(student);
                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // �������� ���� TextBox1
            string textToWrite = textBox1.Text;

            // ����� ������ �������� �� ������ � TextBox1 � ����
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var student in _students)
                    {
                        writer.WriteLine($"{student.LastName},{student.FirstName},{student.Address},{student.Phone}");
                    }
                    writer.Write(textToWrite);
                }
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            // ���������� ��������� ������ �������� �� �����
            var currentStudents = _students.ToList();

            // ������������� �������� �� ������� �� ��������� ���������� � ListBox
            var sortedStudents = currentStudents.OrderBy(student => student.Address);

            resultsListBox.Items.Clear();
            foreach (var student in sortedStudents)
            {
                resultsListBox.Items.Add($"{student.LastName} {student.FirstName}, {student.Address}");
            }
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �������� �������� ������� � ������ ��������
            StudentVm student = resultsListBox.SelectedItem as StudentVm;

            // ������� TextBox � ����������� ��� ��������
            if (student != null)
            {
                textBox1.Text = "Name: " + student.LastName + Environment.NewLine;
                textBox1.Text += "Address: " + student.Address + Environment.NewLine;
                textBox1.Text += "Phone: " + student.Phone + Environment.NewLine;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {

            // �������� ���� TextBox1
            string textToWrite = textBox1.Text;

            // ³������ ���� ��� �����������
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // ��������� ���� ����� �� ���������� � TextBox1
                using (StreamReader reader = new StreamReader(filePath))
                {
                    textToWrite = reader.ReadToEnd();
                }

                // ³��������� ���� ����� � TextBox1
                textBox1.Text = textToWrite;
            }

        }
    }


}

