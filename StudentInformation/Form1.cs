using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> studentList = new List<Student>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentList.Count < 3)
            {
                Student aStudent = new Student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;
                studentList.Add(aStudent);
                MessageBox.Show("\nStudent Added");
                regNoTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You Can not Enter More than 3 Students");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string StudentInfo = "RegNo \t Name \n";
            foreach (Student student in studentList)
            {
                StudentInfo+= student.regNo + "\t" + student.firstName + "\t" + student.lastName;
            }
            MessageBox.Show(StudentInfo);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            studentList = new List<Student>();
        }
    }
}
