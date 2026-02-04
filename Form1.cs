using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _students = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();
            SetupGridAndInputs();
        }

        private void SetupGridAndInputs()
        {
            // Fill the month dropdown with enum values
            cmbMonth.DataSource = Enum.GetValues(typeof(MonthOfAdmission));

            // Bind the grid to the student list
            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = _students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Basic validation + parsing
            if (!int.TryParse(txtStudId.Text.Trim(), out int id))
            {
                MessageBox.Show("StudId must be a number.");
                return;
            }

            string first = txtFirstName.Text.Trim();
            string last = txtLastName.Text.Trim();
            string addr = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
            {
                MessageBox.Show("FirstName and LastName are required.");
                return;
            }

            string gradeText = txtGrade.Text.Trim();
            if (gradeText.Length != 1)
            {
                MessageBox.Show("Grade must be exactly 1 character (ex: A, B, C).");
                return;
            }

            char grade = gradeText[0];

            if (cmbMonth.SelectedItem == null)
            {
                MessageBox.Show("Select a Month of Admission.");
                return;
            }

            var month = (MonthOfAdmission)cmbMonth.SelectedItem;

            // Optional: prevent duplicate IDs
            if (_students.Any(s => s.StudId == id))
            {
                MessageBox.Show("A student with this StudId already exists.");
                return;
            }

            // Add student
            _students.Add(new Student
            {
                StudId = id,
                FirstName = first,
                LastName = last,
                Address = addr,
                MonthOfAdmission = month,
                Grade = grade
            });

            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow?.DataBoundItem is Student selected)
            {
                _students.Remove(selected);
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }
        }

        private void ClearInputs()
        {
            txtStudId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtGrade.Clear();
            cmbMonth.SelectedIndex = 0;
            txtStudId.Focus();
        }
    }
}
